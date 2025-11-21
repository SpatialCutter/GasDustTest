namespace GasDustTest.UserControls
{
    partial class VolumeInput
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
            tbVolume = new NumericUpDown();
            label = new Label();
            lText = new Label();
            label1 = new Label();
            tbTemp = new NumericUpDown();
            label2 = new Label();
            tbPressure = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)tbVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPressure).BeginInit();
            SuspendLayout();
            // 
            // tbVolume
            // 
            tbVolume.DecimalPlaces = 2;
            tbVolume.Location = new Point(186, 89);
            tbVolume.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            tbVolume.Name = "tbVolume";
            tbVolume.Size = new Size(210, 23);
            tbVolume.TabIndex = 6;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(9, 93);
            label.Name = "label";
            label.Size = new Size(171, 15);
            label.TabIndex = 5;
            label.Text = "Объём испытуемого газа (м³)";
            label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lText
            // 
            lText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lText.Location = new Point(3, 2);
            lText.Name = "lText";
            lText.Size = new Size(509, 69);
            lText.TabIndex = 4;
            lText.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 120);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 5;
            label1.Text = "Температура газа (°K)";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbTemp
            // 
            tbTemp.DecimalPlaces = 2;
            tbTemp.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            tbTemp.Location = new Point(186, 118);
            tbTemp.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            tbTemp.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            tbTemp.Name = "tbTemp";
            tbTemp.Size = new Size(210, 23);
            tbTemp.TabIndex = 6;
            tbTemp.Value = new decimal(new int[] { 29315, 0, 0, 131072 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 150);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 5;
            label2.Text = "Давление газа (Па)";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbPressure
            // 
            tbPressure.DecimalPlaces = 2;
            tbPressure.Location = new Point(186, 147);
            tbPressure.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            tbPressure.Name = "tbPressure";
            tbPressure.Size = new Size(210, 23);
            tbPressure.TabIndex = 6;
            tbPressure.Value = new decimal(new int[] { 101325, 0, 0, 0 });
            // 
            // VolumeInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbPressure);
            Controls.Add(label2);
            Controls.Add(tbTemp);
            Controls.Add(label1);
            Controls.Add(tbVolume);
            Controls.Add(label);
            Controls.Add(lText);
            Name = "VolumeInput";
            Size = new Size(512, 301);
            Load += VolumeInput_Load;
            ((System.ComponentModel.ISupportInitialize)tbVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbPressure).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown tbVolume;
        private Label label;
        private Label lText;
        private Label label1;
        private NumericUpDown tbTemp;
        private Label label2;
        private NumericUpDown tbPressure;
    }
}
