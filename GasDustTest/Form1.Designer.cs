namespace GasDustTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lError = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbm11 = new TextBox();
            tbm21 = new TextBox();
            tbV1 = new TextBox();
            label6 = new Label();
            tbm12 = new TextBox();
            tbm22 = new TextBox();
            tbV2 = new TextBox();
            bCalculate = new Button();
            label7 = new Label();
            tbDust1 = new TextBox();
            tbDust2 = new TextBox();
            label8 = new Label();
            tbCons = new TextBox();
            label9 = new Label();
            tbResult = new TextBox();
            bSaveFile = new Button();
            bSaveDB = new Button();
            sfd = new SaveFileDialog();
            SuspendLayout();
            // 
            // lError
            // 
            lError.AutoSize = true;
            lError.ForeColor = Color.Red;
            lError.Location = new Point(12, 15);
            lError.Name = "lError";
            lError.Size = new Size(0, 15);
            lError.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 52);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Испытание 1";
            // 
            // label3
            // 
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(129, 35);
            label3.TabIndex = 2;
            label3.Text = "Масса трубки до пропускания газа";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(12, 126);
            label4.Name = "label4";
            label4.Size = new Size(129, 35);
            label4.TabIndex = 2;
            label4.Text = "Масса трубки после пропускания газа";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(12, 170);
            label5.Name = "label5";
            label5.Size = new Size(129, 35);
            label5.TabIndex = 2;
            label5.Text = "Объём испытуемого газа";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbm11
            // 
            tbm11.Location = new Point(152, 88);
            tbm11.Name = "tbm11";
            tbm11.Size = new Size(100, 23);
            tbm11.TabIndex = 3;
            tbm11.KeyPress += OnlyDigit_KeyPress;
            tbm11.Leave += TextBox_Leave;
            // 
            // tbm21
            // 
            tbm21.Location = new Point(152, 133);
            tbm21.Name = "tbm21";
            tbm21.Size = new Size(100, 23);
            tbm21.TabIndex = 3;
            tbm21.KeyPress += OnlyDigit_KeyPress;
            tbm21.Leave += TextBox_Leave;
            // 
            // tbV1
            // 
            tbV1.Location = new Point(152, 177);
            tbV1.Name = "tbV1";
            tbV1.Size = new Size(100, 23);
            tbV1.TabIndex = 3;
            tbV1.KeyPress += OnlyDigit_KeyPress;
            tbV1.Leave += TextBox_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 52);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 1;
            label6.Text = "Испытание 2";
            // 
            // tbm12
            // 
            tbm12.Location = new Point(258, 88);
            tbm12.Name = "tbm12";
            tbm12.Size = new Size(100, 23);
            tbm12.TabIndex = 3;
            tbm12.KeyPress += OnlyDigit_KeyPress;
            tbm12.Leave += TextBox_Leave;
            // 
            // tbm22
            // 
            tbm22.Location = new Point(258, 133);
            tbm22.Name = "tbm22";
            tbm22.Size = new Size(100, 23);
            tbm22.TabIndex = 3;
            tbm22.KeyPress += OnlyDigit_KeyPress;
            tbm22.Leave += TextBox_Leave;
            // 
            // tbV2
            // 
            tbV2.Location = new Point(258, 177);
            tbV2.Name = "tbV2";
            tbV2.Size = new Size(100, 23);
            tbV2.TabIndex = 3;
            tbV2.KeyPress += OnlyDigit_KeyPress;
            tbV2.Leave += TextBox_Leave;
            // 
            // bCalculate
            // 
            bCalculate.Location = new Point(12, 219);
            bCalculate.Name = "bCalculate";
            bCalculate.Size = new Size(346, 23);
            bCalculate.TabIndex = 4;
            bCalculate.Text = "Выполнить расчёт";
            bCalculate.UseVisualStyleBackColor = true;
            bCalculate.Click += bCalculate_Click;
            // 
            // label7
            // 
            label7.Location = new Point(12, 255);
            label7.Name = "label7";
            label7.Size = new Size(129, 35);
            label7.TabIndex = 2;
            label7.Text = "Массовая доля смолы и пыли";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbDust1
            // 
            tbDust1.Location = new Point(152, 262);
            tbDust1.Name = "tbDust1";
            tbDust1.ReadOnly = true;
            tbDust1.Size = new Size(100, 23);
            tbDust1.TabIndex = 3;
            // 
            // tbDust2
            // 
            tbDust2.Location = new Point(258, 262);
            tbDust2.Name = "tbDust2";
            tbDust2.ReadOnly = true;
            tbDust2.Size = new Size(100, 23);
            tbDust2.TabIndex = 3;
            // 
            // label8
            // 
            label8.Location = new Point(12, 296);
            label8.Name = "label8";
            label8.Size = new Size(129, 35);
            label8.TabIndex = 2;
            label8.Text = "Согласованность результатов";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbCons
            // 
            tbCons.Location = new Point(152, 303);
            tbCons.Name = "tbCons";
            tbCons.ReadOnly = true;
            tbCons.Size = new Size(206, 23);
            tbCons.TabIndex = 3;
            // 
            // label9
            // 
            label9.Location = new Point(12, 336);
            label9.Name = "label9";
            label9.Size = new Size(129, 35);
            label9.TabIndex = 2;
            label9.Text = "Результат испытаний";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(152, 343);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(206, 23);
            tbResult.TabIndex = 3;
            // 
            // bSaveFile
            // 
            bSaveFile.Enabled = false;
            bSaveFile.Location = new Point(196, 389);
            bSaveFile.Name = "bSaveFile";
            bSaveFile.Size = new Size(162, 23);
            bSaveFile.TabIndex = 5;
            bSaveFile.Text = "Сохранить в файл";
            bSaveFile.UseVisualStyleBackColor = true;
            bSaveFile.Click += bSaveFile_Click;
            // 
            // bSaveDB
            // 
            bSaveDB.Enabled = false;
            bSaveDB.Location = new Point(12, 389);
            bSaveDB.Name = "bSaveDB";
            bSaveDB.Size = new Size(167, 23);
            bSaveDB.TabIndex = 5;
            bSaveDB.Text = "Сохранить в базу данных";
            bSaveDB.UseVisualStyleBackColor = true;
            bSaveDB.Click += bSaveDB_Click;
            // 
            // sfd
            // 
            sfd.FileName = "DustTest.txt";
            sfd.Filter = "Текстовый документ|*.txt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 424);
            Controls.Add(bSaveDB);
            Controls.Add(bSaveFile);
            Controls.Add(bCalculate);
            Controls.Add(tbDust2);
            Controls.Add(tbV2);
            Controls.Add(tbResult);
            Controls.Add(tbCons);
            Controls.Add(tbDust1);
            Controls.Add(tbm22);
            Controls.Add(tbV1);
            Controls.Add(tbm12);
            Controls.Add(label9);
            Controls.Add(tbm21);
            Controls.Add(label8);
            Controls.Add(tbm11);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lError);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lError;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbm11;
        private TextBox tbm21;
        private TextBox tbV1;
        private Label label6;
        private TextBox tbm12;
        private TextBox tbm22;
        private TextBox tbV2;
        private Button bCalculate;
        private Label label7;
        private TextBox tbDust1;
        private TextBox tbDust2;
        private Label label8;
        private TextBox tbCons;
        private Label label9;
        private TextBox tbResult;
        private Button bSaveFile;
        private Button bSaveDB;
        private SaveFileDialog sfd;
    }
}
