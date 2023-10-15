using BusinessProxyApp.BDTimeSheetDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessProxyApp
{
    public partial class MainForm : Form
    {
        bool _isLoaded=false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDTimeSheetDataSet.TimeTable". При необходимости она может быть перемещена или удалена.
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
    }
}
