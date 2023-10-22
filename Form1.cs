using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using System.CodeDom;

namespace BusinessProxyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDCafeDataSet.Рецепты". При необходимости она может быть перемещена или удалена.
            this.рецептыTableAdapter.Fill(this.bDCafeDataSet.Рецепты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDCafeDataSet.Ингредиенты". При необходимости она может быть перемещена или удалена.
            this.ингредиентыTableAdapter.Fill(this.bDCafeDataSet.Ингредиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDCafeDataSet.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter.Fill(this.bDCafeDataSet.Блюда);

            
           

            
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            ingredientGridView.Rows.RemoveAt(ingredientGridView.SelectedCells[0].RowIndex);
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            dishGridView.Rows.RemoveAt(dishGridView.SelectedCells[0].RowIndex);
        }

        private void deleteButton3_Click(object sender, EventArgs e)
        {
            recipeGridView.Rows.RemoveAt(recipeGridView.SelectedCells[0].RowIndex);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            рецептыBindingSource.Filter="Dish = "+comboBox1.SelectedValue;
        }

        private void recipeGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
           // MessageBox.Show("Для заполнения таблицы необходимо очистить фильтры");
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            рецептыBindingSource.Filter = "Ingredient = " + comboBox2.SelectedValue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            блюдаBindingSource.Filter="DishName like '*"+textBox1.Text+"*'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ингредиентыBindingSource.Filter="ProductName like '*"+textBox2.Text+"*'";  
        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {
            IngredientsAdapter.Update(bDCafeDataSet);
        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            DishesAdapter.Update(bDCafeDataSet);
        }

        private void SaveButton3_Click(object sender, EventArgs e)
        {
            RecipesAdapter.Update(bDCafeDataSet);
        }

        private void docButton1_Click(object sender, EventArgs e)
        {
            string templateName = "DocTemplate1.docx";
            string relativePath = Path.Combine(Environment.CurrentDirectory, templateName);
            string productInfo;


            try
            {
                productInfo = ingredientGridView.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
                
            }
            catch
            {
                MessageBox.Show("Для формирования документа выберите строку из таблицы с ингредиентами");
                productInfo = "no product"; 
            }

            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Open(relativePath);
           
            doc.Content.Find.Execute("<product>", ReplaceWith: productInfo);


            doc.SaveAs2("filled_product.docx");
            string tmpPath = doc.FullName;
            doc.Close();
            wordApp.Quit();
            docCreateDialog(tmpPath);

        }
        void docCreateDialog(string tmpPath) { 
            if (MessageBox.Show("Документ создан, показать его?", "Создание документа", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Word.Application wordApp = new Word.Application();
                wordApp.Documents.Open(tmpPath);
                wordApp.Visible = true;
            } }

        private void docButton2_Click(object sender, EventArgs e)
        {
            string templateName = "DocTemplate2.docx";
            string relativePath = Path.Combine(Environment.CurrentDirectory, templateName);
            string dishInfo;
            string dishID;


            try
            {
                dishInfo = recipeGridView.SelectedCells[0].OwningRow.Cells[1].EditedFormattedValue.ToString();
                dishID = recipeGridView.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Для формирования документа выберите строку из таблицы с ингредиентами");
                dishInfo = "no dish";
                dishID = "1";
            }
            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Open(relativePath);
            try
            {
                doc.Content.Find.Execute("<dish>", ReplaceWith: dishInfo);
                var query = from r in bDCafeDataSet.Рецепты
                            join d in bDCafeDataSet.Блюда on r.dish equals d.id
                            join i in bDCafeDataSet.Ингредиенты on r.ingredient equals i.id
                            where r.dish.ToString() == dishID
                            select new
                            {
                                RecipeId = r.id,
                                DishName = d.DishName,
                                IngredientName = i.ProductName
                            };
                var tableMark =doc.Bookmarks["table"].Range;
                var tmpTable = query.ToList();
                Word.Table table = doc.Tables.Add(tableMark, tmpTable.Count()+1, 3);
                table.Cell(1, 1).Range.Text = "Код";
                table.Cell(1, 2).Range.Text = "Блюдо";
                table.Cell(1, 3).Range.Text = "Ингредиент";
                table.Borders.Enable = 1;
                int rowIndex = 2;
                foreach (var row in tmpTable)
                {
                    table.Cell(rowIndex, 1).Range.Text = row.RecipeId.ToString();
                    table.Cell(rowIndex, 2).Range.Text = row.DishName;
                    table.Cell(rowIndex, 3).Range.Text = row.IngredientName;

                    rowIndex++;
                }
            }
            catch { doc.Close(); wordApp.Quit(); }
            doc.SaveAs2("filled_recipe.docx");
            string tmpPath = doc.FullName;
            doc.Close();
            wordApp.Quit();
            docCreateDialog(tmpPath);
        }

        private void ImportExcel_Click(object sender, EventArgs e)
        {
            
            var tables =new[]{ "Таблица_Блюда", "Таблица_Ингредиенты", "Таблица_Рецепты" };
            string relativePath = Path.Combine(Environment.CurrentDirectory, "ExcelImport1.xlsx");
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(relativePath);
            try
            {//////////////////////////////////////////////////////////////////
                Excel.Worksheet worksheet = workbook.Sheets["Лист1"];
                Excel.ListObject table = worksheet.ListObjects[tables[0]];
                var IData = table.Range.Value;

                int rowCount = IData.GetLength(0);
                int columnCount = IData.GetLength(1);

                for (int i = 2; i <= rowCount; i++) // Start from row 2 to skip the header row
                {
                    object[] rowData = new object[columnCount];

                    for (int j = 1; j <= columnCount; j++)
                    {
                        rowData[j - 1] = IData[i, j];
                    }
                    if (!bDCafeDataSet.Блюда.Rows.Contains(rowData[0]))
                    {
                        bDCafeDataSet.Блюда.Rows.Add(rowData);
                    }

                }
                ///////////////////////////////////////////////////////////////////////////////////
                worksheet = workbook.Sheets["Лист2"];
                table = worksheet.ListObjects[tables[1]];
                IData = table.Range.Value;

                rowCount = IData.GetLength(0);
                columnCount = IData.GetLength(1);
                
                for (int i = 2; i <= rowCount; i++) // Start from row 2 to skip the header row
                {
                    object[] rowData = new object[columnCount];

                    for (int j = 1; j <= columnCount; j++)
                    {
                        rowData[j - 1] = IData[i, j];
                    }
                    if (!bDCafeDataSet.Ингредиенты.Rows.Contains(rowData[0]))
                    {
                        bDCafeDataSet.Ингредиенты.Rows.Add(rowData);
                    }
                    
                }
                //////////////////////////////////////////////////////////////////////////////////////////
                worksheet = workbook.Sheets["Лист3"];
                table = worksheet.ListObjects[tables[2]];
                IData = table.Range.Value;

                rowCount = IData.GetLength(0);
                columnCount = IData.GetLength(1);

                for (int i = 2; i <= rowCount; i++) // Start from row 2 to skip the header row
                {
                    object[] rowData = new object[columnCount];

                    for (int j = 1; j <= columnCount; j++)
                    {
                        rowData[j - 1] = IData[i, j];
                    }
                    if (!bDCafeDataSet.Рецепты.Rows.Contains(rowData[0]))
                    {
                        bDCafeDataSet.Рецепты.Rows.Add(rowData);
                    }

                }
                //////////////////////////////////////////////////////////////////////////////////////////////////
            }
            catch(Exception ex) {
                workbook.Close();
                excelApp.Quit();
                MessageBox.Show(ex.Message);
                
            }
            workbook.Close();
            excelApp.Quit();
        }
    }
}
