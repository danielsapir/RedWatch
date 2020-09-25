namespace HomeFrontCommandSimulator
{
     partial class SimulatorForm
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
               this.buttonConnect = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.textBoxServerURL = new System.Windows.Forms.TextBox();
               this.buttonTelAviv = new System.Windows.Forms.Button();
               this.buttonRishon = new System.Windows.Forms.Button();
               this.buttonHaifa = new System.Windows.Forms.Button();
               this.labelConnected = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // buttonConnect
               // 
               this.buttonConnect.Location = new System.Drawing.Point(281, 13);
               this.buttonConnect.Name = "buttonConnect";
               this.buttonConnect.Size = new System.Drawing.Size(75, 23);
               this.buttonConnect.TabIndex = 0;
               this.buttonConnect.Text = "Connect";
               this.buttonConnect.UseVisualStyleBackColor = true;
               this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_ClickAsync);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(13, 13);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(63, 15);
               this.label1.TabIndex = 1;
               this.label1.Text = "Server URL";
               // 
               // textBoxServerURL
               // 
               this.textBoxServerURL.Location = new System.Drawing.Point(82, 10);
               this.textBoxServerURL.Name = "textBoxServerURL";
               this.textBoxServerURL.Size = new System.Drawing.Size(193, 23);
               this.textBoxServerURL.TabIndex = 2;
               // 
               // buttonTelAviv
               // 
               this.buttonTelAviv.Location = new System.Drawing.Point(13, 50);
               this.buttonTelAviv.Name = "buttonTelAviv";
               this.buttonTelAviv.Size = new System.Drawing.Size(343, 23);
               this.buttonTelAviv.TabIndex = 3;
               this.buttonTelAviv.Text = "Tel aviv";
               this.buttonTelAviv.UseVisualStyleBackColor = true;
               this.buttonTelAviv.Click += new System.EventHandler(this.buttonTelAviv_Click);
               // 
               // buttonRishon
               // 
               this.buttonRishon.Location = new System.Drawing.Point(13, 93);
               this.buttonRishon.Name = "buttonRishon";
               this.buttonRishon.Size = new System.Drawing.Size(343, 23);
               this.buttonRishon.TabIndex = 3;
               this.buttonRishon.Text = "Rishon Lezion";
               this.buttonRishon.UseVisualStyleBackColor = true;
               this.buttonRishon.Click += new System.EventHandler(this.buttonRishon_Click);
               // 
               // buttonHaifa
               // 
               this.buttonHaifa.Location = new System.Drawing.Point(13, 139);
               this.buttonHaifa.Name = "buttonHaifa";
               this.buttonHaifa.Size = new System.Drawing.Size(343, 23);
               this.buttonHaifa.TabIndex = 3;
               this.buttonHaifa.Text = "Haifa";
               this.buttonHaifa.UseVisualStyleBackColor = true;
               this.buttonHaifa.Click += new System.EventHandler(this.buttonHaifa_Click);
               // 
               // labelConnected
               // 
               this.labelConnected.AutoSize = true;
               this.labelConnected.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.labelConnected.Location = new System.Drawing.Point(363, 13);
               this.labelConnected.Name = "labelConnected";
               this.labelConnected.Size = new System.Drawing.Size(161, 37);
               this.labelConnected.TabIndex = 4;
               this.labelConnected.Text = "Connected!!";
               this.labelConnected.Visible = false;
               // 
               // SimulatorForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.labelConnected);
               this.Controls.Add(this.buttonHaifa);
               this.Controls.Add(this.buttonRishon);
               this.Controls.Add(this.buttonTelAviv);
               this.Controls.Add(this.textBoxServerURL);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.buttonConnect);
               this.Name = "SimulatorForm";
               this.Text = "Form1";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button buttonConnect;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox textBoxServerURL;
          private System.Windows.Forms.Button buttonTelAviv;
          private System.Windows.Forms.Button buttonRishon;
          private System.Windows.Forms.Button buttonHaifa;
          private System.Windows.Forms.Label labelConnected;
     }
}

