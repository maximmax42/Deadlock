namespace Deadlock
{
    partial class RoundButton
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
            this.SuspendLayout();
            // 
            // RoundButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Deadlock.Properties.Resources.button;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DoubleBuffered = true;
            this.Name = "RoundButton";
            this.Size = new System.Drawing.Size(125, 65);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundButton_MouseDown);
            this.MouseLeave += new System.EventHandler(this.roundButton_MouseLeave);
            this.MouseHover += new System.EventHandler(this.roundButton_MouseHover);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roundButton_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
