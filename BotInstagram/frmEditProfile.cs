using InstagramApiSharp.Enums;
using System;
using System.Windows.Forms;

namespace BotInstagram
{
    public partial class frmEditProfile : Form
    {
        public frmEditProfile()
        {
            InitializeComponent();
        }

        private async void frmEditProfile_Load(object sender, EventArgs e)
        {
            var editProfile = await
                Ctx.api.AccountProcessor.GetRequestForEditProfileAsync();

            if (editProfile.Succeeded)
            {
                txtBio.Text = editProfile.Value.Biography;
                txtEmail.Text = editProfile.Value.Email;
                txtMobile.Text = editProfile.Value.PhoneNumber;
                txtName.Text = editProfile.Value.FullName;
                txtSite.Text = editProfile.Value.ExternalLynxUrl;
                txtUserName.Text = editProfile.Value.Username;
                if (editProfile.Value.Gender == InstaGenderType.Male)
                    rbMale.Checked = true;
                else
                {
                    rbFemale.Checked = true;
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var edit = await Ctx.api.AccountProcessor.EditProfileAsync(
                txtName.Text,
                txtBio.Text,
                txtSite.Text,
                txtEmail.Text,
                txtMobile.Text,
                (rbMale.Checked)?InstaGenderType.Male : InstaGenderType.Female,
                txtUserName.Text);
            if(edit.Succeeded)
            {
                MessageBox.Show("با موفقیت انجام شد.");
                this.Close();
            }
        }
    }
}
