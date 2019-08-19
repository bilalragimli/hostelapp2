using HostelApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelApp
{
    public partial class Login : Form
    {
        HostelAppEntities db = new HostelAppEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (Extension.CheckInput(new string[] { email, password }, string.Empty))
            {
                Admin allready = db.Admin.FirstOrDefault(ad => ad.Email == email);
                if (allready != null)
                {
                    if (allready.Password == password.HashMe())
                    {
                        lblError.Visible = false;
                        Dashboard dash = new Dashboard();
                        dash.activeAdmin = allready;
                        dash.ShowDialog();
                    }
                    else
                    {
                        lblError.Text = "Password is not correct";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "Email is not correct";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Please all the fill";
                lblError.Visible = false;
            }
        }
    }
}
