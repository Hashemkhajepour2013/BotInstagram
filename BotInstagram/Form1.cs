using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using System.IO;
using System.Windows.Forms;

namespace BotInstagram
{
    public partial class frmMain : Form
    {
        private static UserSessionData user;

        public frmMain()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, System.EventArgs e)
        {
            user = new UserSessionData();
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;

            Ctx.api = InstaApiBuilder.CreateBuilder()
                .SetUser(user)
                .UseLogger(new DebugLogger(LogLevel.All))
                .SetRequestDelay(RequestDelay.FromSeconds(0, 1))
                .Build();

            var loginRequest = await Ctx.api.LoginAsync();

            if(loginRequest.Succeeded)
            {
                gbLogin.Enabled = false;
                gbCommand.Enabled = true;
                pcImage.Load(Ctx.api.GetLoggedUser().LoggedInUser.ProfilePicUrl);
            }
            else
            {
                MessageBox.Show("Login Field .... \n" + 
                    loginRequest.Info.Message);
            }
        }

        private void btnEditProfile_Click(object sender, System.EventArgs e)
        {
            (new frmEditProfile()).ShowDialog();
        }

        private async void btnDeletePic_Click(object sender, System.EventArgs e)
        {
            var result = await Ctx.api.AccountProcessor.RemoveProfilePictureAsync();
            if(result.Succeeded)
            {
                pcImage.Image = null;
            }
        }

        private async void btnEditPic_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog() == DialogResult.OK)
            {
                var picByte = File.ReadAllBytes(op.FileName);
                var result =  await
Ctx.api.AccountProcessor.ChangeProfilePictureAsync(picByte);
                if (result.Succeeded)
                {
                    pcImage.ImageLocation = op.FileName; 
                }
            }
        }
    }
}
