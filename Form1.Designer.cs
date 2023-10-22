namespace BusinessProxyApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.DishesAdapter = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.IngredientsAdapter = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.RecipesAdapter = new System.Data.OleDb.OleDbDataAdapter();
            this.dishGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.блюдаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDCafeDataSet = new BusinessProxyApp.BDCafeDataSet();
            this.блюдаTableAdapter = new BusinessProxyApp.BDCafeDataSetTableAdapters.БлюдаTableAdapter();
            this.ingredientGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ингредиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ингредиентыTableAdapter = new BusinessProxyApp.BDCafeDataSetTableAdapters.ИнгредиентыTableAdapter();
            this.recipeGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ingredientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.рецептыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рецептыTableAdapter = new BusinessProxyApp.BDCafeDataSetTableAdapters.РецептыTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton3 = new System.Windows.Forms.Button();
            this.SaveButton2 = new System.Windows.Forms.Button();
            this.SaveButton1 = new System.Windows.Forms.Button();
            this.deleteButton3 = new System.Windows.Forms.Button();
            this.deleteButton2 = new System.Windows.Forms.Button();
            this.deleteButton1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.docButton2 = new System.Windows.Forms.Button();
            this.docButton1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ImportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dishGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\Desktop\\Development" +
    "\\BusinessApps\\BusinessProxyApp\\BDCafe.accdb;Persist Security Info=True";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Блюда.*\r\nFROM            Блюда";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Блюда` (`DishName`, `Price`, `Weight`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("DishName", System.Data.OleDb.OleDbType.VarWChar, 0, "DishName"),
            new System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price"),
            new System.Data.OleDb.OleDbParameter("Weight", System.Data.OleDb.OleDbType.Integer, 0, "Weight")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("DishName", System.Data.OleDb.OleDbType.VarWChar, 0, "DishName"),
            new System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price"),
            new System.Data.OleDb.OleDbParameter("Weight", System.Data.OleDb.OleDbType.Integer, 0, "Weight"),
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DishName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DishName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DishName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DishName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Weight", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Weight", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Weight", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Weight", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `Блюда` WHERE ((`id` = ?) AND ((? = 1 AND `DishName` IS NULL) OR (`Di" +
    "shName` = ?)) AND ((? = 1 AND `Price` IS NULL) OR (`Price` = ?)) AND ((? = 1 AND" +
    " `Weight` IS NULL) OR (`Weight` = ?)))";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DishName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DishName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DishName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DishName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Weight", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Weight", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Weight", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Weight", System.Data.DataRowVersion.Original, null)});
            // 
            // DishesAdapter
            // 
            this.DishesAdapter.DeleteCommand = this.oleDbDeleteCommand1;
            this.DishesAdapter.InsertCommand = this.oleDbInsertCommand1;
            this.DishesAdapter.SelectCommand = this.oleDbSelectCommand1;
            this.DishesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Блюда", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("DishName", "DishName"),
                        new System.Data.Common.DataColumnMapping("Price", "Price"),
                        new System.Data.Common.DataColumnMapping("Weight", "Weight")})});
            this.DishesAdapter.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        Ингредиенты.*\r\nFROM            Ингредиенты";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `Ингредиенты` (`ProductName`, `Price`) VALUES (?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarWChar, 0, "ProductName"),
            new System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = "UPDATE `Ингредиенты` SET `ProductName` = ?, `Price` = ? WHERE ((`id` = ?) AND ((?" +
    " = 1 AND `ProductName` IS NULL) OR (`ProductName` = ?)) AND ((? = 1 AND `Price` " +
    "IS NULL) OR (`Price` = ?)))";
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarWChar, 0, "ProductName"),
            new System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price"),
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ProductName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ProductName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = "DELETE FROM `Ингредиенты` WHERE ((`id` = ?) AND ((? = 1 AND `ProductName` IS NULL" +
    ") OR (`ProductName` = ?)) AND ((? = 1 AND `Price` IS NULL) OR (`Price` = ?)))";
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ProductName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ProductName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, null)});
            // 
            // IngredientsAdapter
            // 
            this.IngredientsAdapter.DeleteCommand = this.oleDbDeleteCommand2;
            this.IngredientsAdapter.InsertCommand = this.oleDbInsertCommand2;
            this.IngredientsAdapter.SelectCommand = this.oleDbSelectCommand2;
            this.IngredientsAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Ингредиенты", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
                        new System.Data.Common.DataColumnMapping("Price", "Price")})});
            this.IngredientsAdapter.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT        Рецепты.*\r\nFROM            Рецепты";
            this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `Рецепты` (`dish`, `ingredient`) VALUES (?, ?)";
            this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("dish", System.Data.OleDb.OleDbType.Integer, 0, "dish"),
            new System.Data.OleDb.OleDbParameter("ingredient", System.Data.OleDb.OleDbType.Integer, 0, "ingredient")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = "UPDATE `Рецепты` SET `dish` = ?, `ingredient` = ? WHERE ((`id` = ?) AND ((? = 1 A" +
    "ND `dish` IS NULL) OR (`dish` = ?)) AND ((? = 1 AND `ingredient` IS NULL) OR (`i" +
    "ngredient` = ?)))";
            this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("dish", System.Data.OleDb.OleDbType.Integer, 0, "dish"),
            new System.Data.OleDb.OleDbParameter("ingredient", System.Data.OleDb.OleDbType.Integer, 0, "ingredient"),
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_dish", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "dish", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_dish", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dish", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ingredient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ingredient", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ingredient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ingredient", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = "DELETE FROM `Рецепты` WHERE ((`id` = ?) AND ((? = 1 AND `dish` IS NULL) OR (`dish" +
    "` = ?)) AND ((? = 1 AND `ingredient` IS NULL) OR (`ingredient` = ?)))";
            this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_dish", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "dish", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_dish", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dish", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ingredient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ingredient", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ingredient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ingredient", System.Data.DataRowVersion.Original, null)});
            // 
            // RecipesAdapter
            // 
            this.RecipesAdapter.DeleteCommand = this.oleDbDeleteCommand3;
            this.RecipesAdapter.InsertCommand = this.oleDbInsertCommand3;
            this.RecipesAdapter.SelectCommand = this.oleDbSelectCommand3;
            this.RecipesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Рецепты", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("dish", "dish"),
                        new System.Data.Common.DataColumnMapping("ingredient", "ingredient")})});
            this.RecipesAdapter.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // dishGridView
            // 
            this.dishGridView.AutoGenerateColumns = false;
            this.dishGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dishGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dishNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.dishGridView.DataSource = this.блюдаBindingSource;
            this.dishGridView.Location = new System.Drawing.Point(0, 275);
            this.dishGridView.Name = "dishGridView";
            this.dishGridView.RowHeadersVisible = false;
            this.dishGridView.Size = new System.Drawing.Size(439, 150);
            this.dishGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dishNameDataGridViewTextBoxColumn
            // 
            this.dishNameDataGridViewTextBoxColumn.DataPropertyName = "DishName";
            this.dishNameDataGridViewTextBoxColumn.HeaderText = "Название блюда";
            this.dishNameDataGridViewTextBoxColumn.Name = "dishNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // блюдаBindingSource
            // 
            this.блюдаBindingSource.DataMember = "Блюда";
            this.блюдаBindingSource.DataSource = this.bDCafeDataSet;
            // 
            // bDCafeDataSet
            // 
            this.bDCafeDataSet.DataSetName = "BDCafeDataSet";
            this.bDCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // блюдаTableAdapter
            // 
            this.блюдаTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientGridView
            // 
            this.ingredientGridView.AutoGenerateColumns = false;
            this.ingredientGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ingredientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1});
            this.ingredientGridView.DataSource = this.ингредиентыBindingSource;
            this.ingredientGridView.Location = new System.Drawing.Point(0, 68);
            this.ingredientGridView.Name = "ingredientGridView";
            this.ingredientGridView.RowHeadersVisible = false;
            this.ingredientGridView.Size = new System.Drawing.Size(331, 153);
            this.ingredientGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Название ингредиента";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // ингредиентыBindingSource
            // 
            this.ингредиентыBindingSource.DataMember = "Ингредиенты";
            this.ингредиентыBindingSource.DataSource = this.bDCafeDataSet;
            // 
            // ингредиентыTableAdapter
            // 
            this.ингредиентыTableAdapter.ClearBeforeFill = true;
            // 
            // recipeGridView
            // 
            this.recipeGridView.AutoGenerateColumns = false;
            this.recipeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recipeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.dishDataGridViewTextBoxColumn,
            this.ingredientDataGridViewTextBoxColumn});
            this.recipeGridView.DataSource = this.рецептыBindingSource;
            this.recipeGridView.Location = new System.Drawing.Point(504, 68);
            this.recipeGridView.Name = "recipeGridView";
            this.recipeGridView.RowHeadersVisible = false;
            this.recipeGridView.Size = new System.Drawing.Size(378, 153);
            this.recipeGridView.TabIndex = 2;
            this.recipeGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.recipeGridView_DataError);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // dishDataGridViewTextBoxColumn
            // 
            this.dishDataGridViewTextBoxColumn.DataPropertyName = "dish";
            this.dishDataGridViewTextBoxColumn.DataSource = this.блюдаBindingSource;
            this.dishDataGridViewTextBoxColumn.DisplayMember = "DishName";
            this.dishDataGridViewTextBoxColumn.HeaderText = "Блюдо";
            this.dishDataGridViewTextBoxColumn.Name = "dishDataGridViewTextBoxColumn";
            this.dishDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dishDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dishDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // ingredientDataGridViewTextBoxColumn
            // 
            this.ingredientDataGridViewTextBoxColumn.DataPropertyName = "ingredient";
            this.ingredientDataGridViewTextBoxColumn.DataSource = this.ингредиентыBindingSource;
            this.ingredientDataGridViewTextBoxColumn.DisplayMember = "ProductName";
            this.ingredientDataGridViewTextBoxColumn.HeaderText = "Ингредиент";
            this.ingredientDataGridViewTextBoxColumn.Name = "ingredientDataGridViewTextBoxColumn";
            this.ingredientDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ingredientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ingredientDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // рецептыBindingSource
            // 
            this.рецептыBindingSource.DataMember = "Рецепты";
            this.рецептыBindingSource.DataSource = this.bDCafeDataSet;
            // 
            // рецептыTableAdapter
            // 
            this.рецептыTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.SaveButton3);
            this.panel1.Controls.Add(this.SaveButton2);
            this.panel1.Controls.Add(this.SaveButton1);
            this.panel1.Controls.Add(this.deleteButton3);
            this.panel1.Controls.Add(this.deleteButton2);
            this.panel1.Controls.Add(this.deleteButton1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dishGridView);
            this.panel1.Controls.Add(this.ingredientGridView);
            this.panel1.Controls.Add(this.recipeGridView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 445);
            this.panel1.TabIndex = 3;
            // 
            // SaveButton3
            // 
            this.SaveButton3.Location = new System.Drawing.Point(888, 198);
            this.SaveButton3.Name = "SaveButton3";
            this.SaveButton3.Size = new System.Drawing.Size(75, 23);
            this.SaveButton3.TabIndex = 12;
            this.SaveButton3.Text = "Сохранить";
            this.SaveButton3.UseVisualStyleBackColor = true;
            this.SaveButton3.Click += new System.EventHandler(this.SaveButton3_Click);
            // 
            // SaveButton2
            // 
            this.SaveButton2.Location = new System.Drawing.Point(445, 402);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(75, 23);
            this.SaveButton2.TabIndex = 11;
            this.SaveButton2.Text = "Сохранить";
            this.SaveButton2.UseVisualStyleBackColor = true;
            this.SaveButton2.Click += new System.EventHandler(this.SaveButton2_Click);
            // 
            // SaveButton1
            // 
            this.SaveButton1.Location = new System.Drawing.Point(337, 198);
            this.SaveButton1.Name = "SaveButton1";
            this.SaveButton1.Size = new System.Drawing.Size(75, 23);
            this.SaveButton1.TabIndex = 10;
            this.SaveButton1.Text = "Сохранить";
            this.SaveButton1.UseVisualStyleBackColor = true;
            this.SaveButton1.Click += new System.EventHandler(this.SaveButton1_Click);
            // 
            // deleteButton3
            // 
            this.deleteButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton3.Location = new System.Drawing.Point(888, 68);
            this.deleteButton3.Name = "deleteButton3";
            this.deleteButton3.Size = new System.Drawing.Size(28, 44);
            this.deleteButton3.TabIndex = 9;
            this.deleteButton3.Text = "-";
            this.deleteButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteButton3.UseMnemonic = false;
            this.deleteButton3.UseVisualStyleBackColor = true;
            this.deleteButton3.Click += new System.EventHandler(this.deleteButton3_Click);
            // 
            // deleteButton2
            // 
            this.deleteButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton2.Location = new System.Drawing.Point(445, 275);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(28, 44);
            this.deleteButton2.TabIndex = 8;
            this.deleteButton2.Text = "-";
            this.deleteButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteButton2.UseMnemonic = false;
            this.deleteButton2.UseVisualStyleBackColor = true;
            this.deleteButton2.Click += new System.EventHandler(this.deleteButton2_Click);
            // 
            // deleteButton1
            // 
            this.deleteButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton1.Location = new System.Drawing.Point(337, 68);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(28, 44);
            this.deleteButton1.TabIndex = 7;
            this.deleteButton1.Text = "-";
            this.deleteButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteButton1.UseMnemonic = false;
            this.deleteButton1.UseVisualStyleBackColor = true;
            this.deleteButton1.Click += new System.EventHandler(this.deleteButton1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.рецептыBindingSource, "ingredient", true));
            this.comboBox2.DataSource = this.ингредиентыBindingSource;
            this.comboBox2.DisplayMember = "ProductName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(679, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "id";
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.рецептыBindingSource, "id", true));
            this.comboBox1.DataSource = this.блюдаBindingSource;
            this.comboBox1.DisplayMember = "DishName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(504, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.docButton2);
            this.groupBox1.Controls.Add(this.docButton1);
            this.groupBox1.Location = new System.Drawing.Point(574, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Документы";
            // 
            // docButton2
            // 
            this.docButton2.Location = new System.Drawing.Point(7, 68);
            this.docButton2.Name = "docButton2";
            this.docButton2.Size = new System.Drawing.Size(143, 23);
            this.docButton2.TabIndex = 1;
            this.docButton2.Text = "Состав блюда";
            this.docButton2.UseVisualStyleBackColor = true;
            this.docButton2.Click += new System.EventHandler(this.docButton2_Click);
            // 
            // docButton1
            // 
            this.docButton1.Location = new System.Drawing.Point(7, 34);
            this.docButton1.Name = "docButton1";
            this.docButton1.Size = new System.Drawing.Size(143, 23);
            this.docButton1.TabIndex = 0;
            this.docButton1.Text = "Карточка ингредиента";
            this.docButton1.UseVisualStyleBackColor = true;
            this.docButton1.Click += new System.EventHandler(this.docButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(574, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 112);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Экспорт";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Рецепты";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Ингредиенты";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox3.Controls.Add(this.ImportExcel);
            this.groupBox3.Location = new System.Drawing.Point(772, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 76);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Импорт";
            // 
            // ImportExcel
            // 
            this.ImportExcel.Location = new System.Drawing.Point(7, 34);
            this.ImportExcel.Name = "ImportExcel";
            this.ImportExcel.Size = new System.Drawing.Size(143, 23);
            this.ImportExcel.TabIndex = 0;
            this.ImportExcel.Text = "Загрузить данные";
            this.ImportExcel.UseVisualStyleBackColor = true;
            this.ImportExcel.Click += new System.EventHandler(this.ImportExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 469);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Кафе \"Сюзанна\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dishGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter DishesAdapter;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter IngredientsAdapter;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter RecipesAdapter;
        private System.Windows.Forms.DataGridView dishGridView;
        private BDCafeDataSet bDCafeDataSet;
        private System.Windows.Forms.BindingSource блюдаBindingSource;
        private BDCafeDataSetTableAdapters.БлюдаTableAdapter блюдаTableAdapter;
        private System.Windows.Forms.DataGridView ingredientGridView;
        private System.Windows.Forms.BindingSource ингредиентыBindingSource;
        private BDCafeDataSetTableAdapters.ИнгредиентыTableAdapter ингредиентыTableAdapter;
        private System.Windows.Forms.DataGridView recipeGridView;
        private System.Windows.Forms.BindingSource рецептыBindingSource;
        private BDCafeDataSetTableAdapters.РецептыTableAdapter рецептыTableAdapter;
        private System.Windows.Forms.BindingSource блюдаРецептыBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ingredientDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button deleteButton1;
        private System.Windows.Forms.Button deleteButton2;
        private System.Windows.Forms.Button deleteButton3;
        private System.Windows.Forms.Button SaveButton3;
        private System.Windows.Forms.Button SaveButton2;
        private System.Windows.Forms.Button SaveButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button docButton2;
        private System.Windows.Forms.Button docButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ImportExcel;
    }
}

