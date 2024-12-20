﻿namespace Library
{
    partial class Providers
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
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            interf = new GroupBox();
            delete = new Button();
            button1 = new Button();
            save = new Button();
            change = new Button();
            panel2 = new Panel();
            lable11 = new Label();
            providersgrid = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            interf.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)providersgrid).BeginInit();
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
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(interf);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(providersgrid);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 599);
            panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 431);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(700, 165);
            groupBox1.TabIndex = 71;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label3.Location = new Point(16, 89);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 53;
            label3.Text = "Адрес";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(539, 31);
            textBox2.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 10F, FontStyle.Bold);
            label2.Location = new Point(25, 45);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 47;
            label2.Text = "Ф.И.О.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(539, 31);
            textBox1.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 33);
            label1.TabIndex = 46;
            label1.Text = "Запись";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // interf
            // 
            interf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            interf.AutoSize = true;
            interf.Controls.Add(delete);
            interf.Controls.Add(button1);
            interf.Controls.Add(save);
            interf.Controls.Add(change);
            interf.Location = new Point(539, 106);
            interf.Name = "interf";
            interf.Size = new Size(174, 249);
            interf.TabIndex = 70;
            interf.TabStop = false;
            // 
            // delete
            // 
            delete.Location = new Point(17, 174);
            delete.Name = "delete";
            delete.Size = new Size(151, 45);
            delete.TabIndex = 8;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 21);
            button1.Name = "button1";
            button1.Size = new Size(151, 45);
            button1.TabIndex = 24;
            button1.Text = "Обновить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += update_Click;
            // 
            // save
            // 
            save.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            save.Location = new Point(17, 123);
            save.Name = "save";
            save.Size = new Size(151, 45);
            save.TabIndex = 10;
            save.Text = "Добавить";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // change
            // 
            change.Location = new Point(17, 72);
            change.Name = "change";
            change.Size = new Size(151, 45);
            change.TabIndex = 9;
            change.Text = "Изменить";
            change.UseVisualStyleBackColor = true;
            change.Click += change_Click;
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
            lable11.Size = new Size(345, 33);
            lable11.TabIndex = 0;
            lable11.Text = "Поставщики";
            lable11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // providersgrid
            // 
            providersgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            providersgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            providersgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            providersgrid.Location = new Point(12, 106);
            providersgrid.Name = "providersgrid";
            providersgrid.RowHeadersWidth = 62;
            providersgrid.Size = new Size(521, 311);
            providersgrid.TabIndex = 45;
            providersgrid.CellClick += providersgrid_CellClick;
            // 
            // Providers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 633);
            Controls.Add(panel1);
            Controls.Add(back);
            Name = "Providers";
            Text = "Providers";
            Load += Providers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            interf.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)providersgrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Panel panel1;
        private Panel panel2;
        private Label lable11;
        private DataGridView providersgrid;
        private Label label3;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private GroupBox interf;
        private Button delete;
        private Button button1;
        private Button save;
        private Button change;
    }
}