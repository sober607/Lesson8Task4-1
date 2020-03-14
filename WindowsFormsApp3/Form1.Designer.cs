namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2chooseTextColor = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonFontParams = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.saveButton1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(83, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Some text of XML saving format";
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.Location = new System.Drawing.Point(25, 25);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(131, 23);
            this.buttonChooseColor.TabIndex = 0;
            this.buttonChooseColor.Text = "Background color";
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(109, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(211, 100);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonChooseColor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(203, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фон";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2chooseTextColor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(203, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Текст";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2chooseTextColor
            // 
            this.button2chooseTextColor.Location = new System.Drawing.Point(28, 25);
            this.button2chooseTextColor.Name = "button2chooseTextColor";
            this.button2chooseTextColor.Size = new System.Drawing.Size(142, 23);
            this.button2chooseTextColor.TabIndex = 0;
            this.button2chooseTextColor.Text = "Text color";
            this.button2chooseTextColor.UseVisualStyleBackColor = true;
            this.button2chooseTextColor.Click += new System.EventHandler(this.button2chooseTextColor_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonFontParams);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(203, 74);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Шрифт";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonFontParams
            // 
            this.buttonFontParams.Location = new System.Drawing.Point(55, 26);
            this.buttonFontParams.Name = "buttonFontParams";
            this.buttonFontParams.Size = new System.Drawing.Size(75, 23);
            this.buttonFontParams.TabIndex = 0;
            this.buttonFontParams.Text = "Font params";
            this.buttonFontParams.UseVisualStyleBackColor = true;
            this.buttonFontParams.Click += new System.EventHandler(this.buttonFontParams_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.saveButton1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(203, 74);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Сохранение";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // saveButton1
            // 
            this.saveButton1.Location = new System.Drawing.Point(35, 25);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(75, 23);
            this.saveButton1.TabIndex = 0;
            this.saveButton1.Text = "Save settings";
            this.saveButton1.UseVisualStyleBackColor = true;
            this.saveButton1.Click += new System.EventHandler(this.saveButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.OnClickChooseColor);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseColor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2chooseTextColor;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonFontParams;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button saveButton1;
    }
}

