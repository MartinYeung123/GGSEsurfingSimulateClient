using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace GGSEsurfing
{
    public partial class Form1 : Form
    {
        public static string token="" ;
        public static string wlanuserip;

        private void Form1_Load(object sender, EventArgs e)
        {
            //检查是否多开
            Process[] processes = Process.GetProcesses();
            Process currentProcess = Process.GetCurrentProcess();
            bool processExit = false;
            
            foreach (Process p in processes)
            {
                if (p.ProcessName == currentProcess.ProcessName && p.Id != currentProcess.Id)
                {
                    processExit = true;
                }
            }
            if (processExit)
            {
                MessageBox.Show("程序已经运行！");
                Environment.Exit(0);
            }

        }
        private void account_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        //打印日志 
        public void displayLog(string log)
        {
            richTextBox1.AppendText(DateTime.Now.ToString("HH:mm:ss") + log + "\r\n");
        }
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            displayLog("软件已启动");
            //token = Common.GetConfig("fsurfing", "NASIP");

            wlanuserip = Common.GetConfig("ggssurfing", "USERIP");
            account_textBox.Text = Common.GetConfig("ggssurfing", "username");
            password_textBox.Text = Common.GetConfig("ggssurfing", "password");
            autoLogin.Checked= Convert.ToBoolean(Common.GetConfig("ggssurfing", "autoLogin"));
            restart_Check.Checked= Convert.ToBoolean(Common.GetConfig("ggssurfing", "restartLogin"));
        }

       public void login_surfing()
        {
            int i = 0;
            surfingcontent sr = new surfingcontent(account_textBox.Text, password_textBox.Text, wlanuserip, surfingcontent._nasip, surfingcontent._macCode);
            displayLog("fsurfing,正在尝试登录");
            token = sr.GetToken(sr.PostChallenge());
            if (token != "failed")
            {
                //MessageBox.Show(token);
                string result = sr.PostLogin(token);
                string[] code = result.Split('"');


                if (code[3] == "0")
                {

                    displayLog("天翼模拟登录成功");
                    displayLog(result);
                    notifyIcon1.ShowBalloonTip(5000, "提示", "天翼模拟登录成功", ToolTipIcon.Info);
                    Login_button.Enabled = false;
                    Visible = false;
                    notifyIcon1.ShowBalloonTip(5000, "提示", "登录器已最小化", ToolTipIcon.Info);
                    if (sr.Heartbeat() != "failed")
                    {
                        //displayLog("fsurfing,Send heartbeat");
                        Thread.Sleep(6000);
                    }
                    else
                    {
                        MessageBox.Show("网络中断");
                        notifyIcon1.ShowBalloonTip(5000, "提示", "网络中断", ToolTipIcon.Warning);
                    }

                }
                else if (code[3] == "11064000")
                {
                    MessageBox.Show("天翼账号被锁定");
                    displayLog("天翼账号被锁定");
                }
                else
                {
                    displayLog("账号密码错误或服务器未响应");
                    MessageBox.Show("账号密码错误或服务器未响应");
                }
            }
            else
            {
                displayLog("网络中断");
                MessageBox.Show("网络中断");
                notifyIcon1.ShowBalloonTip(5000, "提示", "网络中断", ToolTipIcon.Error);
            }
                
        }
        public void logout_surfing()
        {
            surfingcontent sr = new surfingcontent(account_textBox.Text, password_textBox.Text, wlanuserip, surfingcontent._nasip, surfingcontent._macCode);
            if (token!= "failed")
            {
                token = sr.GetToken(sr.PostLogout());
                Login_button.Enabled = true;
                displayLog("注销成功");
                MessageBox.Show("注销成功");
            }
            else
            {
                displayLog("注销失败");
                MessageBox.Show("注销失败");
            }

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if(account_textBox.Text!=""||password_textBox.Text!="")
            {
                login_surfing();
                Common.SaveConfig("ggssurfing", "USERIP", wlanuserip);
                Common.SaveConfig("ggssurfing", "username", account_textBox.Text);
                Common.SaveConfig("ggssurfing", "password", password_textBox.Text);
                Common.SaveConfig("ggssurfing", "autoLogin", autoLogin.Checked.ToString());
                Common.SaveConfig("ggssurfing", "restartLogin", restart_Check.Checked.ToString());  
            }
            else
            {
                MessageBox.Show("账号密码为空");
            }
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            logout_surfing();
        }

        private void opintion_menu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(this);
        }

        private void aboutText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("首次使用要设置NACIP和USERIP，NACIP和USERIP就是网页地址栏上的wlannacip和wlanserip");
        }

        private void nIcon_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    this.Activate();
                    Visible = true;
                    ShowInTaskbar = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition);
            }
        }

        private void Exit_Down_Menu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你确定要关闭吗！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                // 关闭所有的线程
                Dispose();
                Close();
            }
        }

        private void Sigin_Down_menu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(this);
        }

        private void Link_Down_Menu_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(5000, "提示", "登录器已最小化", ToolTipIcon.Info);
            login_surfing();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("你确定要关闭吗！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                // 关闭所有的线程
                Dispose();
                Close();
            }
            else
            {
                e.Cancel = true;
                Visible = false;
                notifyIcon1.ShowBalloonTip(5000, "提示", "登录器已最小化", ToolTipIcon.Info);
            }
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //自动连接
            if (autoLogin.Checked != false)
            {
                if (account_textBox.Text != "" || password_textBox.Text != "")
                {

                    login_surfing();

                }
                else
                {
                    MessageBox.Show("账号密码为空");
                }
            }
        }

        private void restart_Check_CheckedChanged(object sender, EventArgs e)
        {
            //自启判断
            try
            {
                if (restart_Check.Checked != false)
                {
                    displayLog("自启设置成功");
                    string path = Application.StartupPath;
                    RegistryKey rk = Registry.LocalMachine;
                    RegistryKey R_run = rk.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.SetValue("GGSEurfing", Application.ExecutablePath);
                    R_run.Close();
                    rk.Close();
                }
                else
                {
                    displayLog("自启设置取消");
                    RegistryKey rk = Registry.LocalMachine;
                    RegistryKey R_run = rk.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.SetValue("GGSEurfing", false);
                    R_run.Close();
                    rk.Close();
                }
            }
            catch
            {
                displayLog("自启设置失败");
                MessageBox.Show("请设置为管理员模式打开");
            }
        }
    }
}
