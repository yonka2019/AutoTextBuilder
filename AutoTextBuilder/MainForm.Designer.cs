namespace AutoTextBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TextBox_Input = new System.Windows.Forms.TextBox();
            this.LanguageUsedOutput = new System.Windows.Forms.ComboBox();
            this.TextBox_Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LanguageUsedInput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TextBox_Input
            // 
            this.TextBox_Input.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Input.Location = new System.Drawing.Point(263, 43);
            this.TextBox_Input.Multiline = true;
            this.TextBox_Input.Name = "TextBox_Input";
            this.TextBox_Input.Size = new System.Drawing.Size(388, 81);
            this.TextBox_Input.TabIndex = 0;
            this.TextBox_Input.TextChanged += new System.EventHandler(this.TextBox_Input_TextChanged);
            // 
            // LanguageUsedOutput
            // 
            this.LanguageUsedOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageUsedOutput.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageUsedOutput.FormattingEnabled = true;
            this.LanguageUsedOutput.Items.AddRange(new object[] {
            "English",
            "Russian",
            "Hebrew"});
            this.LanguageUsedOutput.Location = new System.Drawing.Point(263, 130);
            this.LanguageUsedOutput.Name = "LanguageUsedOutput";
            this.LanguageUsedOutput.Size = new System.Drawing.Size(388, 27);
            this.LanguageUsedOutput.TabIndex = 1;
            this.LanguageUsedOutput.SelectedIndexChanged += new System.EventHandler(this.LanguageUsedOutput_SelectedIndexChanged);
            // 
            // TextBox_Output
            // 
            this.TextBox_Output.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Output.Location = new System.Drawing.Point(263, 160);
            this.TextBox_Output.Multiline = true;
            this.TextBox_Output.Name = "TextBox_Output";
            this.TextBox_Output.ReadOnly = true;
            this.TextBox_Output.Size = new System.Drawing.Size(388, 81);
            this.TextBox_Output.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Non-readable text Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(95, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Language Output:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(181, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(110, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Language Input:";
            // 
            // LanguageUsedInput
            // 
            this.LanguageUsedInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageUsedInput.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageUsedInput.FormattingEnabled = true;
            this.LanguageUsedInput.Items.AddRange(new object[] {
            "English",
            "Russian",
            "Hebrew"});
            this.LanguageUsedInput.Location = new System.Drawing.Point(263, 13);
            this.LanguageUsedInput.Name = "LanguageUsedInput";
            this.LanguageUsedInput.Size = new System.Drawing.Size(388, 27);
            this.LanguageUsedInput.TabIndex = 7;
            this.LanguageUsedInput.SelectedIndexChanged += new System.EventHandler(this.LanguageUsedInput_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 252);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LanguageUsedInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Output);
            this.Controls.Add(this.LanguageUsedOutput);
            this.Controls.Add(this.TextBox_Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Input;
        private System.Windows.Forms.ComboBox LanguageUsedOutput;
        private System.Windows.Forms.TextBox TextBox_Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox LanguageUsedInput;
    }
}

