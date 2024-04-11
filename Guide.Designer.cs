namespace Library
{
    partial class Guide
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
            panel2 = new Panel();
            update = new Button();
            lable11 = new Label();
            back = new Button();
            guidegrid = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            save = new Button();
            change = new Button();
            delete = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guidegrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Controls.Add(update);
            panel2.Controls.Add(lable11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 100);
            panel2.TabIndex = 2;
            // 
            // update
            // 
            update.Location = new Point(593, 30);
            update.Name = "update";
            update.Size = new Size(107, 43);
            update.TabIndex = 24;
            update.Text = "Обновить";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // lable11
            // 
            lable11.AutoSize = true;
            lable11.Font = new Font("SimSun", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable11.Location = new Point(188, 30);
            lable11.Name = "lable11";
            lable11.Size = new Size(345, 33);
            lable11.TabIndex = 0;
            lable11.Text = "Справочник";
            lable11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            back.Dock = DockStyle.Bottom;
            back.Font = new Font("SimSun", 10F, FontStyle.Bold);
            back.Location = new Point(0, 599);
            back.Name = "back";
            back.Size = new Size(713, 34);
            back.TabIndex = 2;
            back.Text = "Назад";
            back.TextAlign = ContentAlignment.BottomCenter;
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // guidegrid
            // 
            guidegrid.AllowUserToAddRows = false;
            guidegrid.AllowUserToDeleteRows = false;
            guidegrid.AllowUserToResizeColumns = false;
            guidegrid.AllowUserToResizeRows = false;
            guidegrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guidegrid.Location = new Point(12, 106);
            guidegrid.Name = "guidegrid";
            guidegrid.ReadOnly = true;
            guidegrid.RowHeadersWidth = 62;
            guidegrid.Size = new Size(521, 311);
            guidegrid.TabIndex = 3;
            guidegrid.CellClick += guidegrid_CellClick;
            guidegrid.CellContentClick += guidegrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 420);
            label1.Name = "label1";
            label1.Size = new Size(213, 33);
            label1.TabIndex = 4;
            label1.Text = "Запись";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 531);
            label4.Name = "label4";
            label4.Size = new Size(0, 33);
            label4.TabIndex = 7;
            label4.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.Controls.Add(save);
            panel1.Controls.Add(change);
            panel1.Controls.Add(delete);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(guidegrid);
            panel1.Controls.Add(back);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 633);
            panel1.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(216, 456);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(484, 31);
            textBox6.TabIndex = 67;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label7.Location = new Point(33, 462);
            label7.Name = "label7";
            label7.Size = new Size(177, 20);
            label7.TabIndex = 66;
            label7.Text = "Название";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(216, 493);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(484, 31);
            textBox5.TabIndex = 65;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label6.Location = new Point(96, 499);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 64;
            label6.Text = "Автор";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(216, 530);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(484, 31);
            textBox4.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label5.Location = new Point(117, 536);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 62;
            label5.Text = "Жанр";
            // 
            // save
            // 
            save.Location = new Point(549, 270);
            save.Name = "save";
            save.Size = new Size(151, 45);
            save.TabIndex = 10;
            save.Text = "Добавить";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // change
            // 
            change.Location = new Point(549, 189);
            change.Name = "change";
            change.Size = new Size(151, 45);
            change.TabIndex = 9;
            change.Text = "Изменить";
            change.UseVisualStyleBackColor = true;
            change.Click += change_Click;
            // 
            // delete
            // 
            delete.Location = new Point(549, 113);
            delete.Name = "delete";
            delete.Size = new Size(151, 45);
            delete.TabIndex = 8;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Guide
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 633);
            Controls.Add(panel1);
            Name = "Guide";
            Text = "Guide";
            Load += Guide_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guidegrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lable11;
        private Button back;
        private Label label1;
        private Label label4;
        private Panel panel1;
        private Button save;
        private Button change;
        private Button delete;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private DataGridView guidegrid;
        private Button update;
    }
}