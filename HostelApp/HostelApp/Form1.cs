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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWelcome.Text="Welcome to our Hotel";
            pcImage.Image = new Bitmap(@"C:\Users\Zver\source\repos\HostelApp\HostelApp\image\hotel.jpg");
            pcImage.Location = new Point((this.ClientSize.Width - pcImage.Size.Width) / 2,
                (this.ClientSize.Height - pcImage.Size.Height) / 2);

            lblWelcome.Location = new Point((this.ClientSize.Width - lblWelcome.Size.Width) / 2,
                (this.ClientSize.Height - lblWelcome.Size.Height)/4);

           

           

        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
        }
    }
}
