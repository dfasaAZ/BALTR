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
using Microsoft.Office.Interop.Word;
using System.Diagnostics;

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
            oleDbConnection1.ConnectionString.Replace(@"C:\\Users\\Lenovo\\Desktop\\Development\\BusinessApps\\BusinessProxyApp\\BDCafe.accdb", Path.Combine(Environment.CurrentDirectory, "BDCafe.accdb"));
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
            {///////////////////////Заполнение первой таблицы///////////////////////////////////////////
                Excel.Worksheet worksheet = workbook.Sheets["Лист1"];
                Excel.ListObject table = worksheet.ListObjects[tables[0]];
                var IData = table.Range.Value;

                int rowCount = IData.GetLength(0);
                int columnCount = IData.GetLength(1);

                for (int i = 2; i <= rowCount; i++) 
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
                /////////////////////Заполнение второй таблицы//////////////////////////////////////////////////////////////
                worksheet = workbook.Sheets["Лист2"];
                table = worksheet.ListObjects[tables[1]];
                IData = table.Range.Value;

                rowCount = IData.GetLength(0);
                columnCount = IData.GetLength(1);
                
                for (int i = 2; i <= rowCount; i++) 
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
                /////////////////////////Заполнение третьей таблицы/////////////////////////////////////////////////////////////////
                worksheet = workbook.Sheets["Лист3"];
                table = worksheet.ListObjects[tables[2]];
                IData = table.Range.Value;

                rowCount = IData.GetLength(0);
                columnCount = IData.GetLength(1);

                for (int i = 2; i <= rowCount; i++) 
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

        void repCreateDialog(string tmpPath)
        {
            if (MessageBox.Show("Отчёт создан, показать его?", "Создание отчёта", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Excel.Application App = new Excel.Application();
                App.Workbooks.Open(tmpPath);
                App.Visible = true;
            }
        }
        /*
         * Создание отчета Excel по ингредиентам
         */
        private void button2_Click(object sender, EventArgs e)
        {
            string relativePath = Path.Combine(Environment.CurrentDirectory, "report1.xlsx");
            var   table = this.bDCafeDataSet.Ингредиенты;
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            try
            {
                
                worksheet.Cells[1, 1] = "Прайс-лист ингредиентов";
                worksheet.Cells[1, 1].Font.Bold = true;
                worksheet.Cells[1, 1].Font.Size = 16;

                worksheet.Cells[2, 1] = "Дата составления отчета";
                worksheet.Cells[2, 1].Font.Bold = true;
                worksheet.Cells[2, 2] = DateTime.Now.ToShortDateString();

               
                int row = 4;
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    worksheet.Cells[row, i + 1] = table.Columns[i].ColumnName;
                }

                row++;
                foreach (DataRow dr in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        worksheet.Cells[row, i + 1] = dr[i].ToString();
                    }
                    row++;
                }

                
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    worksheet.Columns[i + 1].AutoFit();
                }
            }catch (Exception ex) { excel.Quit();MessageBox.Show(ex.Message); }
            workbook.SaveAs(relativePath);
            
            
            excel.Quit();
            repCreateDialog(relativePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string relativePath = Path.Combine(Environment.CurrentDirectory, "report2.xlsx");

            string dishID;


            try
            {
               
                dishID = recipeGridView.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Для формирования отчета выберите строку из таблицы с ингредиентами");
               
                dishID = "1";
            }

            //Запрос на получение дочерних записей таблицы рецептов
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
            var table = query.ToList();
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            try
            {
                
                worksheet.Cells[1, 2] = "Состав блюда ";
                worksheet.Cells[1, 2].Font.Bold = true;
                worksheet.Cells[1, 2].Font.Size = 18;

                worksheet.Cells[2, 1] = "Дата составления отчета:";
                worksheet.Cells[2, 2] = DateTime.Now.ToShortDateString();

                worksheet.Cells[3, 2] = "Ниже представлены ингридиенты нашего блюда";
                worksheet.Cells[3, 2].Font.Color = System.Drawing.Color.Crimson;
                worksheet.Cells[3, 2].Font.Italic = true;   
                //Загружаем данные
                int row = 4;
                foreach (var item in table)
                {
                    System.Drawing.Color rowcolor;
                    if (row%2==0)
                    {
                        rowcolor = System.Drawing.Color.Chocolate;
                    }else rowcolor = System.Drawing.Color.White;
                    worksheet.Cells[row, 1] = item.RecipeId;
                    worksheet.Cells[row, 1].Interior.Color= rowcolor;
                    worksheet.Cells[row, 2] = item.DishName;
                    worksheet.Cells[row, 2].Interior.Color= rowcolor;
                    worksheet.Cells[row, 3] = item.IngredientName;
                    worksheet.Cells[row, 3].Interior.Color= rowcolor;
                    worksheet.Cells[row, 3].Font.Color = System.Drawing.Color.Aqua;
                    row++;
                }
                worksheet.Range["A:B"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                worksheet.Columns.AutoFit();


                workbook.SaveAs(relativePath);

                workbook.Close();
                excel.Quit();
                repCreateDialog(relativePath);
            }
            catch (Exception)
            {
                workbook.Close();
                excel.Quit();
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string html = @"
<html>
<body>

<h1>Рецепт блюда</h1>

<p>Date: {0}</p> 

<table border='1'>
<tr>
<th>Код</th>
<th>Название блюда</th> 
<th>Ингредиент</th>
</tr>
{1}
</table>

</body>
</html>";
            string dishID;


            try
            {

                dishID = recipeGridView.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Для формирования отчета выберите строку из таблицы с ингредиентами");

                dishID = "1";
            }

            //Запрос на получение дочерних записей таблицы рецептов
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
            var table = query.ToList();

            string rows = "";
            foreach (var item in table)
            {
                rows += $"<tr>";
                rows += $"<td>{item.RecipeId}</td>";
                rows += $"<td>{item.DishName}</td>";
                rows += $"<td>{item.IngredientName}</td>";
                rows += "</tr>";
            }
            string tmppath;
            //запихиваем всё в файл, второй и третий аргументы подставляются вместе с фигурными скобками в html
            string htmlContent = string.Format(html, DateTime.Now.ToShortDateString(), rows);
            if (HTMLSaveDialog.ShowDialog() == DialogResult.OK)
            {
                tmppath = HTMLSaveDialog.FileName;
                File.WriteAllText(HTMLSaveDialog.FileName, htmlContent);
                Process.Start(tmppath);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var table = this.bDCafeDataSet.Ингредиенты;
            string html = @"<html>
                  <body>
                  
                  <h1>Прайс-лист ингредиентов</h1>
                  
                  <p>Дата составления отчета: {0}</p>
                  
                  <table border='1'>
                  <tr> <th> Код </th>
<th> Название ингредиента</th >
<th> Цена </th ></tr>";

            
           

            

            foreach (DataRow row in table.Rows)
            {
                html += "<tr>";
                foreach (DataColumn col in table.Columns)
                {
                    html += $"<td>{row[col.ColumnName]}</td>";
                }
                html += "</tr>";
            }

            html += "</table></body></html>";

           
            string htmlContent = string.Format(html, DateTime.Now.ToShortDateString());
            string tmppath;
           
            if (HTMLSaveDialog.ShowDialog() == DialogResult.OK)
            {
                tmppath = HTMLSaveDialog.FileName;
                File.WriteAllText(HTMLSaveDialog.FileName, htmlContent);
                Process.Start(tmppath);
            }
        }
    }
}
