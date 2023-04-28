using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Mediator
{
    /// <summary>
    /// 创建成员、分配成员任务，如让成员setEnabled方法，具体的处理则交给各成员；同时如成员cbxColleague的OnChecked事件中调用了mediator的changed事件，即成员通知或者报告给仲裁者
    /// 区别于Facade的单向，mediator是双向的
    /// /// </summary>
    internal class LoginMediator : FrameMediator
    {
        string name;
        BtnColleague OKBtn;
        BtnColleague CancelBtn;
        CbxColleague GuestCbx;
        CbxColleague LoginCbx;
        TbxCollleague UserTbx;
        TbxCollleague PwdTbx;
        public LoginMediator(string name):base(name)
        {
           
            this.Title = name;
            CreateColleague();
            this.Show();
        }
        public override void ColleagueChanged()
        {
            if (GuestCbx.IsChecked==true)
            {
                UserTbx.SetColleagueEnabled(false);
                PwdTbx.SetColleagueEnabled(false);
                OKBtn.SetColleagueEnabled(true);
            }
            else
            {
                UserTbx.SetColleagueEnabled(true);
                if(UserTbx.Text.Length>0)
                {
                    PwdTbx.SetColleagueEnabled(true);
                    if (PwdTbx.Text.Length > 0)
                    {
                        OKBtn.SetColleagueEnabled(true);
                        CancelBtn.SetColleagueEnabled(true);
                    }
                    else
                    {
                        OKBtn.SetColleagueEnabled(false);
                    }
                }
                else
                {
                    PwdTbx.SetColleagueEnabled(false);
                    OKBtn.SetColleagueEnabled(false);
                }
            }
        }

        public override void CreateColleague()
        {
            GuestCbx = new CbxColleague("Guest");

            LoginCbx = new CbxColleague("Login");

            System.Windows.Controls.Label userLable = new System.Windows.Controls.Label
            {
                Content = "user"
            };
            System.Windows.Controls.Label pwdLabel = new System.Windows.Controls.Label { Content="pwd" };


            UserTbx = new TbxCollleague();
            PwdTbx = new TbxCollleague();
            OKBtn = new BtnColleague("OK");
            CancelBtn= new BtnColleague("Cancel");

            GuestCbx.SetMediator(this);
            LoginCbx.SetMediator(this);

            UserTbx.SetMediator(this);
            PwdTbx.SetMediator(this);

            OKBtn.SetMediator(this);
            CancelBtn.SetMediator(this);

            StackPanel contentControl=new StackPanel();
            contentControl.Orientation = Orientation.Vertical;
            this.AddChild(contentControl);

            contentControl.Children.Add(GuestCbx);
            contentControl.Children.Add(LoginCbx);
            contentControl.Children.Add(userLable);
            contentControl.Children.Add(UserTbx);
            contentControl.Children.Add(pwdLabel);
            contentControl.Children.Add(PwdTbx);

            contentControl.Children.Add(OKBtn);
            contentControl.Children.Add(CancelBtn);
          
        }
    }
}
