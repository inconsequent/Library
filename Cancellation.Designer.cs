namespace Library
{
    partial class Cancellation
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
            back = new Button();
            SuspendLayout();
            // 
            // back
            // 
            back.Dock = DockStyle.Bottom;
            back.Location = new Point(0, 599);
            back.Name = "back";
            back.Size = new Size(713, 34);
            back.TabIndex = 0;
            back.Text = "Назад";
            back.TextAlign = ContentAlignment.BottomCenter;
            back.UseVisualStyleBackColor = true;
            back.Click += button1_Click;
            // 
            // Cancellation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 633);
            Controls.Add(back);
            Name = "Cancellation";
            Text = "Cancellation";
            ResumeLayout(false);
        }

        #endregion

        private Button back;
    }
}