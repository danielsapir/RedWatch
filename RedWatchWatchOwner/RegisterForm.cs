using RedWatchLib;
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
     public partial class RegisterForm : Form
     {
          private MainForm m_MainForm;
          private bool m_FirstNameValid = false;
          private bool m_LastNameValid = false;
          private bool m_EmailValid = false;
          private bool m_PasswordValid = false;
          private bool m_Contact1EmailValid = false;
          private bool m_Contact2EmailValid = true;
          private bool m_Contact3EmailValid = true;

          public RegisterForm(MainForm i_MainForm)
          {
               InitializeComponent();
               m_MainForm = i_MainForm;
          }

          private void buttonCancel_Click(object sender, EventArgs e)
          {
               m_MainForm.ChangeInnerForm();
          }

          private void labelCloseWindow_Click(object sender, EventArgs e)
          {
               m_MainForm.Close();
          }

          private void TextboxFirstName_Leave(object sender, EventArgs e)
          {
               if (TextboxFirstName.Text.Length > 0)
               {
                    m_FirstNameValid = true;
               }
               tryToEnableRegisterButton();
          }

          private void TextboxLastName_Leave(object sender, EventArgs e)
          {
               if (TextboxLastName.Text.Length > 0)
               {
                    m_LastNameValid = true;
               }
               tryToEnableRegisterButton();
          }

          private void TextboxEmailAddressRegister_Leave(object sender, EventArgs e)
          {
               labelEmailInvalid.Visible = !(new EmailAddressAttribute().IsValid(TextboxEmailAddressRegister.Text));
               m_EmailValid = !labelEmailInvalid.Visible;
               tryToEnableRegisterButton();
          }

          private void TextboxRePasswordRegister_Leave(object sender, EventArgs e)
          {
               labelPasswordInvalid.Visible = !((TextboxPasswordRegister.Text).Equals(TextboxRePasswordRegister.Text));
               m_PasswordValid = !labelPasswordInvalid.Visible;
               tryToEnableRegisterButton();
          }

          private void TextboxContact1EmailRegister_Leave(object sender, EventArgs e)
          {
               labelContact1Invalid.Visible = !(new EmailAddressAttribute().IsValid(TextboxContact1EmailRegister.Text));
               m_Contact1EmailValid = !labelContact1Invalid.Visible;
               tryToEnableRegisterButton();
          }

          private void TextboxContact2EmailRegister_Leave(object sender, EventArgs e)
          {
               labelContact2Invalid.Visible = !(new EmailAddressAttribute().IsValid(TextboxContact2EmailRegister.Text)) 
                    && TextboxContact2EmailRegister.Text != string.Empty;
               m_Contact2EmailValid = !labelContact2Invalid.Visible;
               tryToEnableRegisterButton();
          }

          private void TextboxContact3EmailRegister_Leave(object sender, EventArgs e)
          {
               labelContact3Invalid.Visible = !(new EmailAddressAttribute().IsValid(TextboxContact3EmailRegister.Text))
                     && TextboxContact3EmailRegister.Text != string.Empty;
               m_Contact3EmailValid = !labelContact3Invalid.Visible;
               tryToEnableRegisterButton();
          }

          private void tryToEnableRegisterButton()
          {
               buttonRegister.Enabled =
                    m_FirstNameValid &&
                    m_LastNameValid &&
                    m_EmailValid &&
                    m_PasswordValid &&
                    m_Contact1EmailValid &&
                    m_Contact2EmailValid &&
                    m_Contact3EmailValid;
          }

          private async void buttonRegister_Click(object sender, EventArgs e)
          {
               Contact[] watchOwnerContacts = makeContactsArray();

               WatchOwner watchOnwerCreated = new WatchOwner()
               {
                    Name = TextboxFirstName.Text + " " + TextboxLastName.Text,
                    Email = TextboxEmailAddressRegister.Text,
                    Password = TextboxPasswordRegister.Text,
                    Contacts = watchOwnerContacts,
               };

               WatchOwnerMethodFaceade.Instance.WatchOwnerLoggedIn = watchOnwerCreated;
               bool emailExist = await WatchOwnerMethodFaceade.Instance.RegiserationFirstStepAsync();


               if(emailExist)
               {
                    MessageBox.Show("Email already exists", "Email already exist in the system." + Environment.NewLine + "Try to login."
                         , MessageBoxButtons.OK);
               }
               else
               {
                    GeneratedCodeEnterForm generatedCodeEnterForm = new GeneratedCodeEnterForm();
                    generatedCodeEnterForm.StartPosition = FormStartPosition.CenterParent;
                    DialogResult generatedFormResult =  generatedCodeEnterForm.ShowDialog();
                    if(generatedFormResult == DialogResult.OK)
                    {
                         m_MainForm.RegistrationSuccess();
                         m_MainForm.ChangeInnerForm();
                    }
               }
          }

          private Contact[] makeContactsArray()
          {
               Contact[] watchOwnerContacts = new Contact[3];

               watchOwnerContacts[0] = new Contact();
               watchOwnerContacts[0].Email = TextboxContact1EmailRegister.Text;
               if(m_Contact2EmailValid)
               {
                    watchOwnerContacts[1] = new Contact();
                    watchOwnerContacts[1].Email = TextboxContact2EmailRegister.Text;
               }
               if (m_Contact3EmailValid)
               {
                    watchOwnerContacts[2] = new Contact();
                    watchOwnerContacts[2].Email = TextboxContact3EmailRegister.Text;
               }

               return watchOwnerContacts;
          }

          private void TextboxContact1EmailRegister_OnValueChanged(object sender, EventArgs e)
          {
               m_Contact1EmailValid = new EmailAddressAttribute().IsValid(TextboxContact1EmailRegister.Text);
               tryToEnableRegisterButton();
          }
     }
}
