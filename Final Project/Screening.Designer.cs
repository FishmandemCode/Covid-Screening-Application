namespace Final_Project
{
    partial class screen_form
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
            this.id_choice = new System.Windows.Forms.ComboBox();
            this.databaseDataSet = new Final_Project.DatabaseDataSet();
            this.screeningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.screeningTableAdapter = new Final_Project.DatabaseDataSetTableAdapters.ScreeningTableAdapter();
            this.tableAdapterManager = new Final_Project.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.ScreeningID = new System.Windows.Forms.TextBox();
            this.Name_Txt = new System.Windows.Forms.TextBox();
            this.Close_Contact = new System.Windows.Forms.ComboBox();
            this.Travel = new System.Windows.Forms.ComboBox();
            this.Symtoms = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Final_Project.DatabaseDataSetTableAdapters.UsersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.date_pick = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.report = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screeningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_choice
            // 
            this.id_choice.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_choice.FormattingEnabled = true;
            this.id_choice.Location = new System.Drawing.Point(21, 57);
            this.id_choice.Name = "id_choice";
            this.id_choice.Size = new System.Drawing.Size(168, 29);
            this.id_choice.TabIndex = 0;
            this.id_choice.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // screeningBindingSource
            // 
            this.screeningBindingSource.DataMember = "Screening";
            this.screeningBindingSource.DataSource = this.databaseDataSet;
            // 
            // screeningTableAdapter
            // 
            this.screeningTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ScreeningTableAdapter = this.screeningTableAdapter;
            this.tableAdapterManager.UpdateOrder = Final_Project.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // ScreeningID
            // 
            this.ScreeningID.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreeningID.Location = new System.Drawing.Point(232, 59);
            this.ScreeningID.Name = "ScreeningID";
            this.ScreeningID.Size = new System.Drawing.Size(110, 27);
            this.ScreeningID.TabIndex = 2;
            // 
            // Name_Txt
            // 
            this.Name_Txt.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Txt.Location = new System.Drawing.Point(232, 117);
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Size = new System.Drawing.Size(110, 27);
            this.Name_Txt.TabIndex = 3;
            // 
            // Close_Contact
            // 
            this.Close_Contact.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Contact.FormattingEnabled = true;
            this.Close_Contact.Location = new System.Drawing.Point(134, 160);
            this.Close_Contact.Name = "Close_Contact";
            this.Close_Contact.Size = new System.Drawing.Size(55, 29);
            this.Close_Contact.TabIndex = 8;
            // 
            // Travel
            // 
            this.Travel.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Travel.FormattingEnabled = true;
            this.Travel.Location = new System.Drawing.Point(134, 195);
            this.Travel.Name = "Travel";
            this.Travel.Size = new System.Drawing.Size(55, 29);
            this.Travel.TabIndex = 9;
            // 
            // Symtoms
            // 
            this.Symtoms.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symtoms.FormattingEnabled = true;
            this.Symtoms.Location = new System.Drawing.Point(134, 230);
            this.Symtoms.Name = "Symtoms";
            this.Symtoms.Size = new System.Drawing.Size(55, 29);
            this.Symtoms.TabIndex = 10;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.databaseDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(232, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Verify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.verify_btn);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(232, 227);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(35, 32);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // date_pick
            // 
            this.date_pick.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_pick.Location = new System.Drawing.Point(21, 115);
            this.date_pick.Name = "date_pick";
            this.date_pick.Size = new System.Drawing.Size(168, 27);
            this.date_pick.TabIndex = 13;
            this.date_pick.Value = new System.DateTime(2022, 8, 14, 0, 0, 0, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.forceEditToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(376, 29);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // forceEditToolStripMenuItem
            // 
            this.forceEditToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.forceEditToolStripMenuItem.Name = "forceEditToolStripMenuItem";
            this.forceEditToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.forceEditToolStripMenuItem.Text = "Force Edit";
            this.forceEditToolStripMenuItem.Click += new System.EventHandler(this.forceEditToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Close Contacts: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Travel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Symtoms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Screening ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID Select:";
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.Black;
            this.report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.report.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.Color.White;
            this.report.Location = new System.Drawing.Point(22, 274);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(287, 46);
            this.report.TabIndex = 22;
            this.report.Text = "";
            // 
            // screen_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(376, 341);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_pick);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Symtoms);
            this.Controls.Add(this.Travel);
            this.Controls.Add(this.Close_Contact);
            this.Controls.Add(this.Name_Txt);
            this.Controls.Add(this.ScreeningID);
            this.Controls.Add(this.id_choice);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.report);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "screen_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screening";
            this.Load += new System.EventHandler(this.Screening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screeningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox id_choice;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource screeningBindingSource;
        private DatabaseDataSetTableAdapters.ScreeningTableAdapter screeningTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ScreeningID;
        private System.Windows.Forms.TextBox Name_Txt;
        private System.Windows.Forms.ComboBox Close_Contact;
        private System.Windows.Forms.ComboBox Travel;
        private System.Windows.Forms.ComboBox Symtoms;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker date_pick;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox report;
        private System.Windows.Forms.ToolStripMenuItem forceEditToolStripMenuItem;
    }
}