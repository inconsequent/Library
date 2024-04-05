namespace Library
{
    partial class Purchase
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
            textBox3 = new TextBox();
            panel2 = new Panel();
            lable11 = new Label();
            label4 = new Label();
            purcgrid = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            delete = new Button();
            save = new Button();
            change = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)purcgrid).BeginInit();
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
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(purcgrid);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(delete);
            panel1.Controls.Add(save);
            panel1.Controls.Add(change);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 599);
            panel1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 560);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(484, 31);
            textBox3.TabIndex = 55;
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
            lable11.Location = new Point(232, 33);
            lable11.Name = "lable11";
            lable11.Size = new Size(246, 33);
            lable11.TabIndex = 0;
            lable11.Text = "Закупки";
            lable11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label4.Location = new Point(106, 566);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 54;
            label4.Text = "Дата ";
            // 
            // purcgrid
            // 
            purcgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            purcgrid.Location = new Point(12, 106);
            purcgrid.Name = "purcgrid";
            purcgrid.RowHeadersWidth = 62;
            purcgrid.Size = new Size(531, 223);
            purcgrid.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label3.Location = new Point(13, 529);
            label3.Name = "label3";
            label3.Size = new Size(198, 20);
            label3.TabIndex = 53;
            label3.Text = "Стоимость";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 332);
            label1.Name = "label1";
            label1.Size = new Size(213, 33);
            label1.TabIndex = 46;
            label1.Text = "Запись";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(217, 523);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(484, 31);
            textBox2.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label2.Location = new Point(12, 492);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 47;
            label2.Text = "Поставщик";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 486);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(484, 31);
            textBox1.TabIndex = 51;
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
            // textBox4
            // 
            textBox4.Location = new Point(216, 449);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(484, 31);
            textBox4.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label5.Location = new Point(117, 455);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 56;
            label5.Text = "Жанр";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(216, 412);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(484, 31);
            textBox5.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label6.Location = new Point(96, 418);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 58;
            label6.Text = "Автор";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(216, 375);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(484, 31);
            textBox6.TabIndex = 61;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label7.Location = new Point(33, 381);
            label7.Name = "label7";
            label7.Size = new Size(177, 20);
            label7.TabIndex = 60;
            label7.Text = "Название";
            // 
            // Purchase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 633);
            Controls.Add(panel1);
            Controls.Add(back);
            Name = "Purchase";
            Text = "Purchase";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)purcgrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Panel panel1;
        private Panel panel2;
        private Label lable11;
        private TextBox textBox3;
        private Label label4;
        private DataGridView purcgrid;
        private Label label3;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button delete;
        private Button save;
        private Button change;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
    }
}