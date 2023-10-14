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
    public partial class Form1 : Form
    {
        public Form1()
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

        }
    }
}
