namespace GasDustTest.UserControls
{
    partial class LabeledTimer
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
            components = new System.ComponentModel.Container();
            lText = new Label();
            lTimer = new Label();
            bStart = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lText
            // 
            lText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lText.AutoSize = true;
            lText.Location = new Point(2, 2);
            lText.Name = "lText";
            lText.Size = new Size(38, 15);
            lText.TabIndex = 0;
            lText.Text = "label1";
            // 
            // lTimer
            // 
            lTimer.AutoSize = true;
            lTimer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lTimer.Location = new Point(3, 80);
            lTimer.Name = "lTimer";
            lTimer.Size = new Size(72, 30);
            lTimer.TabIndex = 1;
            lTimer.Text = "label1";
            // 
            // bStart
            // 
            bStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bStart.Location = new Point(3, 113);
            bStart.Name = "bStart";
            bStart.Size = new Size(171, 23);
            bStart.TabIndex = 2;
            bStart.Text = "Запустить таймер";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // LabeledTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bStart);
            Controls.Add(lTimer);
            Controls.Add(lText);
            Name = "LabeledTimer";
            Size = new Size(431, 210);
            Load += LabeledTimer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lText;
        private Label lTimer;
        private Button bStart;
        private System.Windows.Forms.Timer timer;
    }
}
