namespace GasDustTest.UserControls
{
    partial class MassInput
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
            lText = new Label();
            label = new Label();
            tbMass = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)tbMass).BeginInit();
            SuspendLayout();
            // 
            // lText
            // 
            lText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lText.Location = new Point(3, 2);
            lText.Name = "lText";
            lText.Size = new Size(509, 72);
            lText.TabIndex = 1;
            lText.Text = "label1";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(11, 91);
            label.Name = "label";
            label.Size = new Size(102, 15);
            label.TabIndex = 2;
            label.Text = "Масса трубки (г.)";
            label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbMass
            // 
            tbMass.DecimalPlaces = 5;
            tbMass.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            tbMass.Location = new Point(119, 88);
            tbMass.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            tbMass.Name = "tbMass";
            tbMass.Size = new Size(210, 23);
            tbMass.TabIndex = 3;
            tbMass.Leave += tbMass_Leave;
            // 
            // MassInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbMass);
            Controls.Add(label);
            Controls.Add(lText);
            Name = "MassInput";
            Size = new Size(512, 301);
            Load += MassInput_Load;
            ((System.ComponentModel.ISupportInitialize)tbMass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lText;
        private Label label;
        private NumericUpDown tbMass;
    }
}
