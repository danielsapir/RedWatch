namespace RedWatchWatchOwner
{
     partial class ClockForm
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
               this.circularProgressBarTime = new CircularProgressBar.CircularProgressBar();
               this.buttonINHM = new System.Windows.Forms.Button();
               this.buttonIOKM = new System.Windows.Forms.Button();
               this.labelCanel = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // circularProgressBarTime
               // 
               this.circularProgressBarTime.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
               this.circularProgressBarTime.AnimationSpeed = 500;
               this.circularProgressBarTime.BackColor = System.Drawing.Color.Transparent;
               this.circularProgressBarTime.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
               this.circularProgressBarTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.circularProgressBarTime.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
               this.circularProgressBarTime.InnerMargin = 2;
               this.circularProgressBarTime.InnerWidth = -1;
               this.circularProgressBarTime.Location = new System.Drawing.Point(10, 13);
               this.circularProgressBarTime.MarqueeAnimationSpeed = 2000;
               this.circularProgressBarTime.Name = "circularProgressBarTime";
               this.circularProgressBarTime.OuterColor = System.Drawing.Color.Gray;
               this.circularProgressBarTime.OuterMargin = -25;
               this.circularProgressBarTime.OuterWidth = 26;
               this.circularProgressBarTime.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.circularProgressBarTime.ProgressWidth = 18;
               this.circularProgressBarTime.SecondaryFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.circularProgressBarTime.Size = new System.Drawing.Size(320, 320);
               this.circularProgressBarTime.StartAngle = 270;
               this.circularProgressBarTime.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
               this.circularProgressBarTime.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
               this.circularProgressBarTime.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
               this.circularProgressBarTime.SubscriptText = "00";
               this.circularProgressBarTime.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
               this.circularProgressBarTime.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
               this.circularProgressBarTime.SuperscriptText = "";
               this.circularProgressBarTime.TabIndex = 0;
               this.circularProgressBarTime.Text = "00:00:00";
               this.circularProgressBarTime.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
               this.circularProgressBarTime.Value = 68;
               // 
               // buttonINHM
               // 
               this.buttonINHM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.buttonINHM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonINHM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.buttonINHM.ForeColor = System.Drawing.Color.White;
               this.buttonINHM.Location = new System.Drawing.Point(63, 114);
               this.buttonINHM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.buttonINHM.Name = "buttonINHM";
               this.buttonINHM.Size = new System.Drawing.Size(204, 39);
               this.buttonINHM.TabIndex = 4;
               this.buttonINHM.Text = "I Need Help";
               this.buttonINHM.UseVisualStyleBackColor = false;
               this.buttonINHM.Visible = false;
               this.buttonINHM.Click += new System.EventHandler(this.buttonINHM_Click);
               // 
               // buttonIOKM
               // 
               this.buttonIOKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.buttonIOKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonIOKM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.buttonIOKM.ForeColor = System.Drawing.Color.White;
               this.buttonIOKM.Location = new System.Drawing.Point(63, 204);
               this.buttonIOKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.buttonIOKM.Name = "buttonIOKM";
               this.buttonIOKM.Size = new System.Drawing.Size(204, 39);
               this.buttonIOKM.TabIndex = 4;
               this.buttonIOKM.Text = "I Am OK";
               this.buttonIOKM.UseVisualStyleBackColor = false;
               this.buttonIOKM.Visible = false;
               this.buttonIOKM.Click += new System.EventHandler(this.buttonIOKM_Click);
               // 
               // labelCanel
               // 
               this.labelCanel.AutoSize = true;
               this.labelCanel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.labelCanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.labelCanel.Location = new System.Drawing.Point(305, 9);
               this.labelCanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelCanel.Name = "labelCanel";
               this.labelCanel.Size = new System.Drawing.Size(25, 30);
               this.labelCanel.TabIndex = 0;
               this.labelCanel.Text = "x";
               this.labelCanel.Click += new System.EventHandler(this.labelCanel_Click);
               // 
               // ClockForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(342, 345);
               this.Controls.Add(this.labelCanel);
               this.Controls.Add(this.buttonIOKM);
               this.Controls.Add(this.buttonINHM);
               this.Controls.Add(this.circularProgressBarTime);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "ClockForm";
               this.Text = "ClockForm";
               this.Load += new System.EventHandler(this.ClockForm_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private CircularProgressBar.CircularProgressBar circularProgressBarTime;
          private System.Windows.Forms.Button buttonINHM;
          private System.Windows.Forms.Button buttonIOKM;
          private System.Windows.Forms.Label labelCanel;
     }
}