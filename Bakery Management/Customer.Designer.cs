using System;
using System.Windows.Forms;

namespace Bakery_Management
{
    public partial class customerLogin : Form
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerLogin));
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPlease = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ButtonStaff = new Guna.UI2.WinForms.Guna2Button();
            this.labelStaff = new System.Windows.Forms.Label();
            this.guna2PanelBeige = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButtonBread = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLoginCustomer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2PanelWhite = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBoxCookie = new System.Windows.Forms.PictureBox();
            this.guna2PanelBeige.SuspendLayout();
            this.guna2PanelWhite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCookie)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.AutoRoundedCorners = true;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
            this.txtUsername.BorderRadius = 31;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(408, 253);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtUsername.PlaceholderText = "username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(367, 64);
            this.txtUsername.TabIndex = 0;
            // 
            // labelPlease
            // 
            this.labelPlease.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.labelPlease.Location = new System.Drawing.Point(347, 70);
            this.labelPlease.Name = "labelPlease";
            this.labelPlease.Size = new System.Drawing.Size(486, 75);
            this.labelPlease.TabIndex = 2;
            this.labelPlease.Text = "Please sign in";
            this.labelPlease.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.labelusername.Location = new System.Drawing.Point(402, 217);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(151, 32);
            this.labelusername.TabIndex = 3;
            this.labelusername.Text = "username";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.labelpassword.Location = new System.Drawing.Point(414, 0);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(149, 32);
            this.labelpassword.TabIndex = 4;
            this.labelpassword.Text = "password";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoRoundedCorners = true;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
            this.txtPassword.BorderRadius = 31;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(420, 40);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtPassword.PlaceholderText = "password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(367, 64);
            this.txtPassword.TabIndex = 5;
            // 
            // guna2ButtonStaff
            // 
            this.guna2ButtonStaff.AutoRoundedCorners = true;
            this.guna2ButtonStaff.BorderRadius = 25;
            this.guna2ButtonStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
            this.guna2ButtonStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonStaff.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonStaff.Location = new System.Drawing.Point(482, 218);
            this.guna2ButtonStaff.Name = "guna2ButtonStaff";
            this.guna2ButtonStaff.Size = new System.Drawing.Size(206, 53);
            this.guna2ButtonStaff.TabIndex = 6;
            this.guna2ButtonStaff.Text = "staff sign in";
            this.guna2ButtonStaff.Click += new System.EventHandler(this.guna2ButtonStaff_Click);
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.labelStaff.Location = new System.Drawing.Point(489, 196);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(145, 20);
            this.labelStaff.TabIndex = 7;
            this.labelStaff.Text = "staff ? click here";
            // 
            // guna2PanelBeige
            // 
            this.guna2PanelBeige.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
            this.guna2PanelBeige.Controls.Add(this.guna2ImageButtonBread);
            this.guna2PanelBeige.Controls.Add(this.btnLoginCustomer);
            this.guna2PanelBeige.Controls.Add(this.labelStaff);
            this.guna2PanelBeige.Controls.Add(this.guna2ButtonStaff);
            this.guna2PanelBeige.Controls.Add(this.txtPassword);
            this.guna2PanelBeige.Controls.Add(this.labelpassword);
            this.guna2PanelBeige.Location = new System.Drawing.Point(-12, 351);
            this.guna2PanelBeige.Name = "guna2PanelBeige";
            this.guna2PanelBeige.Size = new System.Drawing.Size(1210, 386);
            this.guna2PanelBeige.TabIndex = 8;
            // 
            // guna2ImageButtonBread
            // 
            this.guna2ImageButtonBread.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButtonBread.HoverState.ImageSize = new System.Drawing.Size(400, 400);
            this.guna2ImageButtonBread.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButtonBread.Image")));
            this.guna2ImageButtonBread.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButtonBread.ImageRotate = 0F;
            this.guna2ImageButtonBread.ImageSize = new System.Drawing.Size(400, 400);
            this.guna2ImageButtonBread.Location = new System.Drawing.Point(822, 28);
            this.guna2ImageButtonBread.Name = "guna2ImageButtonBread";
            this.guna2ImageButtonBread.PressedState.ImageSize = new System.Drawing.Size(400, 400);
            this.guna2ImageButtonBread.Size = new System.Drawing.Size(385, 277);
            this.guna2ImageButtonBread.TabIndex = 11;
            // 
            // btnLoginCustomer
            // 
            this.btnLoginCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
            this.btnLoginCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoginCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoginCustomer.FillColor = System.Drawing.Color.White;
            this.btnLoginCustomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F);
            this.btnLoginCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
            this.btnLoginCustomer.Location = new System.Drawing.Point(725, 48);
            this.btnLoginCustomer.Name = "btnLoginCustomer";
            this.btnLoginCustomer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLoginCustomer.Size = new System.Drawing.Size(49, 48);
            this.btnLoginCustomer.TabIndex = 8;
            this.btnLoginCustomer.Text = ">";
            this.btnLoginCustomer.Click += new System.EventHandler(this.btnLoginCustomer_Click);
            // 
            // guna2PanelWhite
            // 
            this.guna2PanelWhite.Controls.Add(this.pictureBoxCookie);
            this.guna2PanelWhite.Controls.Add(this.labelPlease);
            this.guna2PanelWhite.Controls.Add(this.labelusername);
            this.guna2PanelWhite.Controls.Add(this.txtUsername);
            this.guna2PanelWhite.Location = new System.Drawing.Point(0, 1);
            this.guna2PanelWhite.Name = "guna2PanelWhite";
            this.guna2PanelWhite.Size = new System.Drawing.Size(1195, 351);
            this.guna2PanelWhite.TabIndex = 9;
            this.guna2PanelWhite.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2PanelWhite_Paint);
            // 
            // pictureBoxCookie
            // 
            this.pictureBoxCookie.Image = global::Bakery_Management.Properties.Resources.photo_2025_06_16_23_28_08_removebg_preview;
            this.pictureBoxCookie.Location = new System.Drawing.Point(0, 11);
            this.pictureBoxCookie.Name = "pictureBoxCookie";
            this.pictureBoxCookie.Size = new System.Drawing.Size(341, 340);
            this.pictureBoxCookie.TabIndex = 10;
            this.pictureBoxCookie.TabStop = false;
            // 
            // customerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 655);
            this.Controls.Add(this.guna2PanelWhite);
            this.Controls.Add(this.guna2PanelBeige);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2PanelBeige.ResumeLayout(false);
            this.guna2PanelBeige.PerformLayout();
            this.guna2PanelWhite.ResumeLayout(false);
            this.guna2PanelWhite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCookie)).EndInit();
            this.ResumeLayout(false);

        }
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label labelPlease;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelpassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonStaff;
        private System.Windows.Forms.Label labelStaff;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelBeige;
        private Guna.UI2.WinForms.Guna2CircleButton btnLoginCustomer;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelWhite;
        private System.Windows.Forms.PictureBox pictureBoxCookie;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButtonBread;
    }
}

