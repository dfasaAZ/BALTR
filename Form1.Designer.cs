namespace Lab6
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pointsEdit = new System.Windows.Forms.NumericUpDown();
            this.tensionEdit = new System.Windows.Forms.NumericUpDown();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.xmin = new System.Windows.Forms.NumericUpDown();
            this.xmax = new System.Windows.Forms.NumericUpDown();
            this.ymax = new System.Windows.Forms.NumericUpDown();
            this.ymin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tensionEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ymax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ymin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(224, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 285);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pointsEdit
            // 
            this.pointsEdit.Location = new System.Drawing.Point(12, 46);
            this.pointsEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.pointsEdit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.pointsEdit.Name = "pointsEdit";
            this.pointsEdit.Size = new System.Drawing.Size(120, 20);
            this.pointsEdit.TabIndex = 1;
            this.pointsEdit.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.pointsEdit.ValueChanged += new System.EventHandler(this.pictureBox1_Paint);
            // 
            // tensionEdit
            // 
            this.tensionEdit.DecimalPlaces = 1;
            this.tensionEdit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tensionEdit.Location = new System.Drawing.Point(12, 88);
            this.tensionEdit.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tensionEdit.Name = "tensionEdit";
            this.tensionEdit.Size = new System.Drawing.Size(120, 20);
            this.tensionEdit.TabIndex = 2;
            this.tensionEdit.ValueChanged += new System.EventHandler(this.pictureBox1_Paint);
            // 
            // xmin
            // 
            this.xmin.DecimalPlaces = 1;
            this.xmin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.xmin.Location = new System.Drawing.Point(44, 195);
            this.xmin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.xmin.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            -2147418112});
            this.xmin.Name = "xmin";
            this.xmin.Size = new System.Drawing.Size(61, 20);
            this.xmin.TabIndex = 3;
            this.xmin.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.xmin.ValueChanged += new System.EventHandler(this.pictureBox1_Paint);
            // 
            // xmax
            // 
            this.xmax.DecimalPlaces = 1;
            this.xmax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.xmax.Location = new System.Drawing.Point(125, 195);
            this.xmax.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            65536});
            this.xmax.Name = "xmax";
            this.xmax.Size = new System.Drawing.Size(61, 20);
            this.xmax.TabIndex = 4;
            this.xmax.Value = new decimal(new int[] {
            16,
            0,
            0,
            65536});
            this.xmax.ValueChanged += new System.EventHandler(this.pictureBox1_Paint);
            // 
            // ymax
            // 
            this.ymax.DecimalPlaces = 1;
            this.ymax.Location = new System.Drawing.Point(125, 251);
            this.ymax.Name = "ymax";
            this.ymax.Size = new System.Drawing.Size(61, 20);
            this.ymax.TabIndex = 6;
            this.ymax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ymax.ValueChanged += new System.EventHandler(this.pictureBox1_Paint);
            // 
            // ymin
            // 
            this.ymin.DecimalPlaces = 1;
            this.ymin.Location = new System.Drawing.Point(44, 249);
            this.ymin.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.ymin.Name = "ymin";
            this.ymin.Size = new System.Drawing.Size(61, 20);
            this.ymin.TabIndex = 5;
            this.ymin.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.ymin.ValueChanged += new System.EventHandler(this.pictureBox1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "От";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "До";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "До";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "От";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Упругость";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Колво точек";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Шрифт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "Построить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 335);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ymax);
            this.Controls.Add(this.ymin);
            this.Controls.Add(this.xmax);
            this.Controls.Add(this.xmin);
            this.Controls.Add(this.tensionEdit);
            this.Controls.Add(this.pointsEdit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Построение графика";
            this.Activated += new System.EventHandler(this.pictureBox1_Paint);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.pictureBox1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tensionEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ymax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ymin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown pointsEdit;
        private System.Windows.Forms.NumericUpDown tensionEdit;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.NumericUpDown xmin;
        private System.Windows.Forms.NumericUpDown xmax;
        private System.Windows.Forms.NumericUpDown ymax;
        private System.Windows.Forms.NumericUpDown ymin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

