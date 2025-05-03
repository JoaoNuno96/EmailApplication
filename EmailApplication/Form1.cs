using EmailApplication.Models.Entities;
using EmailApplication.Models.Service;

namespace EmailApplication
{
    public partial class Form1 : Form
    {
        public Form2 Form2 { get; set; }
        public Form1()
        {
            InitializeComponent();
        }


        private void enviar_Click(object sender, EventArgs e)
        {
            User userAuth = new User
            {
                Email = this.email_input.Text,
                Password = this.destination_input.Text
            };

            if (Form2 == null || Form2.IsDisposed)
            {
                Form2 = new Form2();
            }

            bool statusEmailCredents = LogInService.TryToLogin(userAuth);

            if (statusEmailCredents)
            {
                MessageBox.Show("USER AUTH");
            }
            else
            {
                MessageBox.Show("USER NOT AUTH");
            }


            //Form2.UserAuth = userAuth;
            //Form2.Show();
            //this.Close();
        }

    }
}
