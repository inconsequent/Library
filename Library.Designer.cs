namespace Library
{
    partial class Library
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
            panel1 = new Panel();
            close = new Button();
            purchase = new Button();
            providers = new Button();
            cards = new Button();
            cancellation = new Button();
            readers = new Button();
            place = new Button();
            guide = new Button();
            panel2 = new Panel();
            lable11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(close);
            panel1.Controls.Add(purchase);
            panel1.Controls.Add(providers);
            panel1.Controls.Add(cards);
            panel1.Controls.Add(cancellation);
            panel1.Controls.Add(readers);
            panel1.Controls.Add(place);
            panel1.Controls.Add(guide);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 633);
            panel1.TabIndex = 0;
            // 
            // close
            // 
            close.Cursor = Cursors.Hand;
            close.Font = new Font("SimSun", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(222, 537);
            close.Name = "close";
            close.Size = new Size(253, 48);
            close.TabIndex = 7;
            close.Text = "Закрыть";
            close.UseVisualStyleBackColor = true;
            close.Click += Close_Click;
            // 
            // purchase
            // 
            purchase.Cursor = Cursors.Hand;
            purchase.Font = new Font("SimSun", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purchase.Location = new Point(369, 437);
            purchase.Name = "purchase";
            purchase.Size = new Size(253, 48);
            purchase.TabIndex = 6;
            purchase.Text = "Закупки";
            purchase.UseVisualStyleBackColor = true;
            purchase.Click += purchase_Click;
            // 
            // providers
            // 
            providers.Cursor = Cursors.Hand;
            providers.Font = new Font("SimSun", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            providers.Location = new Point(63, 437);
            providers.Name = "providers";
            providers.Size = new Size(253, 48);
            providers.TabIndex = 5;
            providers.Text = "Поставщики";
            providers.UseVisualStyleBackColor = true;
            providers.Click += providers_Click;
            // 
            // cards
            // 
            cards.Cursor = Cursors.Hand;
            cards.Font = new Font("SimSun", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cards.Location = new Point(369, 329);
            cards.Name = "cards";
            cards.Size = new Size(253, 48);
            cards.TabIndex = 4;
            cards.Text = "Карточки";
            cards.UseVisualStyleBackColor = true;
            cards.Click += cards_Click;
            // 
            // cancellation
            // 
            cancellation.Cursor = Cursors.Hand;
            cancellation.Font = new Font("SimSun", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancellation.Location = new Point(63, 329);
            cancellation.Name = "cancellation";
            cancellation.Size = new Size(253, 48);
            cancellation.TabIndex = 3;
            cancellation.Text = "Списание";
            cancellation.UseVisualStyleBackColor = true;
            cancellation.Click += cancellation_Click;
            // 
            // readers
            // 
            readers.Cursor = Cursors.Hand;
            readers.Font = new Font("SimSun", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            readers.Location = new Point(369, 231);
            readers.Name = "readers";
            readers.Size = new Size(253, 48);
            readers.TabIndex = 2;
            readers.Text = "Читатели";
            readers.UseVisualStyleBackColor = true;
            readers.Click += readers_Click;
            // 
            // place
            // 
            place.Cursor = Cursors.Hand;
            place.Font = new Font("SimSun", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            place.Location = new Point(63, 231);
            place.Name = "place";
            place.Size = new Size(253, 48);
            place.TabIndex = 1;
            place.Text = "Место";
            place.UseVisualStyleBackColor = true;
            place.Click += place_Click;
            // 
            // guide
            // 
            guide.Cursor = Cursors.Hand;
            guide.Font = new Font("SimSun", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guide.Location = new Point(222, 135);
            guide.Name = "guide";
            guide.Size = new Size(253, 48);
            guide.TabIndex = 0;
            guide.Text = "Справочник";
            guide.UseVisualStyleBackColor = true;
            guide.Click += guide_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Controls.Add(lable11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 100);
            panel2.TabIndex = 1;
            // 
            // lable11
            // 
            lable11.AutoSize = true;
            lable11.Font = new Font("SimSun", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable11.Location = new Point(188, 30);
            lable11.Name = "lable11";
            lable11.Size = new Size(345, 33);
            lable11.TabIndex = 0;
            lable11.Text = "Библиотека";
            lable11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 633);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Library";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lable11;
        private Button purchase;
        private Button providers;
        private Button cards;
        private Button cancellation;
        private Button readers;
        private Button place;
        private Button guide;
        private Button close;
    }
}
