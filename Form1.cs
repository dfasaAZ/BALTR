using BusinessProxyApp.BDTimeSheetDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using Microsoft.Office.Interop.Word;

using WpfControlLibrary1;

namespace BusinessProxyApp
{
    public partial class MainForm : Form
    {
        bool _isLoaded=false;
        UserControl1 wpf_control;
        public MainForm()
        {
            InitializeComponent();
            wpf_control = (UserControl1)elementHost1.Child;
            wpf_control.TextChanged += Wpf_control_TextChanged;
            wpf_control.Click += Wpf_control_Click;
        }

        private void Wpf_control_Click()
        {
            if (_isLoaded)
            {
                jobsBindingSource.Filter = "Title like '" + wpf_control.Text + "*'";
            }
        }

        private void Wpf_control_TextChanged(object sender, string newValue)
        {
            wpf_control.Text=newValue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDTimeSheetDataSet.TimeTable". При необходимости она может быть перемещена или удалена.
            oleDbConnection1.ConnectionString.Replace(@"C:\\Users\\Lenovo\\Desktop\\Development\\BusinessApps\\BusinessProxyApp\\BDTimeSheet.accdb", Path.Combine(Environment.CurrentDirectory, "BDTimeSheet.accdb"));
            this.timeTableTableAdapter.Fill(this.bDTimeSheetDataSet.TimeTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDTimeSheetDataSet.Jobs". При необходимости она может быть перемещена или удалена.
            this.jobsTableAdapter.Fill(this.bDTimeSheetDataSet.Jobs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDTimeSheetDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.bDTimeSheetDataSet.Employees);
            dateTimePicker1_ValueChanged(sender,e);
            _isLoaded = true;
        }

        private void UpdateButton1_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeesAdapter.Update(bDTimeSheetDataSet);
        }catch(Exception ex) { MessageBox.Show("Ошибка сохранения таблицы, проверьте поля на отсутствие дубликатов и/или ошибок в типе данных"); };
}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                timeTableEdit.Filter = string.Format("WorkDate = '{0:dd.MM.yyyy}'", dateTimePicker1.Value.Date.ToString());
            }catch(Exception ex) { MessageBox.Show("Произошло что-то плохое"); }    
            }


        private void UpdateButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            timeTableEdit.EndEdit();
            try{
                TimeTableAdapter.Update(bDTimeSheetDataSet);
            }catch(Exception ex) { MessageBox.Show("Ошибка сохранения таблицы, проверьте поля на отсутствие дубликатов и/или ошибок в типе данных"); };
        }

        private void timesheetEdit_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            timesheetEdit.Rows[e.Row.Index - 1].Cells[0].Value = dateTimePicker1.Value.Date;
        }

        private void timesheetEdit_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ошибка ввода данных, проверьте уникальность столбов");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jobsBindingSource.Filter != null)
            {
                jobsBindingSource.RemoveFilter();
            }
            if (employeesBindingSource.Filter!=null)
            {
                employeesBindingSource.RemoveFilter();
            }
            
            if (timeTableBindingSource.Filter != null)
            {
                timeTableBindingSource.RemoveFilter();
            }
            
            
            
        }

        private void EmployeesFilter_TextChanged(object sender, EventArgs e)
        {
            employeesBindingSource.Filter="FullName like '"+EmployeesFilter.Text+"*'";
        }

        private void EmployeesFilter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoaded)
            {
                employeesBindingSource.Filter = "Job = " + EmployeesFilter1.SelectedValue;
            }
            
        }

        private void JobFilter_TextChanged(object sender, EventArgs e)
        {
            if (_isLoaded)
            {
                jobsBindingSource.Filter = "Title like '" + JobFilter.Text + "*'";
            }
        }

        private void TimesheetFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_isLoaded)
            {
                timeTableBindingSource.Filter = "Employee = " + TimesheetFilter.SelectedValue;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            jobsTable.Rows.RemoveAt(jobsTable.SelectedCells[0].RowIndex);
        }

        private void UpdateButton2_Click(object sender, EventArgs e)
        {
            try
            {
                JobsAdapter.Update(bDTimeSheetDataSet);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка сохранения таблицы, проверьте поля на отсутствие дубликатов и/или ошибок в типе данных"); };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            employeesTable.Rows.RemoveAt(employeesTable.SelectedCells[0].RowIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timesheetEdit.Rows.RemoveAt(timesheetEdit.SelectedCells[0].RowIndex);
        }
        void docCreateDialog(string tmpPath)
        {
            if (MessageBox.Show("Открыть документ", "Создание документа", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Word.Application wordApp = new Word.Application();
                wordApp.Documents.Open(tmpPath);
                wordApp.Visible = true;
            }
        }
        private void wordSummaryButton_Click(object sender, EventArgs e)
        {
            string templateName = "template1.docx";
            string relativePath = Path.Combine(Environment.CurrentDirectory, templateName);
            DataGridViewCell cell=null;


            try
            {
                cell = timesheetTable.SelectedCells[0].OwningRow.Cells[1];
                
            }
            catch
            {
                MessageBox.Show("Для формирования документа выберите строку из таблицы сводка посещаемости");
               
            }
            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Open(relativePath);
            try
            {
                doc.Content.Find.Execute("<name>", ReplaceWith: cell.EditedFormattedValue.ToString());
                doc.Content.Find.Execute("<date>", ReplaceWith: DateTime.Now.ToShortDateString());
                var query = from r in bDTimeSheetDataSet.TimeTable
                            join d in bDTimeSheetDataSet.Employees on r.Employee equals d.id
                            where r.Employee.ToString() == cell.Value.ToString()
                            select new
                            {
                                Date = r.WorkDate,
                                FIO = d.FullName,
                                IsPresent = r.IsPresent
                            };
                var tableMark = doc.Bookmarks["table"].Range;
                var tmpTable = query.ToList();
                Word.Table table = doc.Tables.Add(tableMark, tmpTable.Count() + 1, 3);
                table.Cell(1, 1).Range.Text = "Дата";
                table.Cell(1, 2).Range.Text = "Сотрудник";
                table.Cell(1, 3).Range.Text = "Наличие на раб. месте";
                table.Borders.Enable = 1;
                int rowIndex = 2;
                foreach (var row in tmpTable)
                {
                    table.Cell(rowIndex, 1).Range.Text = row.Date.ToShortDateString();
                    table.Cell(rowIndex, 2).Range.Text = row.FIO;
                    table.Cell(rowIndex, 3).Range.Text = row.IsPresent?"Присутствовал":"Отсутствовал";

                    rowIndex++;
                }
            }
            catch { doc.Close(); wordApp.Quit(); }
            doc.SaveAs2("filled_report.docx");
            string tmpPath = doc.FullName;
            doc.Close();
            wordApp.Quit();
            docCreateDialog(tmpPath);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string templateName = "template2.docx";
            string relativePath = Path.Combine(Environment.CurrentDirectory, templateName);

            DataGridViewRow row = null;

            try
            {
              row = jobsTable.SelectedCells[0].OwningRow;

            }
            catch
            {
                MessageBox.Show("Для формирования документа выберите строку из таблицы с должностями");
                
            }

            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Open(relativePath);

            doc.Content.Find.Execute("<jobtype>", ReplaceWith: row.Cells[1].Value.ToString());
            doc.Content.Find.Execute("<salary>", ReplaceWith: row.Cells[2].Value.ToString());

            doc.SaveAs2("filled_vacancy.docx");
            string tmpPath = doc.FullName;
            doc.Close();
            wordApp.Quit();
            docCreateDialog(tmpPath);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = timesheetTable.SelectedCells[0].OwningRow.Cells[1];

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Worksheets[1];
            worksheet.Cells[1, 2] = "Сводка посещаемости сотрудника";
            worksheet.Cells[1, 3] = cell.FormattedValue;
            worksheet.Cells[1, 3].Font.Bold = true;

            worksheet.Cells[3, 1] = "Дата";
            worksheet.Cells[3, 2] = "Сотрудник";
            worksheet.Cells[3, 3] = "Наличие на раб. месте";

            var query = from r in bDTimeSheetDataSet.TimeTable
                        join d in bDTimeSheetDataSet.Employees on r.Employee equals d.id
                        where r.Employee.ToString() == cell.Value.ToString()
                        select new
                        {
                            Date = r.WorkDate,
                            FIO = d.FullName,
                            IsPresent = r.IsPresent
                        };

            int row = 4;
            foreach (var item in query)
            {
                worksheet.Cells[row, 1] = item.Date;
                worksheet.Cells[row, 2] = item.FIO;
                worksheet.Cells[row, 3] = item.IsPresent ? "Присутствовал" : "Отсутствовал";
                row++;
            }
            Excel.Range t = worksheet.Range["A6:C6"];
            t.Merge();
            worksheet.Cells[row, 1] = "Прогулы являются поводом для увольнения, все отсутствия должны быть подкреплены уважительной причиной.";
            worksheet.Cells[row, 1].Font.Italic = true;
            worksheet.Columns.AutoFit();
            workbook.SaveAs("ExcelSummary.xlsx");
            excelApp.Quit();

            ShowExcelDialog("ExcelSummary.xlsx");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = jobsTable.SelectedCells[0].OwningRow;

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Worksheets[1];

            worksheet.Cells[1, 1] = "Внимание!!!";
            worksheet.Cells[1, 1].Font.Bold = true;

            worksheet.Cells[2, 2] = "У ООО 'Пупырка' открывается набор на должность";
            worksheet.Cells[2, 3] = row.Cells[1].Value;
            worksheet.Cells[2, 3].Font.Bold = true;
            worksheet.Columns[2].AutoFit();

            worksheet.Cells[3, 1] = "Мы предлагаем много хорошего и ничего плохого";

            worksheet.Cells[4, 2] = "И готовы платить вам невообразимые"; 
            worksheet.Cells[5, 2] = row.Cells[2].Value;
            worksheet.Cells[5, 2].Font.Bold = true;
            worksheet.Cells[5, 2].Font.Size = 48;

            worksheet.Cells[5, 3] = "рублей";
            workbook.SaveAs("ExcelVacancy.xlsx");
            excelApp.Quit();

            ShowExcelDialog("ExcelVacancy.xlsx");
        }
        private void ShowExcelDialog(string filePath)
        {
            if (MessageBox.Show("Открыть документ?", "Готово", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
                excelApp.Visible = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {


            var tables = new[] { "Таблица_Employees", "Таблица_Jobs", "Таблица_TimeTable" };
            string relativePath = Path.Combine(Environment.CurrentDirectory, "ExcelImport.xlsx");
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(relativePath);
            try
            {///////////////////////Заполнение первой таблицы///////////////////////////////////////////
                Excel.Worksheet worksheet = workbook.Sheets[tables[1]];
                Excel.ListObject table = worksheet.ListObjects[tables[1]];
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
                    if (!bDTimeSheetDataSet.Jobs.Rows.Contains(rowData[0]))
                    {
                        bDTimeSheetDataSet.Jobs.Rows.Add(rowData);
                    }

                }
                /////////////////////Заполнение второй таблицы//////////////////////////////////////////////////////////////
                worksheet = workbook.Sheets[tables[0]];
                table = worksheet.ListObjects[tables[0]];
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
                    if (!bDTimeSheetDataSet.Employees.Rows.Contains(rowData[0]))
                    {
                        bDTimeSheetDataSet.Employees.Rows.Add(rowData);
                    }

                }
                /////////////////////////Заполнение третьей таблицы/////////////////////////////////////////////////////////////////
                worksheet = workbook.Sheets[tables[2]];
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
                    if (!bDTimeSheetDataSet.TimeTable.Rows.Contains(new Object[]{ rowData[0], rowData[1]}))//так замудрено потому что в таблице составной первичный ключ
                    {
                        bDTimeSheetDataSet.TimeTable.Rows.Add(rowData);
                    }

                }
                //////////////////////////////////////////////////////////////////////////////////////////////////
            }
            catch (Exception ex)
            {
                workbook.Close();
                excelApp.Quit();
                MessageBox.Show(ex.Message);

            }
            workbook.Close();
            excelApp.Quit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string html = @"
<html>
<body>
<center>
<h1>Табель посещений рабочего места сотрудником</h1>
<p><b>{2}</b></p>

<p>Сформировано {0}</p> 

<table border='1'>
<tr>
<th>Дата</th>
<th>ФИО сотрудника</th> 
<th>Присутствие</th>
</tr>
{1}
</table>

</body>
</html>";
            DataGridViewCell cell = null;


            try
            {
                cell = timesheetTable.SelectedCells[0].OwningRow.Cells[1];

            }
            catch
            {
                MessageBox.Show("Для формирования документа выберите строку из таблицы сводка посещаемости");

            }

            var query = from r in bDTimeSheetDataSet.TimeTable
                        join d in bDTimeSheetDataSet.Employees on r.Employee equals d.id
                        where r.Employee.ToString() == cell.Value.ToString()
                        select new
                        {
                            Date = r.WorkDate,
                            FIO = d.FullName,
                            IsPresent = r.IsPresent
                        };
            
            var table = query.ToList();

            string rows = "";
            foreach (var item in table)
            {
                rows += $"<tr>";
                rows += $"<td>{item.Date.ToShortDateString()}</td>";
                rows += $"<td>{item.FIO}</td>";
                rows += $"<td>{(item.IsPresent?("Присутствует"):("Отсутствует"))}</td>";
                rows += "</tr>";
            }
            string tmppath;
            //запихиваем всё в файл, второй и третий аргументы подставляются вместе с фигурными скобками в html
            string htmlContent = string.Format(html, DateTime.Now.ToShortDateString(), rows,cell.FormattedValue);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tmppath = saveFileDialog1.FileName;
                File.WriteAllText(saveFileDialog1.FileName, htmlContent);
                Process.Start(tmppath);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var Job = jobsTable.SelectedCells[0].OwningRow;
          
            string html = @"<html>
                  <body>
                  <center>
                  <h1>Внимание!!!</h1>
                  <h2> Открыт набор на вакансию {1}</h2>
                  <p>Данные актуальны на : {0}</p><br>
                  Мы предлагаем комфортные условия работы, дружный коллектив и <br>конкурентную заработную плату в размере <ul><u><b>{2}</b></u></ul> Рублей <br>
За дополнительной информацией обращайтесь в отдел кадров
                 </body></html> ";



            string htmlContent = string.Format(html, DateTime.Now.ToShortDateString(), Job.Cells[1].Value, Job.Cells[2].Value.ToString());
            string tmppath;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tmppath = saveFileDialog1.FileName;
                File.WriteAllText(saveFileDialog1.FileName, htmlContent);
                Process.Start(tmppath);
            }
        }
    }
}
