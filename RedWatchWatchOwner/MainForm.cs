using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedWatchWatchOwner
{
     public partial class MainForm : Form
     {
          private RegisterForm m_RegisterForm;
          private SignInForm m_SignInForm;
          private bool m_SignInFormDisplay = true;
               
           public MainForm()
           {
               InitializeComponent();
               labelDescription.Text = "We Got Your Back\nRedWatch";
               m_RegisterForm = new RegisterForm(this);
               m_RegisterForm.Dock = DockStyle.Fill;
               m_RegisterForm.TopLevel = false;
               m_SignInForm = new SignInForm(this);
               m_SignInForm.Dock = DockStyle.Fill;
               m_SignInForm.TopLevel = false;
               ChangeInnerForm();
          }

           public void ChangeInnerForm()
           {
               if(m_SignInFormDisplay)
               {
                    panelChildForm.Controls.Clear();
                    panelChildForm.Controls.Add(m_SignInForm);
                    m_SignInForm.Show();
               }
               else
               {
                    panelChildForm.Controls.Clear();
                    panelChildForm.Controls.Add(m_RegisterForm);
                    m_RegisterForm.Show();
               }

               m_SignInFormDisplay = !m_SignInFormDisplay;
          }

          internal void RegistrationSuccess()
          {
               labelWelcomeNewUser.Text = "WELCOME " + WatchOwnerMethodFaceade.Instance.WatchOwnerLoggedIn.Name;
               labelWelcomeNewUser.Visible = true;
          }
     }
}
