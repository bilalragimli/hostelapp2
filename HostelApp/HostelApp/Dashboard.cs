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
    public partial class Dashboard : Form
    {
        public Admin activeAdmin;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbldash.Text = activeAdmin.Email;
        }
    }
}
