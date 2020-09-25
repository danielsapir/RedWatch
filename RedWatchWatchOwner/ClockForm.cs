using RedWatchLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace RedWatchWatchOwner
{
     public partial class ClockForm : Form
     {
          private SoundPlayer m_AlertSound = new SoundPlayer();

          public ClockForm()
          {
               InitializeComponent();
               m_AlertSound.SoundLocation =
                    @"C:\Users\User\Desktop\RedWatch\RedWatchServer\RedWatchWatchOwner\Resources\alertSound.wav";
          }

          private void ClockForm_Load(object sender, EventArgs e)
          {
               System.Timers.Timer localTimeTimer = new System.Timers.Timer();
               localTimeTimer.Interval = 1000;
               localTimeTimer.Elapsed += everySecondInTimer;
               localTimeTimer.Start();
               WatchOwnerMethodFaceade.Instance.AddMethodToOnNewAlarm(HasRedAlert);
          }

          private void everySecondInTimer(object sender, System.Timers.ElapsedEventArgs e)
          {
               circularProgressBarTime.Invoke((MethodInvoker)(() =>
               {
                    circularProgressBarTime.Text = DateTime.Now.ToString("hh:mm:ss");
                    circularProgressBarTime.SubscriptText = DateTime.Now.ToString("tt");
               }));
          }

          public void HasRedAlert()
          {
               buttonINHM.Invoke((MethodInvoker)(() => 
               {
                    buttonINHM.Visible = true;
                    buttonIOKM.Visible = true;
                    circularProgressBarTime.MarqueeAnimationSpeed /= 8;
                    m_AlertSound.PlayLooping();
               }));
               WatchOwnerMethodFaceade.Instance.WatchOwnerInRedAlert();
          }

          private void buttonINHM_Click(object sender, EventArgs e)
          {
               WatchOwnerMethodFaceade.Instance.WatchOwnerSendsMessage(eWatchOwnerCurrentSituation.INHM);
               buttonINHM.Visible = false;
               buttonIOKM.Visible = false;
               circularProgressBarTime.MarqueeAnimationSpeed *= 8;
               m_AlertSound.Stop();
          }

          private void buttonIOKM_Click(object sender, EventArgs e)
          {
               WatchOwnerMethodFaceade.Instance.WatchOwnerSendsMessage(eWatchOwnerCurrentSituation.IOKM);
               buttonINHM.Visible = false;
               buttonIOKM.Visible = false;
               circularProgressBarTime.MarqueeAnimationSpeed *= 8;
               m_AlertSound.Stop();
          }

          private void labelCanel_Click(object sender, EventArgs e)
          {
               ParentForm.Show();
               this.Close();
          }
     }
}
