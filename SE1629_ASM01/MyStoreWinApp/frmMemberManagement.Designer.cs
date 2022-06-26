namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbUserEmail = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lbFilterCity = new System.Windows.Forms.Label();
            this.lbFilterCountry = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMembers
            // 
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(189, 243);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 29;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(550, 251);
            this.dgvMembers.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(152, 85);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(155, 27);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 173);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(155, 27);
            this.txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(401, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(155, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(401, 173);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(155, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(645, 83);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(155, 27);
            this.txtCity.TabIndex = 5;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(645, 172);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(155, 27);
            this.txtCountry.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(10, 269);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(155, 29);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(10, 375);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 29);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.AutoSize = true;
            this.lbUserEmail.Location = new System.Drawing.Point(23, 9);
            this.lbUserEmail.Name = "lbUserEmail";
            this.lbUserEmail.Size = new System.Drawing.Size(50, 20);
            this.lbUserEmail.TabIndex = 9;
            this.lbUserEmail.Text = "label1";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(48, 85);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 20);
            this.lbID.TabIndex = 10;
            this.lbID.Text = "ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(48, 177);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 20);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Name";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(335, 88);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(325, 173);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 13;
            this.lbPassword.Text = "Password";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(587, 85);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 14;
            this.lbCity.Text = "City";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(578, 173);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 15;
            this.lbCountry.Text = "Country";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(325, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(297, 27);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(205, 15);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(117, 20);
            this.lbSearch.TabIndex = 17;
            this.lbSearch.Text = "Search By Name";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(10, 431);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(155, 29);
            this.btnSort.TabIndex = 18;
            this.btnSort.Text = "Sort By Name Desc";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(10, 321);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 31);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboCity
            // 
            this.cboCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(771, 243);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(151, 28);
            this.cboCity.TabIndex = 20;
            // 
            // cboCountry
            // 
            this.cboCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(771, 336);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(151, 28);
            this.cboCountry.TabIndex = 21;
            // 
            // lbFilterCity
            // 
            this.lbFilterCity.AutoSize = true;
            this.lbFilterCity.Location = new System.Drawing.Point(820, 220);
            this.lbFilterCity.Name = "lbFilterCity";
            this.lbFilterCity.Size = new System.Drawing.Size(34, 20);
            this.lbFilterCity.TabIndex = 22;
            this.lbFilterCity.Text = "City";
            // 
            // lbFilterCountry
            // 
            this.lbFilterCountry.AutoSize = true;
            this.lbFilterCountry.Location = new System.Drawing.Point(810, 313);
            this.lbFilterCountry.Name = "lbFilterCountry";
            this.lbFilterCountry.Size = new System.Drawing.Size(60, 20);
            this.lbFilterCountry.TabIndex = 23;
            this.lbFilterCountry.Text = "Country";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(795, 405);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(94, 29);
            this.btnFilter.TabIndex = 24;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(325, 526);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(94, 29);
            this.btnReload.TabIndex = 25;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(528, 526);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 587);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lbFilterCountry);
            this.Controls.Add(this.lbFilterCity);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbUserEmail);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvMembers);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMembers;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btnInsert;
        private Button btnDelete;
        private Label lbUserEmail;
        private Label lbID;
        private Label lbName;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbCity;
        private Label lbCountry;
        private TextBox txtSearch;
        private Label lbSearch;
        private Button btnSort;
        private Button btnUpdate;
        private ComboBox cboCity;
        private ComboBox cboCountry;
        private Label lbFilterCity;
        private Label lbFilterCountry;
        private Button btnFilter;
        private Button btnReload;
        private Button btnClose;
    }
}