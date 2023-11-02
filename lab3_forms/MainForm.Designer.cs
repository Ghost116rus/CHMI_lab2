namespace lab3_forms
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
            this.AddFileBtn = new System.Windows.Forms.Button();
            this.ShowDirBtn = new System.Windows.Forms.Button();
            this.DeleteFileBtn = new System.Windows.Forms.Button();
            this.ChangeDirBtn = new System.Windows.Forms.Button();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentDirLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GoBackDirBtn = new System.Windows.Forms.Button();
            this.DisksListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddFileBtn
            // 
            this.AddFileBtn.Location = new System.Drawing.Point(401, 340);
            this.AddFileBtn.Name = "AddFileBtn";
            this.AddFileBtn.Size = new System.Drawing.Size(96, 42);
            this.AddFileBtn.TabIndex = 0;
            this.AddFileBtn.Text = "Создать";
            this.AddFileBtn.UseVisualStyleBackColor = true;
            this.AddFileBtn.Click += new System.EventHandler(this.AddFileBtn_Click);
            // 
            // ShowDirBtn
            // 
            this.ShowDirBtn.Location = new System.Drawing.Point(299, 340);
            this.ShowDirBtn.Name = "ShowDirBtn";
            this.ShowDirBtn.Size = new System.Drawing.Size(96, 42);
            this.ShowDirBtn.TabIndex = 1;
            this.ShowDirBtn.Text = "Обновить";
            this.ShowDirBtn.UseVisualStyleBackColor = true;
            this.ShowDirBtn.Click += new System.EventHandler(this.ShowDirBtn_Click);
            // 
            // DeleteFileBtn
            // 
            this.DeleteFileBtn.Location = new System.Drawing.Point(503, 340);
            this.DeleteFileBtn.Name = "DeleteFileBtn";
            this.DeleteFileBtn.Size = new System.Drawing.Size(96, 42);
            this.DeleteFileBtn.TabIndex = 2;
            this.DeleteFileBtn.Text = "Удалить";
            this.DeleteFileBtn.UseVisualStyleBackColor = true;
            this.DeleteFileBtn.Click += new System.EventHandler(this.DeleteFileBtn_Click);
            // 
            // ChangeDirBtn
            // 
            this.ChangeDirBtn.Location = new System.Drawing.Point(197, 340);
            this.ChangeDirBtn.Name = "ChangeDirBtn";
            this.ChangeDirBtn.Size = new System.Drawing.Size(96, 42);
            this.ChangeDirBtn.TabIndex = 3;
            this.ChangeDirBtn.Text = "Перейти";
            this.ChangeDirBtn.UseVisualStyleBackColor = true;
            this.ChangeDirBtn.Click += new System.EventHandler(this.ChangeDirBtn_Click);
            // 
            // FilesListBox
            // 
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 16;
            this.FilesListBox.Location = new System.Drawing.Point(179, 45);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(445, 276);
            this.FilesListBox.TabIndex = 4;
            this.FilesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FilesListBox_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текущая директория:";
            // 
            // CurrentDirLbl
            // 
            this.CurrentDirLbl.AutoSize = true;
            this.CurrentDirLbl.Location = new System.Drawing.Point(328, 26);
            this.CurrentDirLbl.Name = "CurrentDirLbl";
            this.CurrentDirLbl.Size = new System.Drawing.Size(23, 16);
            this.CurrentDirLbl.TabIndex = 6;
            this.CurrentDirLbl.Text = "C:\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // GoBackDirBtn
            // 
            this.GoBackDirBtn.Location = new System.Drawing.Point(77, 279);
            this.GoBackDirBtn.Name = "GoBackDirBtn";
            this.GoBackDirBtn.Size = new System.Drawing.Size(96, 42);
            this.GoBackDirBtn.TabIndex = 8;
            this.GoBackDirBtn.Text = "Назад";
            this.GoBackDirBtn.UseVisualStyleBackColor = true;
            this.GoBackDirBtn.Click += new System.EventHandler(this.GoBackDirBtn_Click);
            // 
            // DisksListBox
            // 
            this.DisksListBox.FormattingEnabled = true;
            this.DisksListBox.ItemHeight = 16;
            this.DisksListBox.Location = new System.Drawing.Point(29, 70);
            this.DisksListBox.Name = "DisksListBox";
            this.DisksListBox.Size = new System.Drawing.Size(120, 196);
            this.DisksListBox.TabIndex = 9;
            this.DisksListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DisksListBox_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Доступные диски:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DisksListBox);
            this.Controls.Add(this.GoBackDirBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentDirLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.ChangeDirBtn);
            this.Controls.Add(this.DeleteFileBtn);
            this.Controls.Add(this.ShowDirBtn);
            this.Controls.Add(this.AddFileBtn);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddFileBtn;
        private System.Windows.Forms.Button ShowDirBtn;
        private System.Windows.Forms.Button DeleteFileBtn;
        private System.Windows.Forms.Button ChangeDirBtn;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentDirLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GoBackDirBtn;
        private System.Windows.Forms.ListBox DisksListBox;
        private System.Windows.Forms.Label label3;
    }
}

