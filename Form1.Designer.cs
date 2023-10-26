namespace BusinessProxyApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.EmployeesAdapter = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.JobsAdapter = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.TimeTableAdapter = new System.Data.OleDb.OleDbDataAdapter();
            this.employeesTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDTimeSheetDataSet = new BusinessProxyApp.BDTimeSheetDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new BusinessProxyApp.BDTimeSheetDataSetTableAdapters.EmployeesTableAdapter();
            this.jobsTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobsTableAdapter = new BusinessProxyApp.BDTimeSheetDataSetTableAdapters.JobsTableAdapter();
            this.timesheetTable = new System.Windows.Forms.DataGridView();
            this.workDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.isPresentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.timeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeTableTableAdapter = new BusinessProxyApp.BDTimeSheetDataSetTableAdapters.TimeTableTableAdapter();
            this.UpdateButton1 = new System.Windows.Forms.Button();
            this.UpdateButton2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timesheetEdit = new System.Windows.Forms.DataGridView();
            this.workDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.isPresentDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.timeTableEdit = new System.Windows.Forms.BindingSource(this.components);
            this.UpdateButton3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimesheetFilter = new System.Windows.Forms.ComboBox();
            this.JobFilter = new System.Windows.Forms.TextBox();
            this.ClearFilters = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.EmployeesFilter = new System.Windows.Forms.TextBox();
            this.EmployeesFilter1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.wordSummaryButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTimeSheetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timesheetTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timesheetEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\Desktop\\Development" +
    "\\BusinessApps\\BusinessProxyApp\\BDTimeSheet.accdb;Persist Security Info=True";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Employees.*\r\nFROM            Employees";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Employees` (`FullName`, `Job`) VALUES (?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("FullName", System.Data.OleDb.OleDbType.VarWChar, 0, "FullName"),
            new System.Data.OleDb.OleDbParameter("Job", System.Data.OleDb.OleDbType.Integer, 0, "Job")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE `Employees` SET `FullName` = ?, `Job` = ? WHERE ((`id` = ?) AND ((? = 1 AN" +
    "D `FullName` IS NULL) OR (`FullName` = ?)) AND ((? = 1 AND `Job` IS NULL) OR (`J" +
    "ob` = ?)))";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("FullName", System.Data.OleDb.OleDbType.VarWChar, 0, "FullName"),
            new System.Data.OleDb.OleDbParameter("Job", System.Data.OleDb.OleDbType.Integer, 0, "Job"),
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FullName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FullName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FullName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FullName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Job", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Job", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Job", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Job", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `Employees` WHERE ((`id` = ?) AND ((? = 1 AND `FullName` IS NULL) OR " +
    "(`FullName` = ?)) AND ((? = 1 AND `Job` IS NULL) OR (`Job` = ?)))";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FullName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FullName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FullName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FullName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Job", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Job", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Job", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Job", System.Data.DataRowVersion.Original, null)});
            // 
            // EmployeesAdapter
            // 
            this.EmployeesAdapter.DeleteCommand = this.oleDbDeleteCommand1;
            this.EmployeesAdapter.InsertCommand = this.oleDbInsertCommand1;
            this.EmployeesAdapter.SelectCommand = this.oleDbSelectCommand1;
            this.EmployeesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Employees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("FullName", "FullName"),
                        new System.Data.Common.DataColumnMapping("Job", "Job")})});
            this.EmployeesAdapter.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        Jobs.*\r\nFROM            Jobs";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `Jobs` (`Title`, `BaseSalary`) VALUES (?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 0, "Title"),
            new System.Data.OleDb.OleDbParameter("BaseSalary", System.Data.OleDb.OleDbType.Currency, 0, "BaseSalary")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = "UPDATE `Jobs` SET `Title` = ?, `BaseSalary` = ? WHERE ((`id` = ?) AND ((? = 1 AND" +
    " `Title` IS NULL) OR (`Title` = ?)) AND ((? = 1 AND `BaseSalary` IS NULL) OR (`B" +
    "aseSalary` = ?)))";
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 0, "Title"),
            new System.Data.OleDb.OleDbParameter("BaseSalary", System.Data.OleDb.OleDbType.Currency, 0, "BaseSalary"),
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Title", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_BaseSalary", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BaseSalary", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_BaseSalary", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BaseSalary", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = "DELETE FROM `Jobs` WHERE ((`id` = ?) AND ((? = 1 AND `Title` IS NULL) OR (`Title`" +
    " = ?)) AND ((? = 1 AND `BaseSalary` IS NULL) OR (`BaseSalary` = ?)))";
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Title", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_BaseSalary", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BaseSalary", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_BaseSalary", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BaseSalary", System.Data.DataRowVersion.Original, null)});
            // 
            // JobsAdapter
            // 
            this.JobsAdapter.DeleteCommand = this.oleDbDeleteCommand2;
            this.JobsAdapter.InsertCommand = this.oleDbInsertCommand2;
            this.JobsAdapter.SelectCommand = this.oleDbSelectCommand2;
            this.JobsAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Jobs", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("Title", "Title"),
                        new System.Data.Common.DataColumnMapping("BaseSalary", "BaseSalary")})});
            this.JobsAdapter.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT        TimeTable.*\r\nFROM            TimeTable";
            this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `TimeTable` (`WorkDate`, `Employee`, `IsPresent`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("WorkDate", System.Data.OleDb.OleDbType.Date, 0, "WorkDate"),
            new System.Data.OleDb.OleDbParameter("Employee", System.Data.OleDb.OleDbType.Integer, 0, "Employee"),
            new System.Data.OleDb.OleDbParameter("IsPresent", System.Data.OleDb.OleDbType.Boolean, 0, "IsPresent")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = "UPDATE `TimeTable` SET `WorkDate` = ?, `Employee` = ?, `IsPresent` = ? WHERE ((`W" +
    "orkDate` = ?) AND (`Employee` = ?) AND ((? = 1 AND `IsPresent` IS NULL) OR (`IsP" +
    "resent` = ?)))";
            this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("WorkDate", System.Data.OleDb.OleDbType.Date, 0, "WorkDate"),
            new System.Data.OleDb.OleDbParameter("Employee", System.Data.OleDb.OleDbType.Integer, 0, "Employee"),
            new System.Data.OleDb.OleDbParameter("IsPresent", System.Data.OleDb.OleDbType.Boolean, 0, "IsPresent"),
            new System.Data.OleDb.OleDbParameter("Original_WorkDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WorkDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Employee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Employee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_IsPresent", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IsPresent", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_IsPresent", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IsPresent", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = "DELETE FROM `TimeTable` WHERE ((`WorkDate` = ?) AND (`Employee` = ?) AND ((? = 1 " +
    "AND `IsPresent` IS NULL) OR (`IsPresent` = ?)))";
            this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_WorkDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WorkDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Employee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Employee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_IsPresent", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IsPresent", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_IsPresent", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IsPresent", System.Data.DataRowVersion.Original, null)});
            // 
            // TimeTableAdapter
            // 
            this.TimeTableAdapter.DeleteCommand = this.oleDbDeleteCommand3;
            this.TimeTableAdapter.InsertCommand = this.oleDbInsertCommand3;
            this.TimeTableAdapter.SelectCommand = this.oleDbSelectCommand3;
            this.TimeTableAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TimeTable", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("WorkDate", "WorkDate"),
                        new System.Data.Common.DataColumnMapping("Employee", "Employee"),
                        new System.Data.Common.DataColumnMapping("IsPresent", "IsPresent")})});
            this.TimeTableAdapter.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // employeesTable
            // 
            this.employeesTable.AutoGenerateColumns = false;
            this.employeesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn});
            this.employeesTable.DataSource = this.employeesBindingSource;
            this.employeesTable.Location = new System.Drawing.Point(21, 56);
            this.employeesTable.Name = "employeesTable";
            this.employeesTable.RowHeadersVisible = false;
            this.employeesTable.Size = new System.Drawing.Size(348, 150);
            this.employeesTable.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 45.68528F;
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.FillWeight = 127.1574F;
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn.DataSource = this.jobsBindingSource;
            this.jobDataGridViewTextBoxColumn.DisplayMember = "Title";
            this.jobDataGridViewTextBoxColumn.FillWeight = 127.1574F;
            this.jobDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            this.jobDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jobDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.jobDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // jobsBindingSource
            // 
            this.jobsBindingSource.DataMember = "Jobs";
            this.jobsBindingSource.DataSource = this.bDTimeSheetDataSet;
            // 
            // bDTimeSheetDataSet
            // 
            this.bDTimeSheetDataSet.DataSetName = "BDTimeSheetDataSet";
            this.bDTimeSheetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.bDTimeSheetDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // jobsTable
            // 
            this.jobsTable.AutoGenerateColumns = false;
            this.jobsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.baseSalaryDataGridViewTextBoxColumn});
            this.jobsTable.DataSource = this.jobsBindingSource;
            this.jobsTable.Location = new System.Drawing.Point(545, 56);
            this.jobsTable.Name = "jobsTable";
            this.jobsTable.RowHeadersVisible = false;
            this.jobsTable.Size = new System.Drawing.Size(361, 150);
            this.jobsTable.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.FillWeight = 45.68528F;
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 127.1574F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Наименование должности";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // baseSalaryDataGridViewTextBoxColumn
            // 
            this.baseSalaryDataGridViewTextBoxColumn.DataPropertyName = "BaseSalary";
            this.baseSalaryDataGridViewTextBoxColumn.FillWeight = 127.1574F;
            this.baseSalaryDataGridViewTextBoxColumn.HeaderText = "Минимальный оклад";
            this.baseSalaryDataGridViewTextBoxColumn.Name = "baseSalaryDataGridViewTextBoxColumn";
            // 
            // jobsTableAdapter
            // 
            this.jobsTableAdapter.ClearBeforeFill = true;
            // 
            // timesheetTable
            // 
            this.timesheetTable.AllowUserToAddRows = false;
            this.timesheetTable.AllowUserToDeleteRows = false;
            this.timesheetTable.AutoGenerateColumns = false;
            this.timesheetTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timesheetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timesheetTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workDateDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.isPresentDataGridViewCheckBoxColumn});
            this.timesheetTable.DataSource = this.timeTableBindingSource;
            this.timesheetTable.Location = new System.Drawing.Point(21, 279);
            this.timesheetTable.Name = "timesheetTable";
            this.timesheetTable.ReadOnly = true;
            this.timesheetTable.RowHeadersVisible = false;
            this.timesheetTable.Size = new System.Drawing.Size(348, 150);
            this.timesheetTable.TabIndex = 2;
            // 
            // workDateDataGridViewTextBoxColumn
            // 
            this.workDateDataGridViewTextBoxColumn.DataPropertyName = "WorkDate";
            this.workDateDataGridViewTextBoxColumn.FillWeight = 76.14214F;
            this.workDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.workDateDataGridViewTextBoxColumn.Name = "workDateDataGridViewTextBoxColumn";
            this.workDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.DataSource = this.employeesBindingSource;
            this.employeeDataGridViewTextBoxColumn.DisplayMember = "FullName";
            this.employeeDataGridViewTextBoxColumn.FillWeight = 139.1837F;
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // isPresentDataGridViewCheckBoxColumn
            // 
            this.isPresentDataGridViewCheckBoxColumn.DataPropertyName = "IsPresent";
            this.isPresentDataGridViewCheckBoxColumn.FillWeight = 84.67413F;
            this.isPresentDataGridViewCheckBoxColumn.HeaderText = "Присутствует?";
            this.isPresentDataGridViewCheckBoxColumn.Name = "isPresentDataGridViewCheckBoxColumn";
            this.isPresentDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // timeTableBindingSource
            // 
            this.timeTableBindingSource.DataMember = "TimeTable";
            this.timeTableBindingSource.DataSource = this.bDTimeSheetDataSet;
            // 
            // timeTableTableAdapter
            // 
            this.timeTableTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateButton1
            // 
            this.UpdateButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton1.Location = new System.Drawing.Point(375, 56);
            this.UpdateButton1.Name = "UpdateButton1";
            this.UpdateButton1.Size = new System.Drawing.Size(74, 88);
            this.UpdateButton1.TabIndex = 3;
            this.UpdateButton1.Text = "Обновить";
            this.UpdateButton1.UseVisualStyleBackColor = true;
            this.UpdateButton1.Click += new System.EventHandler(this.UpdateButton1_Click);
            // 
            // UpdateButton2
            // 
            this.UpdateButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton2.Location = new System.Drawing.Point(932, 56);
            this.UpdateButton2.Name = "UpdateButton2";
            this.UpdateButton2.Size = new System.Drawing.Size(78, 88);
            this.UpdateButton2.TabIndex = 4;
            this.UpdateButton2.Text = "Обновить";
            this.UpdateButton2.UseVisualStyleBackColor = true;
            this.UpdateButton2.Click += new System.EventHandler(this.UpdateButton2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(545, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // timesheetEdit
            // 
            this.timesheetEdit.AutoGenerateColumns = false;
            this.timesheetEdit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timesheetEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timesheetEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workDateDataGridViewTextBoxColumn1,
            this.employeeDataGridViewTextBoxColumn1,
            this.isPresentDataGridViewCheckBoxColumn1});
            this.timesheetEdit.DataSource = this.timeTableEdit;
            this.timesheetEdit.Location = new System.Drawing.Point(545, 279);
            this.timesheetEdit.Name = "timesheetEdit";
            this.timesheetEdit.RowHeadersVisible = false;
            this.timesheetEdit.Size = new System.Drawing.Size(300, 150);
            this.timesheetEdit.TabIndex = 6;
            this.timesheetEdit.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.timesheetEdit_DataError);
            this.timesheetEdit.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.timesheetEdit_UserAddedRow);
            // 
            // workDateDataGridViewTextBoxColumn1
            // 
            this.workDateDataGridViewTextBoxColumn1.DataPropertyName = "WorkDate";
            this.workDateDataGridViewTextBoxColumn1.HeaderText = "WorkDate";
            this.workDateDataGridViewTextBoxColumn1.Name = "workDateDataGridViewTextBoxColumn1";
            this.workDateDataGridViewTextBoxColumn1.Visible = false;
            // 
            // employeeDataGridViewTextBoxColumn1
            // 
            this.employeeDataGridViewTextBoxColumn1.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn1.DataSource = this.employeesBindingSource;
            this.employeeDataGridViewTextBoxColumn1.DisplayMember = "FullName";
            this.employeeDataGridViewTextBoxColumn1.HeaderText = "Сотрудник";
            this.employeeDataGridViewTextBoxColumn1.Name = "employeeDataGridViewTextBoxColumn1";
            this.employeeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeDataGridViewTextBoxColumn1.ValueMember = "id";
            // 
            // isPresentDataGridViewCheckBoxColumn1
            // 
            this.isPresentDataGridViewCheckBoxColumn1.DataPropertyName = "IsPresent";
            this.isPresentDataGridViewCheckBoxColumn1.HeaderText = "Присутствует?";
            this.isPresentDataGridViewCheckBoxColumn1.Name = "isPresentDataGridViewCheckBoxColumn1";
            this.isPresentDataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // timeTableEdit
            // 
            this.timeTableEdit.DataMember = "TimeTable";
            this.timeTableEdit.DataSource = this.bDTimeSheetDataSet;
            // 
            // UpdateButton3
            // 
            this.UpdateButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton3.Location = new System.Drawing.Point(851, 279);
            this.UpdateButton3.Name = "UpdateButton3";
            this.UpdateButton3.Size = new System.Drawing.Size(87, 88);
            this.UpdateButton3.TabIndex = 7;
            this.UpdateButton3.Text = "Обновить";
            this.UpdateButton3.UseVisualStyleBackColor = true;
            this.UpdateButton3.Click += new System.EventHandler(this.UpdateButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Редактирование табеля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Сводка посещаемости";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Сотрудники";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Должности";
            // 
            // TimesheetFilter
            // 
            this.TimesheetFilter.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.timeTableBindingSource, "Employee", true));
            this.TimesheetFilter.DataSource = this.employeesBindingSource;
            this.TimesheetFilter.DisplayMember = "FullName";
            this.TimesheetFilter.FormattingEnabled = true;
            this.TimesheetFilter.Location = new System.Drawing.Point(173, 250);
            this.TimesheetFilter.Name = "TimesheetFilter";
            this.TimesheetFilter.Size = new System.Drawing.Size(121, 21);
            this.TimesheetFilter.TabIndex = 12;
            this.TimesheetFilter.ValueMember = "id";
            this.TimesheetFilter.SelectionChangeCommitted += new System.EventHandler(this.TimesheetFilter_SelectionChangeCommitted);
            // 
            // JobFilter
            // 
            this.JobFilter.Location = new System.Drawing.Point(629, 15);
            this.JobFilter.Name = "JobFilter";
            this.JobFilter.Size = new System.Drawing.Size(100, 20);
            this.JobFilter.TabIndex = 15;
            this.JobFilter.TextChanged += new System.EventHandler(this.JobFilter_TextChanged);
            // 
            // ClearFilters
            // 
            this.ClearFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearFilters.Location = new System.Drawing.Point(375, 25);
            this.ClearFilters.Name = "ClearFilters";
            this.ClearFilters.Size = new System.Drawing.Size(63, 20);
            this.ClearFilters.TabIndex = 16;
            this.ClearFilters.Text = "Очистить";
            this.ClearFilters.UseVisualStyleBackColor = true;
            this.ClearFilters.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(375, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 20);
            this.button2.TabIndex = 17;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(932, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 22);
            this.button3.TabIndex = 18;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeesFilter
            // 
            this.EmployeesFilter.Location = new System.Drawing.Point(99, 25);
            this.EmployeesFilter.Name = "EmployeesFilter";
            this.EmployeesFilter.Size = new System.Drawing.Size(100, 20);
            this.EmployeesFilter.TabIndex = 19;
            this.EmployeesFilter.TextChanged += new System.EventHandler(this.EmployeesFilter_TextChanged);
            // 
            // EmployeesFilter1
            // 
            this.EmployeesFilter1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "Job", true));
            this.EmployeesFilter1.DataSource = this.jobsBindingSource;
            this.EmployeesFilter1.DisplayMember = "Title";
            this.EmployeesFilter1.FormattingEnabled = true;
            this.EmployeesFilter1.Location = new System.Drawing.Point(239, 24);
            this.EmployeesFilter1.Name = "EmployeesFilter1";
            this.EmployeesFilter1.Size = new System.Drawing.Size(121, 21);
            this.EmployeesFilter1.TabIndex = 14;
            this.EmployeesFilter1.ValueMember = "id";
            this.EmployeesFilter1.SelectionChangeCommitted += new System.EventHandler(this.EmployeesFilter1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(932, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(374, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(851, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // wordSummaryButton
            // 
            this.wordSummaryButton.Location = new System.Drawing.Point(88, 507);
            this.wordSummaryButton.Name = "wordSummaryButton";
            this.wordSummaryButton.Size = new System.Drawing.Size(75, 23);
            this.wordSummaryButton.TabIndex = 23;
            this.wordSummaryButton.Text = "WORD";
            this.wordSummaryButton.UseVisualStyleBackColor = true;
            this.wordSummaryButton.Click += new System.EventHandler(this.wordSummaryButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(40, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Сводка по сотруднику";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(88, 536);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "EXCEL";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(456, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Вакансия";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(459, 536);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 28;
            this.button7.Text = "EXCEL";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(459, 507);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 27;
            this.button8.Text = "WORD";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1001, 331);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(114, 98);
            this.button9.TabIndex = 29;
            this.button9.Text = "Импорт данных";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(88, 565);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 30;
            this.button10.Text = "HTML";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(459, 565);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 31;
            this.button11.Text = "HTML";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "html";
            this.saveFileDialog1.FileName = "webpage";
            this.saveFileDialog1.Filter = "HTML Files|*.html";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1138, 518);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wordSummaryButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmployeesFilter);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClearFilters);
            this.Controls.Add(this.JobFilter);
            this.Controls.Add(this.EmployeesFilter1);
            this.Controls.Add(this.TimesheetFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton3);
            this.Controls.Add(this.timesheetEdit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.UpdateButton2);
            this.Controls.Add(this.UpdateButton1);
            this.Controls.Add(this.timesheetTable);
            this.Controls.Add(this.jobsTable);
            this.Controls.Add(this.employeesTable);
            this.Name = "MainForm";
            this.Text = "Табель рабочего времени";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTimeSheetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timesheetTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timesheetEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter EmployeesAdapter;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter JobsAdapter;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter TimeTableAdapter;
        private System.Windows.Forms.DataGridView employeesTable;
        private BDTimeSheetDataSet bDTimeSheetDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private BDTimeSheetDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridView jobsTable;
        private System.Windows.Forms.BindingSource jobsBindingSource;
        private BDTimeSheetDataSetTableAdapters.JobsTableAdapter jobsTableAdapter;
        private System.Windows.Forms.DataGridView timesheetTable;
        private System.Windows.Forms.BindingSource timeTableBindingSource;
        private BDTimeSheetDataSetTableAdapters.TimeTableTableAdapter timeTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPresentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button UpdateButton1;
        private System.Windows.Forms.Button UpdateButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView timesheetEdit;
        private System.Windows.Forms.BindingSource timeTableEdit;
        private System.Windows.Forms.Button UpdateButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPresentDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TimesheetFilter;
        private System.Windows.Forms.TextBox JobFilter;
        private System.Windows.Forms.Button ClearFilters;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox EmployeesFilter;
        private System.Windows.Forms.ComboBox EmployeesFilter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button wordSummaryButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

