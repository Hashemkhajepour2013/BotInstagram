using InstagramApiSharp;
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

        private async void btnFollowers_Click(object sender, System.EventArgs e)
        {
            var followers = await Ctx.api.UserProcessor
                .GetCurrentUserFollowersAsync(PaginationParameters.MaxPagesToLoad(1));
            foreach(var follower in followers.Value)
            {
                dgbFollowers.Rows.Add(follower.UserName, follower.FullName);
            }
        }

        private async void btnFollowing_Click(object sender, System.EventArgs e)
        {
            var currentUserName = await Ctx.api.UserProcessor.GetCurrentUserAsync();
            var followings = await Ctx.api.UserProcessor
               .GetUserFollowingAsync(
                currentUserName.Value.UserName,
                PaginationParameters.MaxPagesToLoad(1));
            foreach (var follower in followings.Value)
            {
                dgbFollowing.Rows.Add(follower.UserName, follower.FullName);
            }
        }

        private async void btnUserFollow_Click(object sender, System.EventArgs e)
        {
            var user = await Ctx.api.UserProcessor.GetUserAsync(txtUser_Name.Text);
            var follow = await Ctx.api.UserProcessor.FollowUserAsync
                (user.Value.Pk);
            if (follow.Succeeded)
            {
                btnFollowing.PerformClick();
            }
        }

        private async void btnUnFollow_Click(object sender, System.EventArgs e)
        {
            var user = await Ctx.api.UserProcessor.GetUserAsync(txtUser_Name.Text);
            var unFollow = await Ctx.api.UserProcessor.UnFollowUserAsync
                (user.Value.Pk);
            if (unFollow.Succeeded)
            {
                btnFollowing.PerformClick();
            }
        }

        private async void btnBlockedUser_Click(object sender, System.EventArgs e)
        {
            lsbBlockUser.Items.Clear();
            var users = await Ctx.api.UserProcessor.GetBlockedUsersAsync(
                PaginationParameters.MaxPagesToLoad(1));

            foreach (var user in users.Value.BlockedList)
            {
                lsbBlockUser.Items.Add(user.UserName);
            }
        }

        private async void btnBlock_Click(object sender, System.EventArgs e)
        {
            var user = await Ctx.api.UserProcessor.GetUserAsync(txtUser_Name.Text);
            var block = Ctx.api.UserProcessor.BlockUserAsync(user.Value.Pk);
            btnBlockedUser.PerformClick();
        }

        private async void btnUnBlock_Click(object sender, System.EventArgs e)
        {
            var user = await Ctx.api.UserProcessor.GetUserAsync(txtUser_Name.Text);
            var block = Ctx.api.UserProcessor.UnBlockUserAsync(user.Value.Pk);
            btnBlockedUser.PerformClick();
        }

        private void lsbBlockUser_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtUser_Name.Text = lsbBlockUser.SelectedItem.ToString();
        }
    }
}
