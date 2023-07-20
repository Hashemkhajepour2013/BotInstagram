using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
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
    }
}
