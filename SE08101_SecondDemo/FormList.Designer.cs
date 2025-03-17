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
            SuspendLayout();
            // 
            // lvUser
            // 
            lvUser.AllowColumnReorder = true;
            lvUser.Columns.AddRange(new ColumnHeader[] { Id, Username, Password, Role });
            lvUser.FullRowSelect = true;
            lvUser.GridLines = true;
            lvUser.Location = new Point(31, 87);
            lvUser.Name = "lvUser";
            lvUser.Size = new Size(1877, 661);
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
            // FormList
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2128, 895);
            Controls.Add(lvUser);
            Name = "FormList";
            Text = "FormList";
            FormClosed += FormList_FormClosed;
            Load += FormList_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvUser;
        private ColumnHeader Id;
        private ColumnHeader Username;
        private ColumnHeader Password;
        private ColumnHeader Role;
    }
}