namespace GasDustTest.UserControls
{
    partial class ResultOutput
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            bSaveDB = new Button();
            bSaveFile = new Button();
            tbDust2 = new TextBox();
            tbResult = new TextBox();
            tbCons = new TextBox();
            tbDust1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            sfd = new SaveFileDialog();
            SuspendLayout();
            // 
            // bSaveDB
            // 
            bSaveDB.Location = new Point(1, 168);
            bSaveDB.Name = "bSaveDB";
            bSaveDB.Size = new Size(167, 23);
            bSaveDB.TabIndex = 13;
            bSaveDB.Text = "Сохранить в базу данных";
            bSaveDB.UseVisualStyleBackColor = true;
            bSaveDB.Click += bSaveDB_Click;
            // 
            // bSaveFile
            // 
            bSaveFile.Location = new Point(185, 168);
            bSaveFile.Name = "bSaveFile";
            bSaveFile.Size = new Size(162, 23);
            bSaveFile.TabIndex = 14;
            bSaveFile.Text = "Сохранить в файл";
            bSaveFile.UseVisualStyleBackColor = true;
            bSaveFile.Click += bSaveFile_Click;
            // 
            // tbDust2
            // 
            tbDust2.Location = new Point(247, 41);
            tbDust2.Name = "tbDust2";
            tbDust2.ReadOnly = true;
            tbDust2.Size = new Size(100, 23);
            tbDust2.TabIndex = 9;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(141, 122);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(206, 23);
            tbResult.TabIndex = 10;
            // 
            // tbCons
            // 
            tbCons.Location = new Point(141, 82);
            tbCons.Name = "tbCons";
            tbCons.ReadOnly = true;
            tbCons.Size = new Size(206, 23);
            tbCons.TabIndex = 11;
            // 
            // tbDust1
            // 
            tbDust1.Location = new Point(141, 41);
            tbDust1.Name = "tbDust1";
            tbDust1.ReadOnly = true;
            tbDust1.Size = new Size(100, 23);
            tbDust1.TabIndex = 12;
            // 
            // label9
            // 
            label9.Location = new Point(1, 115);
            label9.Name = "label9";
            label9.Size = new Size(129, 35);
            label9.TabIndex = 6;
            label9.Text = "Результат испытаний";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new Point(1, 75);
            label8.Name = "label8";
            label8.Size = new Size(129, 35);
            label8.TabIndex = 7;
            label8.Text = "Согласованность результатов";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(1, 34);
            label7.Name = "label7";
            label7.Size = new Size(129, 35);
            label7.TabIndex = 8;
            label7.Text = "Массовая доля смолы и пыли";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 2);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 15;
            label1.Text = "Расчёт завершён.";
            // 
            // sfd
            // 
            sfd.FileName = "DustTest.txt";
            sfd.Filter = "Текстовый документ|*.txt";
            // 
            // ResultOutput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(bSaveDB);
            Controls.Add(bSaveFile);
            Controls.Add(tbDust2);
            Controls.Add(tbResult);
            Controls.Add(tbCons);
            Controls.Add(tbDust1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Name = "ResultOutput";
            Size = new Size(464, 214);
            Load += ResultOutput_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSaveDB;
        private Button bSaveFile;
        private TextBox tbDust2;
        private TextBox tbResult;
        private TextBox tbCons;
        private TextBox tbDust1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label1;
        private SaveFileDialog sfd;
    }
}
