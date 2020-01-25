using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Import the Material Skin
using MaterialSkin;
using MaterialSkin.Controls;



namespace MyShedule
{
    partial class Login : MaterialForm
    {   
        public Login()
        {
            InitializeComponent();

            // Create a material theme
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configuring color theme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple900, Primary.DeepPurple700,
                Primary.DeepPurple400, Accent.Purple400,
                TextShade.WHITE
            );
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            login(txtUserName.Text,txtPassword.Text);
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals(@"Username")) 
            {
                txtUserName.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals(""))
            {
                txtUserName.Text = "Username";
            }
        }

        private void txtPasswordEnter(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals(@"Password"))
            {
                txtUserName.Text = "";
            }
        }

        private void txtPasswordLeave(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals(""))
            {
                txtUserName.Text = "Password";
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
