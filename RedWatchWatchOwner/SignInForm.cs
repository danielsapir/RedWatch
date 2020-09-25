using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedWatchWatchOwner
{
     public partial class SignInForm : Form
     {
          private MainForm m_MainForm;
          private bool m_EmailFormatValid = false;
          private bool m_PasswordFormatValid = false;

          public SignInForm(MainForm i_MainForm)
          {
               InitializeComponent();
               m_MainForm = i_MainForm;
          }

          private void buttonRegisterMain_Click(object sender, EventArgs e)
          {
               m_MainForm.ChangeInnerForm();
          }

          private void labelCloseWindow_Click(object sender, EventArgs e)
          {
               m_MainForm.Close();
          }

          private void tryToEnableSignInButton()
          {
               buttonSignInMain.Enabled = m_EmailFormatValid && m_PasswordFormatValid;
          }

          private void TextboxEmailAddressMain_OnValueChanged(object sender, EventArgs e)
          {
               labelEmailInvalid.Visible = !(new EmailAddressAttribute().IsValid(TextboxEmailAddressMain.Text));
               m_EmailFormatValid = !labelEmailInvalid.Visible;
               tryToEnableSignInButton();
          }

          private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
          {
               m_PasswordFormatValid = TextboxPasssword.Text.Length > 0;
               tryToEnableSignInButton();
          }

          private async void buttonSignInMain_Click(object sender, EventArgs e)
          {
               if (await WatchOwnerMethodFaceade.Instance.IsEmailAddressExists(TextboxEmailAddressMain.Text))
               {
                    labelEmailDoentExist.Visible = false;
                    if(await WatchOwnerMethodFaceade.Instance.SignInWatchOwner(TextboxEmailAddressMain.Text, TextboxPasssword.Text))
                    {
                         labelPasswordMismatch.Visible = false;
                         ClockForm clock = new ClockForm();

                         m_MainForm.Hide();
                         clock.StartPosition = FormStartPosition.CenterScreen;
                         clock.Show();
                    }
                    else
                    {
                         labelPasswordMismatch.Visible = true;
                    }
               }
               else
               {
                    labelEmailDoentExist.Visible = true;
               }
          }
     }
}
