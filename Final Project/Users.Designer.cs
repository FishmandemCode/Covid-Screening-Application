namespace Final_Project
{
    partial class Users
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
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label usertypeLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.databaseDataSet = new Final_Project.DatabaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Final_Project.DatabaseDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new Final_Project.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.usertypeComboBox = new System.Windows.Forms.ComboBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.exit_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            studentIDLabel = new System.Windows.Forms.Label();
            usertypeLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Font = new System.Drawing.Font("Exo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            studentIDLabel.Location = new System.Drawing.Point(110, 91);
            studentIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(34, 27);
            studentIDLabel.TabIndex = 2;
            studentIDLabel.Text = "ID:";
            // 
            // usertypeLabel
            // 
            usertypeLabel.AutoSize = true;
            usertypeLabel.Font = new System.Drawing.Font("Exo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usertypeLabel.Location = new System.Drawing.Point(52, 171);
            usertypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usertypeLabel.Name = "usertypeLabel";
            usertypeLabel.Size = new System.Drawing.Size(96, 27);
            usertypeLabel.TabIndex = 6;
            usertypeLabel.Text = "Usertype:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Exo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.Location = new System.Drawing.Point(44, 133);
            usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(106, 27);
            usernameLabel.TabIndex = 7;
            usernameLabel.Text = "Username:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ScreeningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_Project.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "StudentID", true));
            this.studentIDTextBox.Font = new System.Drawing.Font("Exo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTextBox.Location = new System.Drawing.Point(165, 86);
            this.studentIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(132, 32);
            this.studentIDTextBox.TabIndex = 3;
            // 
            // usertypeComboBox
            // 
            this.usertypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Usertype", true));
            this.usertypeComboBox.Font = new System.Drawing.Font("Exo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertypeComboBox.FormattingEnabled = true;
            this.usertypeComboBox.Location = new System.Drawing.Point(165, 167);
            this.usertypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.usertypeComboBox.Name = "usertypeComboBox";
            this.usertypeComboBox.Size = new System.Drawing.Size(132, 35);
            this.usertypeComboBox.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Username", true));
            this.usernameTextBox.Font = new System.Drawing.Font("Exo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(165, 126);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(132, 32);
            this.usernameTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Exo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(164, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.update_btn);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Exo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(115, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Screening";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.scr_display);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Exo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(-3, 1);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 48);
            this.button3.TabIndex = 11;
            this.button3.Text = "Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.usr_btn);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UserFlagged";
            this.dataGridViewTextBoxColumn4.HeaderText = "UserFlagged";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Usertype";
            this.dataGridViewTextBoxColumn3.HeaderText = "Usertype";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Exo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Exo Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.usersDataGridView.Location = new System.Drawing.Point(331, 1);
            this.usersDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.usersDataGridView.Name = "usersDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.Size = new System.Drawing.Size(728, 326);
            this.usersDataGridView.TabIndex = 1;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Black;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_btn.Font = new System.Drawing.Font("Exo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(232, 2);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(91, 47);
            this.exit_btn.TabIndex = 12;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Exo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(23, 210);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 47);
            this.button4.TabIndex = 13;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Exo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(23, 265);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 47);
            this.button5.TabIndex = 14;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.delete_btn);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Exo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(164, 265);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 47);
            this.button6.TabIndex = 15;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.reset_btn);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1060, 320);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(usertypeLabel);
            this.Controls.Add(this.usertypeComboBox);
            this.Controls.Add(studentIDLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.usersDataGridView);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.ComboBox usertypeComboBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}