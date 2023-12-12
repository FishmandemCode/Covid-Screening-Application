namespace Final_Project
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.report_table = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.report_table)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // report_table
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.report_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.report_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.report_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.report_table.Location = new System.Drawing.Point(13, 52);
            this.report_table.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.report_table.Name = "report_table";
            this.report_table.RowHeadersWidth = 51;
            this.report_table.Size = new System.Drawing.Size(652, 235);
            this.report_table.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.screeningToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(675, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(74, 31);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(77, 31);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // screeningToolStripMenuItem
            // 
            this.screeningToolStripMenuItem.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screeningToolStripMenuItem.Name = "screeningToolStripMenuItem";
            this.screeningToolStripMenuItem.Size = new System.Drawing.Size(112, 31);
            this.screeningToolStripMenuItem.Text = "Screening";
            this.screeningToolStripMenuItem.Click += new System.EventHandler(this.screeningToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(59, 31);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Font = new System.Drawing.Font("Exo Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(66, 31);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 32);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.search_text);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(250, 298);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(71, 27);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(675, 336);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.report_table);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report_table)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView report_table;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Search;
    }
}