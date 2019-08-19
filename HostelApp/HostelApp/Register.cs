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
    public partial class Register : Form
    {
        HostelAppEntities db = new HostelAppEntities();
        public Register()
        {
            InitializeComponent();
        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string[] checkedInput = new string[] { fullname, email, phone, password, confirmPassword };
            if (Extension.CheckInput(checkedInput, string.Empty))
            {
                lblError.Visible = false;
                if(phone.Length < 15)
                {
                    if(password.Length > 8)
                    {
                        if(password==confirmPassword)
                        {
                            Admin ad = db.Admin.FirstOrDefault(a => a.Email == email);
                            if(ad == null)
                            {
                                db.Admin.Add(new Admin()
                                {
                                    Email = email,
                                    Password = password.HashMe(),                        
                                });
                                db.SaveChanges();
                                MessageBox.Show("Client was succesfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                lblError.Text = "Email already exist";
                                lblError.Visible = true;
                            }
                        }
                            
                           

                        else
                        {
                            lblError.Text = "Password and Confirm password not matching";
                            lblError.Visible = true;
                        }
                    }
                    else
                    {
                        lblError.Text = "Password should be not less than 8 characters";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "Phone number should be not more than 15 characters";
                    lblError.Visible = true;
                }
                
            }
            else
            {
                lblError.Text = "Please all the fill";
                lblError.Visible = true;
            }
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }
    }
}
