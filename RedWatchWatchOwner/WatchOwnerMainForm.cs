using Microsoft.AspNetCore.SignalR.Client;
using RedWatchLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedWatchWatchOwner
{
     public partial class WatchOwnerMainForm : Form
     {
          private HubConnection m_ServerHub;
          private SoundPlayer m_AlertSound = new SoundPlayer();
          private WatchOwner m_WatchOwner;

          public WatchOwnerMainForm()
          {
               InitializeComponent();
               m_AlertSound.SoundLocation = 
                    @"C:\Users\User\Desktop\RedWatch\RedWatchServer\RedWatchWatchOwner\Resources\alertSound.wav";
               textBoxServerURL.Text = "https://localhost:5001/clientservicehub";
          }

          private async void buttonConnet_ClickAsync(object sender, EventArgs e)
          {
               m_ServerHub = new HubConnectionBuilder().WithUrl(textBoxServerURL.Text).Build();
               await m_ServerHub.StartAsync();
               m_ServerHub.On<eCity>("NewAlarm", city =>
               {
                    if(city == m_WatchOwner.City)
                    {
                         m_AlertSound.PlayLooping();
                         pictureBoxAlarm.Visible = true;
                         buttonStopAlarm.Visible = true;
                    }
               });
               m_ServerHub.On("EmailWithGeneratedCodeSent", () =>
               {
                    labelConnected.Text = "Email Sent";
                    labelConnected.Visible = true;
                    textBoxCode.Enabled = true;
               });


               m_ServerHub.On("RegisterSucceded", () =>
               {
                    labelConnected.Visible = true;
                    labelConnected.Text = "Succefuly Connected";
               });

               m_ServerHub.On("FailedOnRegister", () =>
               {
                    labelConnected.Text = "Failed 1";
               });

          }

          private async void buttonRegister_ClickAsync(object sender, EventArgs e)
          {
               //bool registerSucces;
               m_WatchOwner = new WatchOwner()
               {
                    City = (eCity)Enum.Parse(typeof(eCity), textBoxCity.Text),
                    Name = textBoxName.Text,
               };
               try
               {
                    m_WatchOwner.Email = textBoxEmail.Text;
               }
               catch
               {
                    MessageBox.Show("Email must be set in proper way","error", MessageBoxButtons.OK);
               }
               
               try
               {
                    
                   await m_ServerHub.InvokeAsync("RegisterFirstStep", m_WatchOwner);
                   await m_ServerHub.InvokeAsync("RegisterSecondStep", m_WatchOwner, int.Parse(textBoxCode.Text));
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK);
               }

          }

          private void buttonStopAlarm_Click(object sender, EventArgs e)
          {
               m_AlertSound.Stop();
          }
     }
}
