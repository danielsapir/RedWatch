namespace RedWatchWatchOwner
{
     partial class GeneratedCodeEnterForm
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
               this.buttonRegister = new System.Windows.Forms.Button();
               this.buttonCancel = new System.Windows.Forms.Button();
               this.TextboxGeneratedCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
               this.label2 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // buttonRegister
               // 
               this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.buttonRegister.Enabled = false;
               this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.buttonRegister.ForeColor = System.Drawing.Color.White;
               this.buttonRegister.Location = new System.Drawing.Point(20, 153);
               this.buttonRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.buttonRegister.Name = "buttonRegister";
               this.buttonRegister.Size = new System.Drawing.Size(346, 39);
               this.buttonRegister.TabIndex = 2;
               this.buttonRegister.Text = "Register";
               this.buttonRegister.UseVisualStyleBackColor = false;
               this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
               // 
               // buttonCancel
               // 
               this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.buttonCancel.ForeColor = System.Drawing.Color.White;
               this.buttonCancel.Location = new System.Drawing.Point(20, 213);
               this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.buttonCancel.Name = "buttonCancel";
               this.buttonCancel.Size = new System.Drawing.Size(346, 39);
               this.buttonCancel.TabIndex = 2;
               this.buttonCancel.Text = "Cancel";
               this.buttonCancel.UseVisualStyleBackColor = false;
               this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
               // 
               // TextboxGeneratedCode
               // 
               this.TextboxGeneratedCode.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.TextboxGeneratedCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.TextboxGeneratedCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.TextboxGeneratedCode.HintForeColor = System.Drawing.Color.Empty;
               this.TextboxGeneratedCode.HintText = "";
               this.TextboxGeneratedCode.isPassword = false;
               this.TextboxGeneratedCode.LineFocusedColor = System.Drawing.Color.Black;
               this.TextboxGeneratedCode.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.TextboxGeneratedCode.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.TextboxGeneratedCode.LineThickness = 3;
               this.TextboxGeneratedCode.Location = new System.Drawing.Point(24, 89);
               this.TextboxGeneratedCode.Margin = new System.Windows.Forms.Padding(5);
               this.TextboxGeneratedCode.Name = "TextboxGeneratedCode";
               this.TextboxGeneratedCode.Size = new System.Drawing.Size(346, 36);
               this.TextboxGeneratedCode.TabIndex = 1;
               this.TextboxGeneratedCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
               this.TextboxGeneratedCode.OnValueChanged += new System.EventHandler(this.TextboxGeneratedCode_OnValueChanged);
               this.TextboxGeneratedCode.Leave += new System.EventHandler(this.TextboxGeneratedCode_Leave);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.label2.Location = new System.Drawing.Point(20, 63);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(358, 21);
               this.label2.TabIndex = 0;
               this.label2.Text = "Enter The Code You Got On Your Email Here:";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.label4.Location = new System.Drawing.Point(24, 9);
               this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(316, 30);
               this.label4.TabIndex = 0;
               this.label4.Text = "One Step From Joining Us";
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.SystemColors.Control;
               this.panel1.Controls.Add(this.buttonRegister);
               this.panel1.Controls.Add(this.TextboxGeneratedCode);
               this.panel1.Controls.Add(this.buttonCancel);
               this.panel1.Controls.Add(this.label2);
               this.panel1.Controls.Add(this.label4);
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(401, 261);
               this.panel1.TabIndex = 3;
               // 
               // GeneratedCodeEnterForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(401, 261);
               this.Controls.Add(this.panel1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "GeneratedCodeEnterForm";
               this.Text = "GenratedCodeEnterForm";
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Button buttonRegister;
          private System.Windows.Forms.Button buttonCancel;
          private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxGeneratedCode;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Panel panel1;
     }
}