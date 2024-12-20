﻿namespace Library
{
    partial class Cards
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            interf = new GroupBox();
            delete = new Button();
            update = new Button();
            save = new Button();
            change = new Button();
            cardsgrid = new DataGridView();
            panel2 = new Panel();
            lable11 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            interf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cardsgrid).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // back
            // 
            back.Dock = DockStyle.Bottom;
            back.Location = new Point(0, 599);
            back.Name = "back";
            back.Size = new Size(713, 34);
            back.TabIndex = 1;
            back.Text = "Назад";
            back.TextAlign = ContentAlignment.BottomCenter;
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(interf);
            panel1.Controls.Add(cardsgrid);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 599);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(4, 366);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 230);
            groupBox1.TabIndex = 70;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label6.Location = new Point(21, 192);
            label6.Name = "label6";
            label6.Size = new Size(272, 20);
            label6.TabIndex = 37;
            label6.Text = "Дата возврата";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(292, 186);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(404, 31);
            textBox5.TabIndex = 38;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(292, 38);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(404, 31);
            textBox4.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 6);
            label1.Name = "label1";
            label1.Size = new Size(213, 33);
            label1.TabIndex = 24;
            label1.Text = "Запись";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label5.Location = new Point(184, 44);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 35;
            label5.Text = "Ф.И.О.";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label2.Location = new Point(0, 80);
            label2.Name = "label2";
            label2.Size = new Size(293, 20);
            label2.TabIndex = 25;
            label2.Text = "Название книги";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(292, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 31);
            textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(292, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(404, 31);
            textBox2.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label4.Location = new Point(63, 155);
            label4.Name = "label4";
            label4.Size = new Size(230, 20);
            label4.TabIndex = 32;
            label4.Text = "Дата выдачи";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(292, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(404, 31);
            textBox3.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label3.Location = new Point(98, 118);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 31;
            label3.Text = "Код книги";
            // 
            // interf
            // 
            interf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            interf.AutoSize = true;
            interf.Controls.Add(delete);
            interf.Controls.Add(update);
            interf.Controls.Add(save);
            interf.Controls.Add(change);
            interf.Location = new Point(536, 106);
            interf.Name = "interf";
            interf.Size = new Size(174, 289);
            interf.TabIndex = 69;
            interf.TabStop = false;
            // 
            // delete
            // 
            delete.Location = new Point(17, 163);
            delete.Name = "delete";
            delete.Size = new Size(151, 45);
            delete.TabIndex = 8;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.Location = new Point(17, 10);
            update.Name = "update";
            update.Size = new Size(151, 45);
            update.TabIndex = 24;
            update.Text = "Обновить";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // save
            // 
            save.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            save.Location = new Point(17, 112);
            save.Name = "save";
            save.Size = new Size(151, 45);
            save.TabIndex = 10;
            save.Text = "Добавить";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // change
            // 
            change.Location = new Point(17, 61);
            change.Name = "change";
            change.Size = new Size(151, 45);
            change.TabIndex = 9;
            change.Text = "Изменить";
            change.UseVisualStyleBackColor = true;
            change.Click += change_Click;
            // 
            // cardsgrid
            // 
            cardsgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cardsgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cardsgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cardsgrid.Location = new Point(12, 106);
            cardsgrid.Name = "cardsgrid";
            cardsgrid.RowHeadersWidth = 62;
            cardsgrid.Size = new Size(518, 254);
            cardsgrid.TabIndex = 23;
            cardsgrid.CellClick += cardsgrid_CellClick;
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
            lable11.Location = new Point(212, 32);
            lable11.Name = "lable11";
            lable11.Size = new Size(279, 33);
            lable11.TabIndex = 0;
            lable11.Text = "Карточки";
            lable11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cards
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 633);
            Controls.Add(panel1);
            Controls.Add(back);
            Name = "Cards";
            Text = "Cards";
            Load += Cards_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            interf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cardsgrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Panel panel1;
        private Panel panel2;
        private Label lable11;
        private DataGridView cardsgrid;
        private GroupBox interf;
        private Button delete;
        private Button update;
        private Button save;
        private Button change;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private Label label1;
        private Label label5;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Label label6;
        private TextBox textBox5;
    }
}