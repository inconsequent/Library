namespace Library
{
    partial class Readers
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
            panel1 = new Panel();
            address = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            save = new Button();
            change = new Button();
            delete = new Button();
            label2 = new Label();
            label1 = new Label();
            readersgrid = new DataGridView();
            panel2 = new Panel();
            lable11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readersgrid).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // back
            // 
            back.Dock = DockStyle.Bottom;
            back.Location = new Point(0, 599);
            back.Name = "back";
            back.Size = new Size(713, 34);
            back.TabIndex = 2;
            back.Text = "Назад";
            back.TextAlign = ContentAlignment.BottomCenter;
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(address);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(save);
            panel1.Controls.Add(change);
            panel1.Controls.Add(delete);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(readersgrid);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 599);
            panel1.TabIndex = 3;
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("SimSun", 10F, FontStyle.Bold);
            address.Location = new Point(137, 507);
            address.Name = "address";
            address.Size = new Size(156, 20);
            address.TabIndex = 55;
            address.Text = "Возраст";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(305, 501);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(396, 31);
            textBox3.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label3.Location = new Point(3, 553);
            label3.Name = "label3";
            label3.Size = new Size(293, 20);
            label3.TabIndex = 53;
            label3.Text = "Номер карточки";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 547);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(396, 31);
            textBox2.TabIndex = 52;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 461);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 31);
            textBox1.TabIndex = 51;
            // 
            // save
            // 
            save.Location = new Point(549, 270);
            save.Name = "save";
            save.Size = new Size(151, 45);
            save.TabIndex = 50;
            save.Text = "Сохранить";
            save.UseVisualStyleBackColor = true;
            // 
            // change
            // 
            change.Location = new Point(549, 189);
            change.Name = "change";
            change.Size = new Size(151, 45);
            change.TabIndex = 49;
            change.Text = "Изменить";
            change.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(549, 113);
            delete.Name = "delete";
            delete.Size = new Size(151, 45);
            delete.TabIndex = 48;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label2.Location = new Point(188, 467);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 47;
            label2.Text = "Ф.И.О.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 420);
            label1.Name = "label1";
            label1.Size = new Size(213, 33);
            label1.TabIndex = 46;
            label1.Text = "Запись";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // readersgrid
            // 
            readersgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            readersgrid.Location = new Point(12, 106);
            readersgrid.Name = "readersgrid";
            readersgrid.RowHeadersWidth = 62;
            readersgrid.Size = new Size(521, 311);
            readersgrid.TabIndex = 45;
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Controls.Add(lable11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 100);
            panel2.TabIndex = 2;
            // 
            // lable11
            // 
            lable11.AutoSize = true;
            lable11.Font = new Font("SimSun", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable11.Location = new Point(188, 30);
            lable11.Name = "lable11";
            lable11.Size = new Size(279, 33);
            lable11.TabIndex = 0;
            lable11.Text = "Читатели";
            lable11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Readers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 633);
            Controls.Add(panel1);
            Controls.Add(back);
            Name = "Readers";
            Text = "Readers";
            Load += Readers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)readersgrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Panel panel1;
        private Panel panel2;
        private Label lable11;
        private DataGridView readersgrid;
        private Label address;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button save;
        private Button change;
        private Button delete;
        private Label label2;
        private Label label1;
    }
}