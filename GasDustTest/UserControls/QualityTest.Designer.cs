namespace GasDustTest.UserControls
{
    partial class QualityTest
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
            label1 = new Label();
            cbFilter = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(440, 45);
            label1.TabIndex = 0;
            label1.Text = "Для качественного определения необходимо пропустить газ через \r\nватный фильтр 500 дм³ со скоростью 75-80 дм³/ч.\r\nПо окончанию пропуска газа извлесь фильтр и проверить на наличие налёта.";
            // 
            // cbFilter
            // 
            cbFilter.AutoSize = true;
            cbFilter.Location = new Point(3, 60);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(190, 19);
            cbFilter.TabIndex = 1;
            cbFilter.Text = "Обнаружен налёт на фильтре";
            cbFilter.UseVisualStyleBackColor = true;
            cbFilter.CheckedChanged += cbFilter_CheckedChanged;
            // 
            // QualityTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbFilter);
            Controls.Add(label1);
            Name = "QualityTest";
            Size = new Size(452, 250);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox cbFilter;
    }
}
