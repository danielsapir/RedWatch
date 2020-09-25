namespace RedWatchWatchOwner
{
     partial class SignInForm
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.panelMain = new System.Windows.Forms.Panel();
               this.buttonSignInMain = new System.Windows.Forms.Button();
               this.buttonRegisterMain = new System.Windows.Forms.Button();
               this.TextboxPasssword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
               this.label10 = new System.Windows.Forms.Label();
               this.TextboxEmailAddressMain = new Bunifu.Framework.UI.BunifuMaterialTextbox();
               this.label11 = new System.Windows.Forms.Label();
               this.labelCloseWindow = new System.Windows.Forms.Label();
               this.label13 = new System.Windows.Forms.Label();
               this.labelEmailInvalid = new System.Windows.Forms.Label();
               this.labelEmailDoentExist = new System.Windows.Forms.Label();
               this.labelPasswordMismatch = new System.Windows.Forms.Label();
               this.panelMain.SuspendLayout();
               this.SuspendLayout();
               // 
               // panelMain
               // 
               this.panelMain.BackColor = System.Drawing.SystemColors.Control;
               this.panelMain.Controls.Add(this.labelPasswordMismatch);
               this.panelMain.Controls.Add(this.labelEmailDoentExist);
               this.panelMain.Controls.Add(this.labelEmailInvalid);
               this.panelMain.Controls.Add(this.buttonSignInMain);
               this.panelMain.Controls.Add(this.buttonRegisterMain);
               this.panelMain.Controls.Add(this.TextboxPasssword);
               this.panelMain.Controls.Add(this.label10);
               this.panelMain.Controls.Add(this.TextboxEmailAddressMain);
               this.panelMain.Controls.Add(this.label11);
               this.panelMain.Controls.Add(this.labelCloseWindow);
               this.panelMain.Controls.Add(this.label13);
               this.panelMain.Location = new System.Drawing.Point(0, 0);
               this.panelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.panelMain.Name = "panelMain";
               this.panelMain.Size = new System.Drawing.Size(401, 627);
               this.panelMain.TabIndex = 3;
               // 
               // buttonSignInMain
               // 
               this.buttonSignInMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.buttonSignInMain.Enabled = false;
               this.buttonSignInMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonSignInMain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.buttonSignInMain.ForeColor = System.Drawing.Color.White;
               this.buttonSignInMain.Location = new System.Drawing.Point(24, 335);
               this.buttonSignInMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.buttonSignInMain.Name = "buttonSignInMain";
               this.buttonSignInMain.Size = new System.Drawing.Size(346, 39);
               this.buttonSignInMain.TabIndex = 4;
               this.buttonSignInMain.Text = "Sign In";
               this.buttonSignInMain.UseVisualStyleBackColor = false;
               this.buttonSignInMain.Click += new System.EventHandler(this.buttonSignInMain_Click);
               // 
               // buttonRegisterMain
               // 
               this.buttonRegisterMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.buttonRegisterMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonRegisterMain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.buttonRegisterMain.ForeColor = System.Drawing.Color.White;
               this.buttonRegisterMain.Location = new System.Drawing.Point(24, 380);
               this.buttonRegisterMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.buttonRegisterMain.Name = "buttonRegisterMain";
               this.buttonRegisterMain.Size = new System.Drawing.Size(346, 39);
               this.buttonRegisterMain.TabIndex = 5;
               this.buttonRegisterMain.Text = "Register";
               this.buttonRegisterMain.UseVisualStyleBackColor = false;
               this.buttonRegisterMain.Click += new System.EventHandler(this.buttonRegisterMain_Click);
               // 
               // TextboxPasssword
               // 
               this.TextboxPasssword.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.TextboxPasssword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.TextboxPasssword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.TextboxPasssword.HintForeColor = System.Drawing.Color.Empty;
               this.TextboxPasssword.HintText = "";
               this.TextboxPasssword.isPassword = true;
               this.TextboxPasssword.LineFocusedColor = System.Drawing.Color.Black;
               this.TextboxPasssword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.TextboxPasssword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.TextboxPasssword.LineThickness = 3;
               this.TextboxPasssword.Location = new System.Drawing.Point(24, 230);
               this.TextboxPasssword.Margin = new System.Windows.Forms.Padding(5);
               this.TextboxPasssword.Name = "TextboxPasssword";
               this.TextboxPasssword.Size = new System.Drawing.Size(346, 36);
               this.TextboxPasssword.TabIndex = 3;
               this.TextboxPasssword.Text = "Password";
               this.TextboxPasssword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
               this.TextboxPasssword.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox7_OnValueChanged);
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.label10.Location = new System.Drawing.Point(20, 210);
               this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(86, 21);
               this.label10.TabIndex = 2;
               this.label10.Text = "Password:";
               // 
               // TextboxEmailAddressMain
               // 
               this.TextboxEmailAddressMain.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.TextboxEmailAddressMain.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.TextboxEmailAddressMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.TextboxEmailAddressMain.HintForeColor = System.Drawing.Color.Empty;
               this.TextboxEmailAddressMain.HintText = "example@example.com";
               this.TextboxEmailAddressMain.isPassword = false;
               this.TextboxEmailAddressMain.LineFocusedColor = System.Drawing.Color.Black;
               this.TextboxEmailAddressMain.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.TextboxEmailAddressMain.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.TextboxEmailAddressMain.LineThickness = 3;
               this.TextboxEmailAddressMain.Location = new System.Drawing.Point(24, 148);
               this.TextboxEmailAddressMain.Margin = new System.Windows.Forms.Padding(5);
               this.TextboxEmailAddressMain.Name = "TextboxEmailAddressMain";
               this.TextboxEmailAddressMain.Size = new System.Drawing.Size(346, 36);
               this.TextboxEmailAddressMain.TabIndex = 1;
               this.TextboxEmailAddressMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
               this.TextboxEmailAddressMain.OnValueChanged += new System.EventHandler(this.TextboxEmailAddressMain_OnValueChanged);
               // 
               // label11
               // 
               this.label11.AutoSize = true;
               this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.label11.Location = new System.Drawing.Point(20, 128);
               this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label11.Name = "label11";
               this.label11.Size = new System.Drawing.Size(121, 21);
               this.label11.TabIndex = 0;
               this.label11.Text = "Email Address:";
               // 
               // labelCloseWindow
               // 
               this.labelCloseWindow.AutoSize = true;
               this.labelCloseWindow.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.labelCloseWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.labelCloseWindow.Location = new System.Drawing.Point(360, 2);
               this.labelCloseWindow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelCloseWindow.Name = "labelCloseWindow";
               this.labelCloseWindow.Size = new System.Drawing.Size(25, 30);
               this.labelCloseWindow.TabIndex = 0;
               this.labelCloseWindow.Text = "x";
               this.labelCloseWindow.Click += new System.EventHandler(this.labelCloseWindow_Click);
               // 
               // label13
               // 
               this.label13.AutoSize = true;
               this.label13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.label13.Location = new System.Drawing.Point(19, 66);
               this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label13.Name = "label13";
               this.label13.Size = new System.Drawing.Size(293, 30);
               this.label13.TabIndex = 0;
               this.label13.Text = "Welcome to RedWatch";
               // 
               // labelEmailInvalid
               // 
               this.labelEmailInvalid.AutoSize = true;
               this.labelEmailInvalid.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.labelEmailInvalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.labelEmailInvalid.Location = new System.Drawing.Point(254, 128);
               this.labelEmailInvalid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelEmailInvalid.Name = "labelEmailInvalid";
               this.labelEmailInvalid.Size = new System.Drawing.Size(116, 16);
               this.labelEmailInvalid.TabIndex = 0;
               this.labelEmailInvalid.Text = "Email Format Invalid";
               this.labelEmailInvalid.Visible = false;
               // 
               // labelEmailDoentExist
               // 
               this.labelEmailDoentExist.AutoSize = true;
               this.labelEmailDoentExist.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.labelEmailDoentExist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.labelEmailDoentExist.Location = new System.Drawing.Point(-3, 294);
               this.labelEmailDoentExist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelEmailDoentExist.Name = "labelEmailDoentExist";
               this.labelEmailDoentExist.Size = new System.Drawing.Size(404, 17);
               this.labelEmailDoentExist.TabIndex = 0;
               this.labelEmailDoentExist.Text = "Email Address Inserted Does Not Exist In Our System. Please Register";
               this.labelEmailDoentExist.Visible = false;
               // 
               // labelPasswordMismatch
               // 
               this.labelPasswordMismatch.AutoSize = true;
               this.labelPasswordMismatch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.labelPasswordMismatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.labelPasswordMismatch.Location = new System.Drawing.Point(20, 311);
               this.labelPasswordMismatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelPasswordMismatch.Name = "labelPasswordMismatch";
               this.labelPasswordMismatch.Size = new System.Drawing.Size(357, 21);
               this.labelPasswordMismatch.TabIndex = 0;
               this.labelPasswordMismatch.Text = "Password Does Not Match The Email Address";
               this.labelPasswordMismatch.Visible = false;
               // 
               // SignInForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(399, 629);
               this.Controls.Add(this.panelMain);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.Name = "SignInForm";
               this.Text = "SignInForm";
               this.panelMain.ResumeLayout(false);
               this.panelMain.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel panelMain;
          private System.Windows.Forms.Button buttonSignInMain;
          private System.Windows.Forms.Button buttonRegisterMain;
          private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxPasssword;
          private System.Windows.Forms.Label label10;
          private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxEmailAddressMain;
          private System.Windows.Forms.Label label11;
          private System.Windows.Forms.Label label13;
          private System.Windows.Forms.Label labelCloseWindow;
          private System.Windows.Forms.Label labelEmailInvalid;
          private System.Windows.Forms.Label labelPasswordMismatch;
          private System.Windows.Forms.Label labelEmailDoentExist;
     }
}