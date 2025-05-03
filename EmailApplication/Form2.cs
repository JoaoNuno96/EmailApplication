using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmailApplication.Models.Entities;

namespace EmailApplication
{
    public partial class Form2 : Form
    {
        public User UserAuth { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void view_user_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"EMAIL: {this.UserAuth.Email}\nPASSWORD: {this.UserAuth.Password}");
        }
    }
}
