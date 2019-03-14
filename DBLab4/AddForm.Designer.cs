namespace DBLab4
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addRecordButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNameBox = new System.Windows.Forms.TextBox();
            this.comboGroupBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(76, 68);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(75, 23);
            this.addRecordButton.TabIndex = 0;
            this.addRecordButton.Text = "Добавить";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(157, 68);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Отмена";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя и инициалы";
            // 
            // textNameBox
            // 
            this.textNameBox.Location = new System.Drawing.Point(111, 13);
            this.textNameBox.MaxLength = 25;
            this.textNameBox.Name = "textNameBox";
            this.textNameBox.Size = new System.Drawing.Size(121, 20);
            this.textNameBox.TabIndex = 3;
            // 
            // comboGroupBox
            // 
            this.comboGroupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroupBox.FormattingEnabled = true;
            this.comboGroupBox.Location = new System.Drawing.Point(111, 41);
            this.comboGroupBox.Name = "comboGroupBox";
            this.comboGroupBox.Size = new System.Drawing.Size(121, 21);
            this.comboGroupBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Группа";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 103);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboGroupBox);
            this.Controls.Add(this.textNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addRecordButton);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNameBox;
        private System.Windows.Forms.ComboBox comboGroupBox;
        private System.Windows.Forms.Label label2;
    }
}