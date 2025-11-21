namespace GasDustTest
{
    partial class FormDBView
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
            dgTable = new DataGridView();
            bClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgTable).BeginInit();
            SuspendLayout();
            // 
            // dgTable
            // 
            dgTable.AllowUserToAddRows = false;
            dgTable.AllowUserToDeleteRows = false;
            dgTable.AllowUserToOrderColumns = true;
            dgTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTable.Location = new Point(12, 12);
            dgTable.MultiSelect = false;
            dgTable.Name = "dgTable";
            dgTable.ReadOnly = true;
            dgTable.Size = new Size(579, 356);
            dgTable.TabIndex = 0;
            // 
            // bClose
            // 
            bClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bClose.Location = new Point(516, 374);
            bClose.Name = "bClose";
            bClose.Size = new Size(75, 23);
            bClose.TabIndex = 1;
            bClose.Text = "Закрыть";
            bClose.UseVisualStyleBackColor = true;
            bClose.Click += bClose_Click;
            // 
            // FormDBView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 409);
            Controls.Add(bClose);
            Controls.Add(dgTable);
            Name = "FormDBView";
            Text = "Просмотр БД";
            Load += FormDBView_Load;
            ((System.ComponentModel.ISupportInitialize)dgTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgTable;
        private Button bClose;
    }
}