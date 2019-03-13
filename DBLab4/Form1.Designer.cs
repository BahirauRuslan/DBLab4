namespace DBLab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.readButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.countInputLabel = new System.Windows.Forms.Label();
            this.addedInputLabel = new System.Windows.Forms.Label();
            this.addedLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idInputLabel = new System.Windows.Forms.Label();
            this.mainGridView = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список студентов";
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(235, 9);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "Читать";
            this.readButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(235, 38);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(235, 71);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 4;
            this.countButton.Text = "Всего";
            this.countButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(235, 100);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(12, 130);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(131, 13);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "Общее число студентов:";
            // 
            // countInputLabel
            // 
            this.countInputLabel.AutoSize = true;
            this.countInputLabel.Location = new System.Drawing.Point(149, 130);
            this.countInputLabel.Name = "countInputLabel";
            this.countInputLabel.Size = new System.Drawing.Size(0, 13);
            this.countInputLabel.TabIndex = 7;
            // 
            // addedInputLabel
            // 
            this.addedInputLabel.AutoSize = true;
            this.addedInputLabel.Location = new System.Drawing.Point(130, 152);
            this.addedInputLabel.Name = "addedInputLabel";
            this.addedInputLabel.Size = new System.Drawing.Size(0, 13);
            this.addedInputLabel.TabIndex = 9;
            // 
            // addedLabel
            // 
            this.addedLabel.AutoSize = true;
            this.addedLabel.Location = new System.Drawing.Point(12, 152);
            this.addedLabel.Name = "addedLabel";
            this.addedLabel.Size = new System.Drawing.Size(112, 13);
            this.addedLabel.TabIndex = 8;
            this.addedLabel.Text = "Добавлено записей:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 176);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(158, 13);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "Новому студенту присвоен id:";
            // 
            // idInputLabel
            // 
            this.idInputLabel.AutoSize = true;
            this.idInputLabel.Location = new System.Drawing.Point(176, 176);
            this.idInputLabel.Name = "idInputLabel";
            this.idInputLabel.Size = new System.Drawing.Size(0, 13);
            this.idInputLabel.TabIndex = 11;
            // 
            // mainGridView
            // 
            this.mainGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.GroupNumber});
            this.mainGridView.Location = new System.Drawing.Point(15, 25);
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.ReadOnly = true;
            this.mainGridView.RowHeadersVisible = false;
            this.mainGridView.RowHeadersWidth = 21;
            this.mainGridView.Size = new System.Drawing.Size(214, 98);
            this.mainGridView.TabIndex = 12;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Имя студента";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // GroupNumber
            // 
            this.GroupNumber.HeaderText = "Группа";
            this.GroupNumber.Name = "GroupNumber";
            this.GroupNumber.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 212);
            this.Controls.Add(this.mainGridView);
            this.Controls.Add(this.idInputLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addedInputLabel);
            this.Controls.Add(this.addedLabel);
            this.Controls.Add(this.countInputLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Lab #4, Ruslan, gr. 10701116";
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label countInputLabel;
        private System.Windows.Forms.Label addedInputLabel;
        private System.Windows.Forms.Label addedLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label idInputLabel;
        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNumber;
    }
}

