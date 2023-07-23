namespace SKYNET
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.BT_Auth = new SKYNET_Button();
            this.PN_Top = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.skyneT_Box3 = new SKYNET.Controls.SKYNET_Box();
            this.MinimizeBox = new SKYNET.Controls.SKYNET_Box();
            this.CloseBox = new SKYNET.Controls.SKYNET_Box();
            this.TB_Servers = new SKYNET.Controls.SKYNET_TextBox();
            this.TB_Username = new SKYNET.Controls.SKYNET_TextBox();
            this.TB_Password = new SKYNET.Controls.SKYNET_TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PN_Status = new System.Windows.Forms.Panel();
            this.LB_Info = new System.Windows.Forms.Label();
            this.CH_AutoConnect = new SKYNET.Controls.SKYNET_Check();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_PreSharedKey = new SKYNET.Controls.SKYNET_TextBox();
            this.PN_Top.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Auth
            // 
            this.BT_Auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.BT_Auth.BackColorMouseOver = System.Drawing.Color.Empty;
            this.BT_Auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_Auth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BT_Auth.ForeColor = System.Drawing.Color.White;
            this.BT_Auth.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.BT_Auth.ImageAlignment = SKYNET_Button._ImgAlign.Left;
            this.BT_Auth.ImageIcon = null;
            this.BT_Auth.Location = new System.Drawing.Point(287, 233);
            this.BT_Auth.MenuMode = false;
            this.BT_Auth.Name = "BT_Auth";
            this.BT_Auth.Rounded = false;
            this.BT_Auth.Size = new System.Drawing.Size(220, 35);
            this.BT_Auth.Style = SKYNET_Button._Style.TextOnly;
            this.BT_Auth.TabIndex = 1;
            this.BT_Auth.Text = "Conectar";
            this.BT_Auth.Click += new System.EventHandler(this.BT_Auth_Click);
            // 
            // PN_Top
            // 
            this.PN_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.PN_Top.Controls.Add(this.label5);
            this.PN_Top.Controls.Add(this.label4);
            this.PN_Top.Controls.Add(this.skyneT_Box3);
            this.PN_Top.Controls.Add(this.MinimizeBox);
            this.PN_Top.Controls.Add(this.CloseBox);
            this.PN_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Top.Location = new System.Drawing.Point(0, 0);
            this.PN_Top.Name = "PN_Top";
            this.PN_Top.Size = new System.Drawing.Size(539, 85);
            this.PN_Top.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(253, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "L2TP Client";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(474, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "SKYNET";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skyneT_Box3
            // 
            this.skyneT_Box3.Color = System.Drawing.Color.Empty;
            this.skyneT_Box3.Dock = System.Windows.Forms.DockStyle.Right;
            this.skyneT_Box3.FocusedColor = System.Drawing.Color.Empty;
            this.skyneT_Box3.Image = null;
            this.skyneT_Box3.ImageSize = 10;
            this.skyneT_Box3.Location = new System.Drawing.Point(437, 0);
            this.skyneT_Box3.MaximumSize = new System.Drawing.Size(34, 26);
            this.skyneT_Box3.MenuMode = false;
            this.skyneT_Box3.MenuSeparation = 8;
            this.skyneT_Box3.MinimumSize = new System.Drawing.Size(34, 26);
            this.skyneT_Box3.Name = "skyneT_Box3";
            this.skyneT_Box3.Size = new System.Drawing.Size(34, 26);
            this.skyneT_Box3.TabIndex = 2;
            // 
            // MinimizeBox
            // 
            this.MinimizeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.MinimizeBox.Color = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.MinimizeBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.MinimizeBox.Image = global::SKYNET.Properties.Resources.minimise;
            this.MinimizeBox.ImageSize = 10;
            this.MinimizeBox.Location = new System.Drawing.Point(471, 0);
            this.MinimizeBox.MaximumSize = new System.Drawing.Size(34, 26);
            this.MinimizeBox.MenuMode = false;
            this.MinimizeBox.MenuSeparation = 8;
            this.MinimizeBox.MinimumSize = new System.Drawing.Size(34, 26);
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.Size = new System.Drawing.Size(34, 26);
            this.MinimizeBox.TabIndex = 1;
            this.MinimizeBox.BoxClicked += new System.EventHandler(this.MinimizeBox_BoxClicked);
            // 
            // CloseBox
            // 
            this.CloseBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.CloseBox.Color = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.CloseBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.CloseBox.Image = global::SKYNET.Properties.Resources.close;
            this.CloseBox.ImageSize = 10;
            this.CloseBox.Location = new System.Drawing.Point(505, 0);
            this.CloseBox.MaximumSize = new System.Drawing.Size(34, 26);
            this.CloseBox.MenuMode = false;
            this.CloseBox.MenuSeparation = 8;
            this.CloseBox.MinimumSize = new System.Drawing.Size(34, 26);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(34, 26);
            this.CloseBox.TabIndex = 0;
            this.CloseBox.BoxClicked += new System.EventHandler(this.CloseBox_BoxClicked);
            // 
            // TB_Servers
            // 
            this.TB_Servers.ActivatedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Servers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Servers.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Servers.ForeColor = System.Drawing.Color.White;
            this.TB_Servers.IsPassword = false;
            this.TB_Servers.Location = new System.Drawing.Point(30, 122);
            this.TB_Servers.Logo = global::SKYNET.Properties.Resources.networking_manager_100px;
            this.TB_Servers.LogoCursor = System.Windows.Forms.Cursors.Default;
            this.TB_Servers.Multiline = false;
            this.TB_Servers.Name = "TB_Servers";
            this.TB_Servers.OnlyNumbers = false;
            this.TB_Servers.ShowLogo = true;
            this.TB_Servers.Size = new System.Drawing.Size(220, 35);
            this.TB_Servers.TabIndex = 4;
            this.TB_Servers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TB_Username
            // 
            this.TB_Username.ActivatedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Username.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Username.ForeColor = System.Drawing.Color.White;
            this.TB_Username.IsPassword = false;
            this.TB_Username.Location = new System.Drawing.Point(287, 122);
            this.TB_Username.Logo = global::SKYNET.Properties.Resources.male_user_100px;
            this.TB_Username.LogoCursor = System.Windows.Forms.Cursors.Default;
            this.TB_Username.Multiline = false;
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.OnlyNumbers = false;
            this.TB_Username.ShowLogo = true;
            this.TB_Username.Size = new System.Drawing.Size(220, 35);
            this.TB_Username.TabIndex = 5;
            this.TB_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TB_Password
            // 
            this.TB_Password.ActivatedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Password.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Password.ForeColor = System.Drawing.Color.White;
            this.TB_Password.IsPassword = true;
            this.TB_Password.Location = new System.Drawing.Point(287, 183);
            this.TB_Password.Logo = global::SKYNET.Properties.Resources.key_2_60px;
            this.TB_Password.LogoCursor = System.Windows.Forms.Cursors.Default;
            this.TB_Password.Multiline = false;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.OnlyNumbers = false;
            this.TB_Password.ShowLogo = true;
            this.TB_Password.Size = new System.Drawing.Size(220, 35);
            this.TB_Password.TabIndex = 6;
            this.TB_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(284, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.PN_Status);
            this.panel2.Controls.Add(this.LB_Info);
            this.panel2.Location = new System.Drawing.Point(30, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 33);
            this.panel2.TabIndex = 11;
            // 
            // PN_Status
            // 
            this.PN_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PN_Status.Location = new System.Drawing.Point(0, 30);
            this.PN_Status.Name = "PN_Status";
            this.PN_Status.Size = new System.Drawing.Size(477, 3);
            this.PN_Status.TabIndex = 16;
            // 
            // LB_Info
            // 
            this.LB_Info.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.LB_Info.ForeColor = System.Drawing.Color.White;
            this.LB_Info.Location = new System.Drawing.Point(6, 7);
            this.LB_Info.Name = "LB_Info";
            this.LB_Info.Size = new System.Drawing.Size(455, 17);
            this.LB_Info.TabIndex = 20;
            // 
            // CH_AutoConnect
            // 
            this.CH_AutoConnect.BackColor = System.Drawing.Color.Transparent;
            this.CH_AutoConnect.Checked = false;
            this.CH_AutoConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CH_AutoConnect.Location = new System.Drawing.Point(216, 238);
            this.CH_AutoConnect.Name = "CH_AutoConnect";
            this.CH_AutoConnect.Size = new System.Drawing.Size(34, 25);
            this.CH_AutoConnect.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(27, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Conectar al iniciar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Clave previamente compartida";
            // 
            // TB_PreSharedKey
            // 
            this.TB_PreSharedKey.ActivatedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_PreSharedKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_PreSharedKey.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_PreSharedKey.ForeColor = System.Drawing.Color.White;
            this.TB_PreSharedKey.IsPassword = true;
            this.TB_PreSharedKey.Location = new System.Drawing.Point(30, 183);
            this.TB_PreSharedKey.Logo = global::SKYNET.Properties.Resources.key_2_60px;
            this.TB_PreSharedKey.LogoCursor = System.Windows.Forms.Cursors.Default;
            this.TB_PreSharedKey.Multiline = false;
            this.TB_PreSharedKey.Name = "TB_PreSharedKey";
            this.TB_PreSharedKey.OnlyNumbers = false;
            this.TB_PreSharedKey.ShowLogo = true;
            this.TB_PreSharedKey.Size = new System.Drawing.Size(220, 35);
            this.TB_PreSharedKey.TabIndex = 14;
            this.TB_PreSharedKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(539, 357);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_PreSharedKey);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CH_AutoConnect);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.TB_Servers);
            this.Controls.Add(this.PN_Top);
            this.Controls.Add(this.BT_Auth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1360, 728);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISP CUBA ONLINE";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.PN_Top.ResumeLayout(false);
            this.PN_Top.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SKYNET_Button BT_Auth;
        private System.Windows.Forms.Panel PN_Top;
        private Controls.SKYNET_Box skyneT_Box3;
        private Controls.SKYNET_Box MinimizeBox;
        private Controls.SKYNET_Box CloseBox;
        private Controls.SKYNET_TextBox TB_Servers;
        private Controls.SKYNET_TextBox TB_Username;
        private Controls.SKYNET_TextBox TB_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LB_Info;
        private Controls.SKYNET_Check CH_AutoConnect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Controls.SKYNET_TextBox TB_PreSharedKey;
        private System.Windows.Forms.Panel PN_Status;
    }
}

