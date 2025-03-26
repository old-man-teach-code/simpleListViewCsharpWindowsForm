namespace SE08101_SecondDemo
{
    partial class FormList
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
            lvUser = new ListView();
            Id = new ColumnHeader();
            Username = new ColumnHeader();
            Password = new ColumnHeader();
            Role = new ColumnHeader();
            Money = new ColumnHeader();
            tbUserID = new TextBox();
            tbUsername = new TextBox();
            tbUserPassword = new TextBox();
            tbUserRole = new TextBox();
            btnAdd = new Button();
            tbDeleteUserById = new TextBox();
            btnDeleteUserById = new Button();
            tbSearchId = new TextBox();
            btnSearch = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // lvUser
            // 
            lvUser.AllowColumnReorder = true;
            lvUser.Columns.AddRange(new ColumnHeader[] { Id, Username, Password, Role, Money });
            lvUser.FullRowSelect = true;
            lvUser.GridLines = true;
            lvUser.Location = new Point(31, 113);
            lvUser.Name = "lvUser";
            lvUser.Size = new Size(1419, 661);
            lvUser.TabIndex = 0;
            lvUser.UseCompatibleStateImageBehavior = false;
            lvUser.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // Username
            // 
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.Text = "Password";
            // 
            // Role
            // 
            Role.Text = "Role";
            // 
            // Money
            // 
            Money.Text = "Money";
            // 
            // tbUserID
            // 
            tbUserID.Location = new Point(1516, 210);
            tbUserID.Name = "tbUserID";
            tbUserID.Size = new Size(491, 55);
            tbUserID.TabIndex = 1;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(1516, 320);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(491, 55);
            tbUsername.TabIndex = 2;
            // 
            // tbUserPassword
            // 
            tbUserPassword.Location = new Point(1516, 423);
            tbUserPassword.Name = "tbUserPassword";
            tbUserPassword.Size = new Size(491, 55);
            tbUserPassword.TabIndex = 3;
            // 
            // tbUserRole
            // 
            tbUserRole.Location = new Point(1516, 536);
            tbUserRole.Name = "tbUserRole";
            tbUserRole.Size = new Size(491, 55);
            tbUserRole.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1516, 658);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(223, 69);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbDeleteUserById
            // 
            tbDeleteUserById.Location = new Point(31, 804);
            tbDeleteUserById.Name = "tbDeleteUserById";
            tbDeleteUserById.Size = new Size(300, 55);
            tbDeleteUserById.TabIndex = 6;
            // 
            // btnDeleteUserById
            // 
            btnDeleteUserById.Location = new Point(354, 804);
            btnDeleteUserById.Name = "btnDeleteUserById";
            btnDeleteUserById.Size = new Size(225, 69);
            btnDeleteUserById.TabIndex = 7;
            btnDeleteUserById.Text = "Delete User";
            btnDeleteUserById.UseVisualStyleBackColor = true;
            btnDeleteUserById.Click += btnDeleteUserById_Click;
            // 
            // tbSearchId
            // 
            tbSearchId.Location = new Point(496, 36);
            tbSearchId.Name = "tbSearchId";
            tbSearchId.Size = new Size(491, 55);
            tbSearchId.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1012, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(438, 69);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1767, 658);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(240, 69);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update User";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormList
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2128, 895);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(tbSearchId);
            Controls.Add(btnDeleteUserById);
            Controls.Add(tbDeleteUserById);
            Controls.Add(btnAdd);
            Controls.Add(tbUserRole);
            Controls.Add(tbUserPassword);
            Controls.Add(tbUsername);
            Controls.Add(tbUserID);
            Controls.Add(lvUser);
            Name = "FormList";
            Text = "FormList";
            FormClosed += FormList_FormClosed;
            Load += FormList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvUser;
        private ColumnHeader Id;
        private ColumnHeader Username;
        private ColumnHeader Password;
        private ColumnHeader Role;
        private TextBox tbUserID;
        private TextBox tbUsername;
        private TextBox tbUserPassword;
        private TextBox tbUserRole;
        private Button btnAdd;
        private ColumnHeader Money;
        private TextBox tbDeleteUserById;
        private Button btnDeleteUserById;
        private TextBox tbSearchId;
        private Button btnSearch;
        private Button btnUpdate;
    }
}