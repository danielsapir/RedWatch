namespace RedWatchWatchOwner
{
    partial class MainForm
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
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
               this.panelLeft = new System.Windows.Forms.Panel();
               this.labelWelcomeNewUser = new System.Windows.Forms.Label();
               this.labelDescription = new System.Windows.Forms.Label();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
               this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
               this.panelChildForm = new System.Windows.Forms.Panel();
               this.panelLeft.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // panelLeft
               // 
               this.panelLeft.BackColor = System.Drawing.Color.White;
               this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.panelLeft.Controls.Add(this.labelWelcomeNewUser);
               this.panelLeft.Controls.Add(this.labelDescription);
               this.panelLeft.Controls.Add(this.pictureBox1);
               this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
               this.panelLeft.Location = new System.Drawing.Point(0, 0);
               this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.panelLeft.Name = "panelLeft";
               this.panelLeft.Size = new System.Drawing.Size(374, 627);
               this.panelLeft.TabIndex = 0;
               // 
               // labelWelcomeNewUser
               // 
               this.labelWelcomeNewUser.AutoSize = true;
               this.labelWelcomeNewUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.labelWelcomeNewUser.ForeColor = System.Drawing.Color.Red;
               this.labelWelcomeNewUser.Location = new System.Drawing.Point(86, 44);
               this.labelWelcomeNewUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelWelcomeNewUser.Name = "labelWelcomeNewUser";
               this.labelWelcomeNewUser.Size = new System.Drawing.Size(62, 22);
               this.labelWelcomeNewUser.TabIndex = 1;
               this.labelWelcomeNewUser.Text = "[TEXT]";
               this.labelWelcomeNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.labelWelcomeNewUser.Visible = false;
               // 
               // labelDescription
               // 
               this.labelDescription.AutoSize = true;
               this.labelDescription.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.labelDescription.ForeColor = System.Drawing.Color.Red;
               this.labelDescription.Location = new System.Drawing.Point(86, 363);
               this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelDescription.Name = "labelDescription";
               this.labelDescription.Size = new System.Drawing.Size(62, 22);
               this.labelDescription.TabIndex = 1;
               this.labelDescription.Text = "[TEXT]";
               this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
               this.pictureBox1.Location = new System.Drawing.Point(77, 119);
               this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(222, 226);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               // 
               // bunifuElipse1
               // 
               this.bunifuElipse1.ElipseRadius = 25;
               this.bunifuElipse1.TargetControl = this;
               // 
               // bunifuDragControl1
               // 
               this.bunifuDragControl1.Fixed = true;
               this.bunifuDragControl1.Horizontal = true;
               this.bunifuDragControl1.TargetControl = this.panelLeft;
               this.bunifuDragControl1.Vertical = true;
               // 
               // panelChildForm
               // 
               this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panelChildForm.Location = new System.Drawing.Point(374, 0);
               this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.panelChildForm.Name = "panelChildForm";
               this.panelChildForm.Size = new System.Drawing.Size(402, 627);
               this.panelChildForm.TabIndex = 1;
               // 
               // MainForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(776, 627);
               this.Controls.Add(this.panelChildForm);
               this.Controls.Add(this.panelLeft);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.Name = "MainForm";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form1";
               this.panelLeft.ResumeLayout(false);
               this.panelLeft.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
          private System.Windows.Forms.Panel panelChildForm;
          private System.Windows.Forms.Label labelWelcomeNewUser;
     }
}

