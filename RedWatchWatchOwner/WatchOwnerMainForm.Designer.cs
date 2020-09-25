namespace RedWatchWatchOwner
{
     partial class WatchOwnerMainForm
     {
          /// <summary>
          ///  Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          ///  Clean up any resources being used.
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
          ///  Required method for Designer support - do not modify
          ///  the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchOwnerMainForm));
               this.label1 = new System.Windows.Forms.Label();
               this.textBoxServerURL = new System.Windows.Forms.TextBox();
               this.buttonConnet = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.textBoxName = new System.Windows.Forms.TextBox();
               this.label3 = new System.Windows.Forms.Label();
               this.textBoxEmail = new System.Windows.Forms.TextBox();
               this.buttonRegister = new System.Windows.Forms.Button();
               this.labelConnected = new System.Windows.Forms.Label();
               this.buttonStopAlarm = new System.Windows.Forms.Button();
               this.pictureBoxAlarm = new System.Windows.Forms.PictureBox();
               this.label4 = new System.Windows.Forms.Label();
               this.textBoxCity = new System.Windows.Forms.TextBox();
               this.label5 = new System.Windows.Forms.Label();
               this.textBoxCode = new System.Windows.Forms.TextBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(12, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(63, 15);
               this.label1.TabIndex = 1;
               this.label1.Text = "Server URL";
               // 
               // textBoxServerURL
               // 
               this.textBoxServerURL.Location = new System.Drawing.Point(81, 6);
               this.textBoxServerURL.Name = "textBoxServerURL";
               this.textBoxServerURL.Size = new System.Drawing.Size(221, 23);
               this.textBoxServerURL.TabIndex = 2;
               // 
               // buttonConnet
               // 
               this.buttonConnet.Location = new System.Drawing.Point(315, 5);
               this.buttonConnet.Name = "buttonConnet";
               this.buttonConnet.Size = new System.Drawing.Size(120, 23);
               this.buttonConnet.TabIndex = 3;
               this.buttonConnet.Text = "Connect";
               this.buttonConnet.UseVisualStyleBackColor = true;
               this.buttonConnet.Click += new System.EventHandler(this.buttonConnet_ClickAsync);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(13, 42);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(39, 15);
               this.label2.TabIndex = 4;
               this.label2.Text = "Name";
               // 
               // textBoxName
               // 
               this.textBoxName.Location = new System.Drawing.Point(57, 39);
               this.textBoxName.Name = "textBoxName";
               this.textBoxName.Size = new System.Drawing.Size(175, 23);
               this.textBoxName.TabIndex = 5;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(13, 71);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(36, 15);
               this.label3.TabIndex = 4;
               this.label3.Text = "Email";
               // 
               // textBoxEmail
               // 
               this.textBoxEmail.Location = new System.Drawing.Point(57, 68);
               this.textBoxEmail.Name = "textBoxEmail";
               this.textBoxEmail.Size = new System.Drawing.Size(175, 23);
               this.textBoxEmail.TabIndex = 5;
               // 
               // buttonRegister
               // 
               this.buttonRegister.Location = new System.Drawing.Point(238, 38);
               this.buttonRegister.Name = "buttonRegister";
               this.buttonRegister.Size = new System.Drawing.Size(131, 81);
               this.buttonRegister.TabIndex = 6;
               this.buttonRegister.Text = "Register";
               this.buttonRegister.UseVisualStyleBackColor = true;
               this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_ClickAsync);
               // 
               // labelConnected
               // 
               this.labelConnected.AutoSize = true;
               this.labelConnected.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.labelConnected.ForeColor = System.Drawing.Color.Lime;
               this.labelConnected.Location = new System.Drawing.Point(12, 141);
               this.labelConnected.Name = "labelConnected";
               this.labelConnected.Size = new System.Drawing.Size(814, 79);
               this.labelConnected.TabIndex = 7;
               this.labelConnected.Text = "Connected Suucefully";
               this.labelConnected.Visible = false;
               // 
               // buttonStopAlarm
               // 
               this.buttonStopAlarm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.buttonStopAlarm.Location = new System.Drawing.Point(13, 379);
               this.buttonStopAlarm.Name = "buttonStopAlarm";
               this.buttonStopAlarm.Size = new System.Drawing.Size(787, 45);
               this.buttonStopAlarm.TabIndex = 8;
               this.buttonStopAlarm.Text = "Stop alarm";
               this.buttonStopAlarm.UseVisualStyleBackColor = true;
               this.buttonStopAlarm.Visible = false;
               this.buttonStopAlarm.Click += new System.EventHandler(this.buttonStopAlarm_Click);
               // 
               // pictureBoxAlarm
               // 
               this.pictureBoxAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
               this.pictureBoxAlarm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlarm.Image")));
               this.pictureBoxAlarm.Location = new System.Drawing.Point(13, 216);
               this.pictureBoxAlarm.Name = "pictureBoxAlarm";
               this.pictureBoxAlarm.Size = new System.Drawing.Size(187, 157);
               this.pictureBoxAlarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxAlarm.TabIndex = 9;
               this.pictureBoxAlarm.TabStop = false;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(13, 99);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(28, 15);
               this.label4.TabIndex = 4;
               this.label4.Text = "City";
               // 
               // textBoxCity
               // 
               this.textBoxCity.Location = new System.Drawing.Point(57, 96);
               this.textBoxCity.Name = "textBoxCity";
               this.textBoxCity.Size = new System.Drawing.Size(175, 23);
               this.textBoxCity.TabIndex = 5;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(375, 45);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(38, 15);
               this.label5.TabIndex = 4;
               this.label5.Text = "CODE";
               // 
               // textBoxCode
               // 
               this.textBoxCode.Enabled = false;
               this.textBoxCode.Location = new System.Drawing.Point(419, 42);
               this.textBoxCode.Name = "textBoxCode";
               this.textBoxCode.Size = new System.Drawing.Size(175, 23);
               this.textBoxCode.TabIndex = 5;
               // 
               // WatchOwnerMainForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(934, 452);
               this.Controls.Add(this.pictureBoxAlarm);
               this.Controls.Add(this.buttonStopAlarm);
               this.Controls.Add(this.labelConnected);
               this.Controls.Add(this.buttonRegister);
               this.Controls.Add(this.textBoxCity);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.textBoxEmail);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.textBoxCode);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.textBoxName);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.buttonConnet);
               this.Controls.Add(this.textBoxServerURL);
               this.Controls.Add(this.label1);
               this.Name = "WatchOwnerMainForm";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox textBoxServerURL;
          private System.Windows.Forms.Button buttonConnet;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TextBox textBoxName;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox textBoxEmail;
          private System.Windows.Forms.Button buttonRegister;
          private System.Windows.Forms.Label labelConnected;
          private System.Windows.Forms.Button buttonStopAlarm;
          private System.Windows.Forms.PictureBox pictureBoxAlarm;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.TextBox textBoxCity;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.TextBox textBoxCode;
     }
}

