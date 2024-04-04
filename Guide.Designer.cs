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
            panel1 = new Panel();
            guidegrid = new DataGridView();
            back = new Button();
            panel2 = new Panel();
            lable11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guidegrid).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(guidegrid);
            panel1.Controls.Add(back);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 633);
            panel1.TabIndex = 1;
            // 
            // guidegrid
            // 
            guidegrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guidegrid.Location = new Point(12, 106);
            guidegrid.Name = "guidegrid";
            guidegrid.RowHeadersWidth = 62;
            guidegrid.Size = new Size(689, 302);
            guidegrid.TabIndex = 3;
            guidegrid.CellContentClick += guidegrid_CellContentClick;
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
            lable11.Text = "Справочник";
            lable11.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guidegrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lable11;
        private Button back;
        private DataGridView guidegrid;
    }
}