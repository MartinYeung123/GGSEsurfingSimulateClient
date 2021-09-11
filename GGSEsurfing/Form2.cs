using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGSEsurfing
{
    public partial class Form2 : Form
    {
        public static string address;
        public static string esurfingip;
        public Form2()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            nacip_text.Text = Common.GetConfig("ggssurfing", "NACIP");
            userIP.Text = Common.GetConfig("ggssurfing", "USERIP");
            ESUBox.Text = Common.GetConfig("ggssurfing", "ESURIP");
            macBox.Text = Common.GetConfig("ggssurfing", "MAC");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            
            Form1.wlanuserip = userIP.Text;
            Common.SaveConfig("ggssurfing", "NACIP", surfingcontent._nasip);
            Common.SaveConfig("ggssurfing", "ESURIP", ESUBox.Text);
            Common.SaveConfig("ggssurfing", "MAC", macBox.Text);
            surfingcontent._nasip = nacip_text.Text;
            surfingcontent._macCode = macBox.Text;
            Close();
        }

        private void macbutton1_Click(object sender, EventArgs e)
        {
            macBox.Text=surfingcontent.GetMacCodeDown(address);
            ESUBox.Text = surfingcontent.EsurfingIP(esurfingip);


        }
    }
}
