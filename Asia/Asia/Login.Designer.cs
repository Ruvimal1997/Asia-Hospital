namespace Asia
{
    partial class Login
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Uname = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Pname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(100, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "UserName";
            // 
            // Txt_Uname
            // 
            // 
            // 
            // 
            this.Txt_Uname.CustomButton.Image = null;
            this.Txt_Uname.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.Txt_Uname.CustomButton.Name = "";
            this.Txt_Uname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Uname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Uname.CustomButton.TabIndex = 1;
            this.Txt_Uname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Uname.CustomButton.UseSelectable = true;
            this.Txt_Uname.CustomButton.Visible = false;
            this.Txt_Uname.Lines = new string[0];
            this.Txt_Uname.Location = new System.Drawing.Point(231, 103);
            this.Txt_Uname.MaxLength = 32767;
            this.Txt_Uname.Name = "Txt_Uname";
            this.Txt_Uname.PasswordChar = '\0';
            this.Txt_Uname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Uname.SelectedText = "";
            this.Txt_Uname.SelectionLength = 0;
            this.Txt_Uname.SelectionStart = 0;
            this.Txt_Uname.ShortcutsEnabled = true;
            this.Txt_Uname.Size = new System.Drawing.Size(144, 23);
            this.Txt_Uname.TabIndex = 1;
            this.Txt_Uname.UseSelectable = true;
            this.Txt_Uname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Uname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Pname
            // 
            // 
            // 
            // 
            this.Txt_Pname.CustomButton.Image = null;
            this.Txt_Pname.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.Txt_Pname.CustomButton.Name = "";
            this.Txt_Pname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Pname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Pname.CustomButton.TabIndex = 1;
            this.Txt_Pname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Pname.CustomButton.UseSelectable = true;
            this.Txt_Pname.CustomButton.Visible = false;
            this.Txt_Pname.Lines = new string[0];
            this.Txt_Pname.Location = new System.Drawing.Point(231, 141);
            this.Txt_Pname.MaxLength = 32767;
            this.Txt_Pname.Name = "Txt_Pname";
            this.Txt_Pname.PasswordChar = '*';
            this.Txt_Pname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Pname.SelectedText = "";
            this.Txt_Pname.SelectionLength = 0;
            this.Txt_Pname.SelectionStart = 0;
            this.Txt_Pname.ShortcutsEnabled = true;
            this.Txt_Pname.Size = new System.Drawing.Size(144, 23);
            this.Txt_Pname.TabIndex = 2;
            this.Txt_Pname.UseSelectable = true;
            this.Txt_Pname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Pname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(100, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Password";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(120, 230);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Login";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(201, 230);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 323);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Txt_Pname);
            this.Controls.Add(this.Txt_Uname);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Txt_Uname;
        private MetroFramework.Controls.MetroTextBox Txt_Pname;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

