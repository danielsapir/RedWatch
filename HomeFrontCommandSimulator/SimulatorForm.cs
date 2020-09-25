using Microsoft.AspNetCore.SignalR.Client;
using RedWatchLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFrontCommandSimulator
{
     public partial class SimulatorForm : Form
     {
          private HubConnection m_ServerHub;

          public SimulatorForm()
          {
               InitializeComponent();
               
          }

          private async void buttonConnect_ClickAsync(object sender, EventArgs e)
          {
               m_ServerHub = new HubConnectionBuilder().WithUrl(textBoxServerURL.Text).Build();
               await m_ServerHub.StartAsync();
               labelConnected.Visible = true;
          }

          private void buttonTelAviv_Click(object sender, EventArgs e)
          {

               m_ServerHub.InvokeAsync("HFCHasNewAlarm", eCity.TEL_AVIV);
          }

          private void buttonRishon_Click(object sender, EventArgs e)
          {
               m_ServerHub.InvokeAsync("HFCHasNewAlarm", eCity.RISHON_LEZION);
          }

          private void buttonHaifa_Click(object sender, EventArgs e)
          {
               m_ServerHub.InvokeAsync("HFCHasNewAlarm", eCity.HAIFA);
          }
     }
}
