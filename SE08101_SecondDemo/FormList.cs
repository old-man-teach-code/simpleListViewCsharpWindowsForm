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

        User[] listUser;

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

            listUser = new User[3];

            listUser[0] = new User();
            listUser[0].Id = 1;
            listUser[0].Name = "linhhn13";
            listUser[0].Password = "123";
            listUser[0].Role = "Admin";

            listUser[1] = new User();
            listUser[1].Id = 2;
            listUser[1].Name = "quandt14";
            listUser[1].Password = "123";
            listUser[1].Role = "User";

            listUser[2] = new User();
            listUser[2].Id = 3;
            listUser[2].Name = "thanhnt15";
            listUser[2].Password = "123";
            listUser[2].Role = "User";

           
            showData();
        }

        private void showData()
        {
            List<ListViewItem> listRow = new List<ListViewItem>();

            int Index = 1;

            for (int i = 0; i < listUser.Length; i++)
            {
                ListViewItem row = new ListViewItem(listUser[i].Id.ToString(), Index);
                row.SubItems.Add(listUser[i].Name);
                row.SubItems.Add(listUser[i].Password);
                row.SubItems.Add(listUser[i].Role);
                listRow.Add(row);
                Index++;
            }

            lvUser.Items.AddRange(listRow.ToArray());
        }
    }
}
