using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedWatchWatchOwner
{
     public partial class GeneratedCodeEnterForm : Form
     {
          public int GeneratedCode { get; set; }

          public GeneratedCodeEnterForm()
          {
               InitializeComponent();
          }

          private void TextboxGeneratedCode_Leave(object sender, EventArgs e)
          {
               int tryGeneratedCode;

               if(!int.TryParse(TextboxGeneratedCode.Text, out tryGeneratedCode))
               {
                    MessageBox.Show("ERROR: generated code must be a number", "The generated code must be a number", MessageBoxButtons.OK);
               }
               else
               {
                    buttonRegister.Enabled = true;
                    GeneratedCode = tryGeneratedCode;
               }
          }

          private void buttonCancel_Click(object sender, EventArgs e)
          {
               this.Close();
               DialogResult = DialogResult.Cancel;
          }

          private async void buttonRegister_Click(object sender, EventArgs e)
          {
               bool isSucceded = await WatchOwnerMethodFaceade.Instance.RegistrationSecondStepAsync(int.Parse(TextboxGeneratedCode.Text));

               if (!isSucceded)
               {
                    MessageBox.Show("ERROR:code doesnt match", "The code you have enterd doesnt look like ours, please try again", MessageBoxButtons.OK);
               }
               else
               {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
               }

          }

          private void TextboxGeneratedCode_OnValueChanged(object sender, EventArgs e)
          {
               int tryGeneratedCode;
               buttonRegister.Enabled = int.TryParse(TextboxGeneratedCode.Text, out tryGeneratedCode);
          }
     }
}
