namespace Assignment_4._1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobileNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personBindingSource = new BindingSource(components);
            button1 = new Button();
            txtBoxFirstName = new TextBox();
            txtBoxLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSearchResult = new Label();
            btnShowAll = new Button();
            btnAddRecord = new Button();
            btnDeleteRecord = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtBoxUpdateFName = new TextBox();
            txtBoxUpdateLName = new TextBox();
            txtBoxUpdateAddress = new TextBox();
            txtBoxUpdateMobile = new TextBox();
            txtBoxUpdateWork = new TextBox();
            lblUpdateMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, mobileNumberDataGridViewTextBoxColumn, workNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn });
            dataGridView1.DataSource = personBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(760, 188);
            dataGridView1.TabIndex = 0;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
            mobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber";
            mobileNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            mobileNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // workNumberDataGridViewTextBoxColumn
            // 
            workNumberDataGridViewTextBoxColumn.DataPropertyName = "WorkNumber";
            workNumberDataGridViewTextBoxColumn.HeaderText = "WorkNumber";
            workNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            workNumberDataGridViewTextBoxColumn.Name = "workNumberDataGridViewTextBoxColumn";
            workNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Person);
            // 
            // button1
            // 
            button1.Location = new Point(277, 237);
            button1.Name = "button1";
            button1.Size = new Size(82, 62);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(121, 237);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(150, 27);
            txtBoxFirstName.TabIndex = 2;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(121, 270);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(150, 27);
            txtBoxLastName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 244);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 275);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 214);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 6;
            label3.Text = "Search or Delete";
            // 
            // lblSearchResult
            // 
            lblSearchResult.AutoSize = true;
            lblSearchResult.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchResult.Location = new Point(121, 300);
            lblSearchResult.Name = "lblSearchResult";
            lblSearchResult.Size = new Size(150, 31);
            lblSearchResult.TabIndex = 8;
            lblSearchResult.Text = "Search Result";
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(378, 240);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(116, 59);
            btnShowAll.TabIndex = 9;
            btnShowAll.Text = "Show All Records";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Location = new Point(395, 415);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(110, 30);
            btnAddRecord.TabIndex = 10;
            btnAddRecord.Text = "Add Record";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.BackColor = Color.Red;
            btnDeleteRecord.ForeColor = SystemColors.HighlightText;
            btnDeleteRecord.Location = new Point(138, 351);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(110, 30);
            btnDeleteRecord.TabIndex = 11;
            btnDeleteRecord.Text = "Delete Record";
            btnDeleteRecord.UseVisualStyleBackColor = false;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(589, 216);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 12;
            label4.Text = "Add Record";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(511, 244);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 13;
            label5.Text = "First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(511, 277);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 14;
            label6.Text = "Last Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(511, 311);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 15;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(511, 351);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 16;
            label8.Text = "Mobile#";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(511, 384);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 17;
            label9.Text = "Work#";
            // 
            // txtBoxUpdateFName
            // 
            txtBoxUpdateFName.Location = new Point(616, 244);
            txtBoxUpdateFName.Name = "txtBoxUpdateFName";
            txtBoxUpdateFName.Size = new Size(125, 27);
            txtBoxUpdateFName.TabIndex = 18;
            // 
            // txtBoxUpdateLName
            // 
            txtBoxUpdateLName.Location = new Point(616, 277);
            txtBoxUpdateLName.Name = "txtBoxUpdateLName";
            txtBoxUpdateLName.Size = new Size(125, 27);
            txtBoxUpdateLName.TabIndex = 19;
            // 
            // txtBoxUpdateAddress
            // 
            txtBoxUpdateAddress.Location = new Point(616, 311);
            txtBoxUpdateAddress.Name = "txtBoxUpdateAddress";
            txtBoxUpdateAddress.Size = new Size(125, 27);
            txtBoxUpdateAddress.TabIndex = 20;
            // 
            // txtBoxUpdateMobile
            // 
            txtBoxUpdateMobile.Location = new Point(616, 344);
            txtBoxUpdateMobile.Name = "txtBoxUpdateMobile";
            txtBoxUpdateMobile.Size = new Size(125, 27);
            txtBoxUpdateMobile.TabIndex = 21;
            // 
            // txtBoxUpdateWork
            // 
            txtBoxUpdateWork.Location = new Point(616, 381);
            txtBoxUpdateWork.Name = "txtBoxUpdateWork";
            txtBoxUpdateWork.Size = new Size(125, 27);
            txtBoxUpdateWork.TabIndex = 22;
            // 
            // lblUpdateMessage
            // 
            lblUpdateMessage.AutoSize = true;
            lblUpdateMessage.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpdateMessage.Location = new Point(511, 411);
            lblUpdateMessage.Name = "lblUpdateMessage";
            lblUpdateMessage.Size = new Size(187, 31);
            lblUpdateMessage.TabIndex = 23;
            lblUpdateMessage.Text = "Update Message";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUpdateMessage);
            Controls.Add(txtBoxUpdateWork);
            Controls.Add(txtBoxUpdateMobile);
            Controls.Add(txtBoxUpdateAddress);
            Controls.Add(txtBoxUpdateLName);
            Controls.Add(txtBoxUpdateFName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnDeleteRecord);
            Controls.Add(btnAddRecord);
            Controls.Add(btnShowAll);
            Controls.Add(lblSearchResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxLastName);
            Controls.Add(txtBoxFirstName);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource personBindingSource;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private Button button1;
        private TextBox txtBoxFirstName;
        private TextBox txtBoxLastName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSearchResult;
        private Button btnShowAll;
        private Button btnAddRecord;
        private Button btnDeleteRecord;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtBoxUpdateFName;
        private TextBox txtBoxUpdateLName;
        private TextBox txtBoxUpdateAddress;
        private TextBox txtBoxUpdateMobile;
        private TextBox txtBoxUpdateWork;
        private Label lblUpdateMessage;
    }
}
