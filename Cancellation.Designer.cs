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
            panel1 = new Panel();
            inter2 = new GroupBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            interf = new GroupBox();
            delete = new Button();
            update = new Button();
            save = new Button();
            change = new Button();
            cancelegrid = new DataGridView();
            panel2 = new Panel();
            lable11 = new Label();
            panel1.SuspendLayout();
            inter2.SuspendLayout();
            interf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cancelegrid).BeginInit();
            panel2.SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(inter2);
            panel1.Controls.Add(interf);
            panel1.Controls.Add(cancelegrid);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 599);
            panel1.TabIndex = 1;
            // 
            // inter2
            // 
            inter2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inter2.AutoSize = true;
            inter2.Controls.Add(label3);
            inter2.Controls.Add(textBox2);
            inter2.Controls.Add(textBox1);
            inter2.Controls.Add(label2);
            inter2.Controls.Add(label1);
            inter2.Location = new Point(6, 419);
            inter2.Name = "inter2";
            inter2.Size = new Size(707, 175);
            inter2.TabIndex = 70;
            inter2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 121);
            label3.Name = "label3";
            label3.Size = new Size(185, 24);
            label3.TabIndex = 22;
            label3.Text = "Причина";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(455, 31);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(455, 31);
            textBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 12F, FontStyle.Bold);
            label2.Location = new Point(10, 73);
            label2.Name = "label2";
            label2.Size = new Size(210, 24);
            label2.TabIndex = 15;
            label2.Text = "Название";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 23);
            label1.Name = "label1";
            label1.Size = new Size(213, 33);
            label1.TabIndex = 14;
            label1.Text = "Запись";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // interf
            // 
            interf.Anchor = AnchorStyles.None;
            interf.AutoSize = true;
            interf.Controls.Add(delete);
            interf.Controls.Add(update);
            interf.Controls.Add(save);
            interf.Controls.Add(change);
            interf.Location = new Point(539, 106);
            interf.Name = "interf";
            interf.Size = new Size(174, 249);
            interf.TabIndex = 69;
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
            // update
            // 
            update.Location = new Point(17, 21);
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
            // cancelegrid
            // 
            cancelegrid.AllowUserToAddRows = false;
            cancelegrid.AllowUserToDeleteRows = false;
            cancelegrid.AllowUserToResizeColumns = false;
            cancelegrid.AllowUserToResizeRows = false;
            cancelegrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cancelegrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cancelegrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cancelegrid.Location = new Point(12, 106);
            cancelegrid.Name = "cancelegrid";
            cancelegrid.RowHeadersWidth = 62;
            cancelegrid.Size = new Size(521, 311);
            cancelegrid.TabIndex = 13;
            cancelegrid.CellClick += cancelegrid_CellClick;
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
            lable11.Location = new Point(219, 29);
            lable11.Name = "lable11";
            lable11.Size = new Size(279, 33);
            lable11.TabIndex = 0;
            lable11.Text = "Списание";
            lable11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cancellation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 633);
            Controls.Add(panel1);
            Controls.Add(back);
            Name = "Cancellation";
            Text = "Cancellation";
            Load += Cancellation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            inter2.ResumeLayout(false);
            inter2.PerformLayout();
            interf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cancelegrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Panel panel1;
        private Panel panel2;
        private Label lable11;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private DataGridView cancelegrid;
        private Label label3;
        private GroupBox inter2;
        private GroupBox interf;
        private Button delete;
        private Button update;
        private Button save;
        private Button change;
    }
}