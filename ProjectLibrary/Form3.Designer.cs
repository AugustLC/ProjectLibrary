namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.Reader = new System.Windows.Forms.TextBox();
            this.PageUp = new System.Windows.Forms.Button();
            this.PageDown = new System.Windows.Forms.Button();
            this.Page = new System.Windows.Forms.Label();
            this.AddMark = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteMark = new System.Windows.Forms.Button();
            this.markNext = new System.Windows.Forms.Button();
            this.markPast = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.ColorText = new System.Windows.Forms.Button();
            this.BackColor = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reader
            // 
            this.Reader.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reader.Location = new System.Drawing.Point(22, 40);
            this.Reader.Multiline = true;
            this.Reader.Name = "Reader";
            this.Reader.ReadOnly = true;
            this.Reader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Reader.Size = new System.Drawing.Size(428, 244);
            this.Reader.TabIndex = 0;
            // 
            // PageUp
            // 
            this.PageUp.Location = new System.Drawing.Point(22, 295);
            this.PageUp.Name = "PageUp";
            this.PageUp.Size = new System.Drawing.Size(142, 28);
            this.PageUp.TabIndex = 1;
            this.PageUp.Text = "<<";
            this.PageUp.UseVisualStyleBackColor = true;
            this.PageUp.Click += new System.EventHandler(this.PageUp_Click);
            // 
            // PageDown
            // 
            this.PageDown.Location = new System.Drawing.Point(308, 295);
            this.PageDown.Name = "PageDown";
            this.PageDown.Size = new System.Drawing.Size(142, 28);
            this.PageDown.TabIndex = 2;
            this.PageDown.Text = ">>";
            this.PageDown.UseVisualStyleBackColor = true;
            this.PageDown.Click += new System.EventHandler(this.PageDown_Click);
            // 
            // Page
            // 
            this.Page.AutoSize = true;
            this.Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Page.Location = new System.Drawing.Point(209, 301);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(22, 17);
            this.Page.TabIndex = 3;
            this.Page.Text = "*/*";
            // 
            // AddMark
            // 
            this.AddMark.Location = new System.Drawing.Point(4, 19);
            this.AddMark.Name = "AddMark";
            this.AddMark.Size = new System.Drawing.Size(88, 23);
            this.AddMark.TabIndex = 4;
            this.AddMark.Text = "+bookmark";
            this.AddMark.UseVisualStyleBackColor = true;
            this.AddMark.Click += new System.EventHandler(this.AddMark_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteMark);
            this.groupBox1.Controls.Add(this.markNext);
            this.groupBox1.Controls.Add(this.markPast);
            this.groupBox1.Controls.Add(this.AddMark);
            this.groupBox1.Location = new System.Drawing.Point(455, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 99);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bookmarks";
            // 
            // DeleteMark
            // 
            this.DeleteMark.Location = new System.Drawing.Point(4, 76);
            this.DeleteMark.Name = "DeleteMark";
            this.DeleteMark.Size = new System.Drawing.Size(88, 23);
            this.DeleteMark.TabIndex = 7;
            this.DeleteMark.Text = "-bookmark";
            this.DeleteMark.UseVisualStyleBackColor = true;
            this.DeleteMark.Click += new System.EventHandler(this.DeleteMark_Click);
            // 
            // markNext
            // 
            this.markNext.Location = new System.Drawing.Point(47, 48);
            this.markNext.Name = "markNext";
            this.markNext.Size = new System.Drawing.Size(45, 23);
            this.markNext.TabIndex = 6;
            this.markNext.Text = ">";
            this.markNext.UseVisualStyleBackColor = true;
            this.markNext.Click += new System.EventHandler(this.markNext_Click);
            // 
            // markPast
            // 
            this.markPast.Location = new System.Drawing.Point(6, 48);
            this.markPast.Name = "markPast";
            this.markPast.Size = new System.Drawing.Size(41, 23);
            this.markPast.TabIndex = 5;
            this.markPast.Text = "<";
            this.markPast.UseVisualStyleBackColor = true;
            this.markPast.Click += new System.EventHandler(this.markPast_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(19, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(49, 17);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "Name";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(472, 298);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Закрыть";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ColorText
            // 
            this.ColorText.Location = new System.Drawing.Point(461, 39);
            this.ColorText.Name = "ColorText";
            this.ColorText.Size = new System.Drawing.Size(86, 20);
            this.ColorText.TabIndex = 8;
            this.ColorText.Text = "Цвет текста";
            this.ColorText.UseVisualStyleBackColor = true;
            this.ColorText.Click += new System.EventHandler(this.ColorText_Click);
            // 
            // BackColor
            // 
            this.BackColor.Location = new System.Drawing.Point(461, 65);
            this.BackColor.Name = "BackColor";
            this.BackColor.Size = new System.Drawing.Size(86, 20);
            this.BackColor.TabIndex = 9;
            this.BackColor.Text = "Цвет фона";
            this.BackColor.UseVisualStyleBackColor = true;
            this.BackColor.Click += new System.EventHandler(this.BackColor_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(461, 91);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(86, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 335);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.BackColor);
            this.Controls.Add(this.ColorText);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.PageDown);
            this.Controls.Add(this.PageUp);
            this.Controls.Add(this.Reader);
            this.Name = "Form3";
            this.Text = "Чтение";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Reader;
        private System.Windows.Forms.Button PageUp;
        private System.Windows.Forms.Button PageDown;
        private System.Windows.Forms.Label Page;
        private System.Windows.Forms.Button AddMark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button markNext;
        private System.Windows.Forms.Button markPast;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button DeleteMark;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ColorText;
        private System.Windows.Forms.Button BackColor;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}