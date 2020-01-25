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
    public partial class Register : MaterialForm
    {
        public Register()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey700, Primary.BlueGrey500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text==""||txtPassword.Text==""||txtPassword.Text==""||txtConfPassword.Text=="") 
            {
                MessageBox.Show("Plase Insert All the Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtConfPassword.Text!=txtPassword.Text) 
            {
                MessageBox.Show("Entered passwords are not matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            register(txtUsername.Text, txtPassword.Text, dtpBirthday.Value, int.Parse(lbSleepHours.SelectedItem.ToString()) );
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            dtpBirthday.MaxDate = DateTime.Now.AddYears(-12);
            lbSleepHours.SelectedIndex = 0;
        }

        private void txtConfPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPassword.Text != txtConfPassword.Text)
            {
                lblConfPassword.ForeColor = Color.Red;
            }
            else 
            {
                lblConfPassword.ForeColor = Color.Black;
            }
        }
    }
}
