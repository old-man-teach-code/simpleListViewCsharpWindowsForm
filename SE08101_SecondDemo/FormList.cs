using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE08101_SecondDemo
{
    public partial class FormList : Form
    {

        User[] listUser = new User[100];
        int ListUserLength = 0;

        public FormList()
        {
            InitializeComponent();
        }

        private void FormList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppData.LoginState = false;
        }

        private void FormList_Load(object sender, EventArgs e)
        {

            ListUserLength = 3;

            listUser[0] = new User();
            listUser[0].Id = 1;
            listUser[0].Name = "linhhn13";
            listUser[0].Password = "123";
            listUser[0].Role = "Admin";
            listUser[0].Money = calculateMoney(1);

            listUser[1] = new User();
            listUser[1].Id = 2;
            listUser[1].Name = "quandt14";
            listUser[1].Password = "123";
            listUser[1].Role = "User";
            listUser[1].Money = calculateMoney(2);

            listUser[2] = new User();
            listUser[2].Id = 3;
            listUser[2].Name = "thanhnt15";
            listUser[2].Password = "123";
            listUser[2].Role = "User";
            listUser[2].Money = calculateMoney(3);


            showData();
        }

        private void showData()
        {
            lvUser.Items.Clear();

            List<ListViewItem> listRow = new List<ListViewItem>();

            int Index = 1;

            for (int i = 0; i < ListUserLength; i++)
            {
                ListViewItem row = new ListViewItem(listUser[i].Id.ToString(), Index);
                row.SubItems.Add(listUser[i].Name);
                row.SubItems.Add(listUser[i].Password);
                row.SubItems.Add(listUser[i].Role);
                row.SubItems.Add(listUser[i].Money.ToString());
                listRow.Add(row);
                Index++;
            }

            lvUser.Items.AddRange(listRow.ToArray());
        }

        private int calculateMoney(int ID)
        {
            return 100000 * ID; // example
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int UserId = Convert.ToInt32(tbUserID.Text);
            string UserName = tbUsername.Text;
            string UserPassword = tbUserPassword.Text;
            string UserRole = tbUserRole.Text;

            User NewUser = new User();
            NewUser.Id = UserId;
            NewUser.Name = UserName;
            NewUser.Password = UserPassword;
            NewUser.Role = UserRole;
            NewUser.Money = calculateMoney(UserId);


            if (ListUserLength < 100)
            {
                listUser[ListUserLength] = NewUser;
                ListUserLength++;
            }
            showData();
        }

        private void btnDeleteUserById_Click(object sender, EventArgs e)
        {
            int DeleteUserId = Convert.ToInt32(tbDeleteUserById.Text);

            for (int i = 0; i < ListUserLength; i++)
            {
                if (listUser[i].Id == DeleteUserId)
                {
                    for (int j = i; j < ListUserLength - 1; j++)
                    {
                        listUser[j] = listUser[j + 1];
                    }
                    ListUserLength--;
                    break;
                }
            }
            showData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int SearchId = Convert.ToInt32(tbSearchId.Text);

            for (int i = 0; i < ListUserLength; i++)
            {
                if (listUser[i].Id == SearchId)
                {
                    tbUserID.Text = listUser[i].Id.ToString();
                    tbUsername.Text = listUser[i].Name;
                    tbUserPassword.Text = listUser[i].Password;
                    tbUserRole.Text = listUser[i].Role;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListUserLength; i++)
            {
                if (listUser[i].Id == Convert.ToInt32(tbUserID.Text))
                {
                    listUser[i].Name = tbUsername.Text;
                    listUser[i].Password = tbUserPassword.Text;
                    listUser[i].Role = tbUserRole.Text;
                    listUser[i].Money = calculateMoney(listUser[i].Id);
                    break;
                }
            }
            showData();
        }
    }
}
