namespace GGSEsurfing
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.account_label = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.account_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opintion_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutText = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Link_Down_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Sigin_Down_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_Down_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.autoLogin = new System.Windows.Forms.CheckBox();
            this.restart_Check = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // account_label
            // 
            this.account_label.AutoSize = true;
            this.account_label.Location = new System.Drawing.Point(8, 35);
            this.account_label.Name = "account_label";
            this.account_label.Size = new System.Drawing.Size(29, 12);
            this.account_label.TabIndex = 0;
            this.account_label.Text = "账号";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(8, 72);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(29, 12);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "密码";
            // 
            // account_textBox
            // 
            this.account_textBox.Location = new System.Drawing.Point(43, 32);
            this.account_textBox.Name = "account_textBox";
            this.account_textBox.Size = new System.Drawing.Size(168, 21);
            this.account_textBox.TabIndex = 2;
            this.account_textBox.TextChanged += new System.EventHandler(this.account_textBox_TextChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(43, 69);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(168, 21);
            this.password_textBox.TabIndex = 3;
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(12, 121);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(75, 23);
            this.Login_button.TabIndex = 4;
            this.Login_button.Text = "登录";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(136, 121);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 23);
            this.logout_button.TabIndex = 5;
            this.logout_button.Text = "注销";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.aboutText,
            this.smi_exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(225, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opintion_menu,
            this.Exit_menu});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // opintion_menu
            // 
            this.opintion_menu.Name = "opintion_menu";
            this.opintion_menu.Size = new System.Drawing.Size(100, 22);
            this.opintion_menu.Text = "设置";
            this.opintion_menu.Click += new System.EventHandler(this.opintion_menu_Click);
            // 
            // Exit_menu
            // 
            this.Exit_menu.Name = "Exit_menu";
            this.Exit_menu.Size = new System.Drawing.Size(100, 22);
            this.Exit_menu.Text = "退出";
            // 
            // aboutText
            // 
            this.aboutText.Name = "aboutText";
            this.aboutText.Size = new System.Drawing.Size(44, 21);
            this.aboutText.Text = "关于";
            this.aboutText.Click += new System.EventHandler(this.aboutText_Click);
            // 
            // smi_exit
            // 
            this.smi_exit.Name = "smi_exit";
            this.smi_exit.Size = new System.Drawing.Size(136, 21);
            this.smi_exit.Text = "toolStripMenuItem1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "@CopyRight MartinYeung";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "GGS天翼登录器";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nIcon_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Link_Down_Menu,
            this.Sigin_Down_menu,
            this.Exit_Down_Menu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // Link_Down_Menu
            // 
            this.Link_Down_Menu.Name = "Link_Down_Menu";
            this.Link_Down_Menu.Size = new System.Drawing.Size(100, 22);
            this.Link_Down_Menu.Text = "连接";
            this.Link_Down_Menu.Click += new System.EventHandler(this.Link_Down_Menu_Click);
            // 
            // Sigin_Down_menu
            // 
            this.Sigin_Down_menu.Name = "Sigin_Down_menu";
            this.Sigin_Down_menu.Size = new System.Drawing.Size(100, 22);
            this.Sigin_Down_menu.Text = "设置";
            this.Sigin_Down_menu.Click += new System.EventHandler(this.Sigin_Down_menu_Click);
            // 
            // Exit_Down_Menu
            // 
            this.Exit_Down_Menu.Name = "Exit_Down_Menu";
            this.Exit_Down_Menu.Size = new System.Drawing.Size(100, 22);
            this.Exit_Down_Menu.Text = "退出";
            this.Exit_Down_Menu.Click += new System.EventHandler(this.Exit_Down_Menu_Click);
            // 
            // autoLogin
            // 
            this.autoLogin.AutoSize = true;
            this.autoLogin.Location = new System.Drawing.Point(133, 96);
            this.autoLogin.Name = "autoLogin";
            this.autoLogin.Size = new System.Drawing.Size(72, 16);
            this.autoLogin.TabIndex = 8;
            this.autoLogin.Text = "自动连接";
            this.autoLogin.UseVisualStyleBackColor = true;
            // 
            // restart_Check
            // 
            this.restart_Check.AutoSize = true;
            this.restart_Check.Location = new System.Drawing.Point(28, 96);
            this.restart_Check.Name = "restart_Check";
            this.restart_Check.Size = new System.Drawing.Size(72, 16);
            this.restart_Check.TabIndex = 9;
            this.restart_Check.Text = "开机自启";
            this.restart_Check.UseVisualStyleBackColor = true;
            this.restart_Check.CheckedChanged += new System.EventHandler(this.restart_Check_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 150);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(203, 122);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 296);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.restart_Check);
            this.Controls.Add(this.autoLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.account_textBox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.account_label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GGS天翼登录器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label account_label;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox account_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opintion_menu;
        private System.Windows.Forms.ToolStripMenuItem Exit_menu;
        private System.Windows.Forms.ToolStripMenuItem aboutText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem smi_exit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Link_Down_Menu;
        private System.Windows.Forms.ToolStripMenuItem Sigin_Down_menu;
        private System.Windows.Forms.ToolStripMenuItem Exit_Down_Menu;
        private System.Windows.Forms.CheckBox autoLogin;
        private System.Windows.Forms.CheckBox restart_Check;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

