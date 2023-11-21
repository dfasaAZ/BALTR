namespace Grafik
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
            this.pictureBox1.Location = new System.Drawing.Point(387, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 467);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pointsEdit
            // 
            this.pointsEdit.Location = new System.Drawing.Point(261, 309);
            this.pointsEdit.Name = "pointsEdit";
            this.pointsEdit.Size = new System.Drawing.Size(120, 20);
            this.pointsEdit.TabIndex = 1;
            this.pointsEdit.Value = new decimal(new int[] {
            10,
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
            this.tensionEdit.Location = new System.Drawing.Point(261, 351);
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
            this.xmin.Location = new System.Drawing.Point(12, 147);
            this.xmin.Name = "xmin";
            this.xmin.Size = new System.Drawing.Size(120, 20);
            this.xmin.TabIndex = 3;
            this.xmin.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
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
            this.xmax.Location = new System.Drawing.Point(12, 184);
            this.xmax.Name = "xmax";
            this.xmax.Size = new System.Drawing.Size(120, 20);
            this.xmax.TabIndex = 4;
            this.xmax.Value = new decimal(new int[] {
            22,
            0,
            0,
            65536});
            this.xmax.ValueChanged += new System.EventHandler(this.pictureBox1_Paint);
            // 
            // ymax
            // 
            this.ymax.DecimalPlaces = 1;
            this.ymax.Location = new System.Drawing.Point(214, 184);
            this.ymax.Name = "ymax";
            this.ymax.Size = new System.Drawing.Size(120, 20);
            this.ymax.TabIndex = 6;
            this.ymax.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.ymax.ValueChanged += new System.EventHandler(this.pictureBox1_Paint);
            // 
            // ymin
            // 
            this.ymin.DecimalPlaces = 1;
            this.ymin.Location = new System.Drawing.Point(214, 147);
            this.ymin.Name = "ymin";
            this.ymin.Size = new System.Drawing.Size(120, 20);
            this.ymin.TabIndex = 5;
            this.ymin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ymin.ValueChanged += new System.EventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 611);
            this.Controls.Add(this.ymax);
            this.Controls.Add(this.ymin);
            this.Controls.Add(this.xmax);
            this.Controls.Add(this.xmin);
            this.Controls.Add(this.tensionEdit);
            this.Controls.Add(this.pointsEdit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Графицк";
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
    }
}

