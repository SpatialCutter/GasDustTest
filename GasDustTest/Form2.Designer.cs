namespace GasDustTest
{
    partial class Form2
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
            lHeader = new Label();
            pMain = new Panel();
            bNext = new Button();
            SuspendLayout();
            // 
            // lHeader
            // 
            lHeader.AutoSize = true;
            lHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lHeader.Location = new Point(15, 13);
            lHeader.Name = "lHeader";
            lHeader.Size = new Size(163, 21);
            lHeader.TabIndex = 0;
            lHeader.Text = "Добро пожаловать";
            // 
            // pMain
            // 
            pMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pMain.BackColor = SystemColors.Control;
            pMain.Location = new Point(12, 56);
            pMain.Name = "pMain";
            pMain.Size = new Size(512, 301);
            pMain.TabIndex = 1;
            // 
            // bNext
            // 
            bNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bNext.Location = new Point(449, 373);
            bNext.Name = "bNext";
            bNext.Size = new Size(75, 23);
            bNext.TabIndex = 2;
            bNext.Text = "Далее";
            bNext.UseVisualStyleBackColor = true;
            bNext.Click += bNext_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 408);
            Controls.Add(bNext);
            Controls.Add(pMain);
            Controls.Add(lHeader);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(488, 345);
            Name = "Form2";
            Text = "Мастер определения содержания смолы и пыли в газе бытового потребления";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lHeader;
        private Panel pMain;
        private Button bNext;
    }
}