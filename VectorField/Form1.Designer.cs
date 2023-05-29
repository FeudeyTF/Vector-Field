namespace VectorField
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarVector = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVector = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarScale
            // 
            this.trackBarScale.Location = new System.Drawing.Point(835, 52);
            this.trackBarScale.Maximum = 100;
            this.trackBarScale.Minimum = 1;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(139, 45);
            this.trackBarScale.SmallChange = 5;
            this.trackBarScale.TabIndex = 0;
            this.trackBarScale.TickFrequency = 10;
            this.trackBarScale.Value = 10;
            this.trackBarScale.Scroll += new System.EventHandler(this.trackBarScale_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Масштаб пространства";
            // 
            // textBoxScale
            // 
            this.textBoxScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxScale.Location = new System.Drawing.Point(972, 52);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.ReadOnly = true;
            this.textBoxScale.Size = new System.Drawing.Size(65, 20);
            this.textBoxScale.TabIndex = 2;
            this.textBoxScale.Text = "10";
            this.textBoxScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(14, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 800);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // trackBarVector
            // 
            this.trackBarVector.LargeChange = 10;
            this.trackBarVector.Location = new System.Drawing.Point(835, 134);
            this.trackBarVector.Maximum = 100;
            this.trackBarVector.Minimum = 1;
            this.trackBarVector.Name = "trackBarVector";
            this.trackBarVector.Size = new System.Drawing.Size(139, 45);
            this.trackBarVector.SmallChange = 5;
            this.trackBarVector.TabIndex = 0;
            this.trackBarVector.TickFrequency = 10;
            this.trackBarVector.Value = 10;
            this.trackBarVector.Scroll += new System.EventHandler(this.trackBarVector_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(832, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Масштаб векторов";
            // 
            // textBoxVector
            // 
            this.textBoxVector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxVector.Location = new System.Drawing.Point(972, 134);
            this.textBoxVector.Name = "textBoxVector";
            this.textBoxVector.ReadOnly = true;
            this.textBoxVector.Size = new System.Drawing.Size(65, 20);
            this.textBoxVector.TabIndex = 2;
            this.textBoxVector.Text = "1.0";
            this.textBoxVector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(835, 212);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(832, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Частота точек";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(835, 260);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(835, 284);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(846, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 837);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxVector);
            this.Controls.Add(this.textBoxScale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarVector);
            this.Controls.Add(this.trackBarScale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarScale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarVector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVector;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
    }
}

