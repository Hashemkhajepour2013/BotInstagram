using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Logger;
using System.IO;
using System.Linq;
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

        private async void btnSend_Click(object sender, System.EventArgs e)
        {
            var user = await Ctx.api.UserProcessor.GetUserAsync(txtDirectUserName.Text);
            var direct = await Ctx.api.MessagingProcessor.SendDirectTextAsync(
                user.Value.Pk.ToString(),
                null,
                txtMessage.Text);
            if (direct.Succeeded)
            {
                MessageBox.Show("Sended ...");
            }
        }

        private async void btnSendImage_Click(object sender, System.EventArgs e)
        {
            var inbox = await Ctx.api.MessagingProcessor.GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(1));          
            var threadId = inbox.Value.Inbox.Threads.FirstOrDefault(_ => _.Title == txtDirectUserName.Text).ThreadId;
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            var imageUp = new InstaImage()
            {
                Uri = op.FileName
            };

            var image = await Ctx.api.MessagingProcessor.SendDirectPhotoAsync(
                imageUp,
                threadId
              );

            if (image.Succeeded)
            {
                MessageBox.Show("Sended ...");
            }
        }

        private async void btnVideo_Click(object sender, System.EventArgs e)
        {
            var inbox = await Ctx.api.MessagingProcessor.GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(1));
            var threadId = inbox.Value.Inbox.Threads.FirstOrDefault(_ => _.Title == txtDirectUserName.Text).ThreadId;
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            var videoUp = new InstaVideo()
            {
                Uri = op.FileName
            };

            var video = new InstaVideoUpload()
            {
                Video = videoUp
            };

            var directVideo = await Ctx.api.MessagingProcessor.SendDirectVideoAsync(
                video,
                threadId);

            if (directVideo.Succeeded)
            {
                MessageBox.Show("Sended ...");
            }
        }

        private void btnActivity_Click(object sender, System.EventArgs e)
        {
            (new frmActivity()).ShowDialog();
        }

        private void btnShowPost_Click(object sender, System.EventArgs e)
        {
            frmShowPost frm = new frmShowPost()
            {
                UserName = txtUserNameForPost.Text.Trim()
            };

            frm.ShowDialog();
        }

        private async void btnStoryPhoto_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog() == DialogResult.OK)
            {
                var image = new InstaImage()
                {
                    Uri = op.FileName
                };
                var result = await Ctx.api
                   .StoryProcessor.UploadStoryPhotoAsync(
                    image, "Hashem");
                if (result.Succeeded)
                {
                    MessageBox.Show("Photo Sended ..."); 
                }
            }
        }

        private async void btnStoryVideo_Click(object sender, System.EventArgs e)
        {
           OpenFileDialog op = new OpenFileDialog();
            op.Title = "selectVideo";
            op.ShowDialog();
            string videoUri = op.FileName;
            OpenFileDialog opImage = new OpenFileDialog();
            opImage.ShowDialog();
            string imageUri = opImage.FileName;
            var video = new InstaVideoUpload()
            {
                Video = new InstaVideo(videoUri, 0, 0),
                VideoThumbnail = new InstaImage(imageUri, 0, 0)
            };
            var res = await Ctx.api
                .StoryProcessor.UploadStoryVideoAsync(
                video, "Hashem");

            if (res.Succeeded)
            {
                MessageBox.Show("video sended ...");
            }
        }

        private async void btnSendImagePost_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            string imagePath = op.FileName;

            var media = new InstaImageUpload()
            {
                Height = 1080,
                Width = 1080,
                Uri = imagePath
            };
            media.UserTags.Add(new InstaUserTagUpload()
            {
                Username = "HashemDeveloper",
                X = 0.5,
                Y = 0.5
            });

            var res = await Ctx.api.MediaProcessor
                .UploadPhotoAsync(media, txtCaption.Text);
            if (res.Succeeded)
            {
                txtCaption.Text = "";
                MessageBox.Show("Done ...");
            }
        }

        private async void btnSendVideoPost_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "selectVideo";
            op.ShowDialog();
            string videoUri = op.FileName;
            OpenFileDialog opImage = new OpenFileDialog();
            opImage.Title = "Select Image";
            opImage.Filter = "Image files (*.jpg, *.jpeg, *.jep, *.img)";
            opImage.ShowDialog();
            string imageUri = opImage.FileName;
            var video = new InstaVideoUpload()
            {
                Video = new InstaVideo(videoUri, 0, 0),
                VideoThumbnail = new InstaImage(imageUri, 0, 0)
            };

            video.UserTags.Add(new InstaUserTagUpload()
            {
                Username = "HashemDeveloper",
                X = 0.5,
                Y = 0.5
            });

            var res = await Ctx.api.MediaProcessor
                .UploadVideoAsync(video, txtCaption.Text);
            if (res.Succeeded)
            {
                MessageBox.Show("Done ...");
            }
        }
    }
}
