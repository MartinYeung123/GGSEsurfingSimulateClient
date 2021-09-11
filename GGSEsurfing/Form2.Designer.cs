namespace GGSEsurfing
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Save_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nacip_text = new System.Windows.Forms.TextBox();
            this.macBox = new System.Windows.Forms.TextBox();
            this.LABEL3 = new System.Windows.Forms.Label();
            this.macbutton1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ESUBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(124, 144);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 2;
            this.Save_button.Text = "保存";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "USERIP";
            // 
            // userIP
            // 
            this.userIP.Location = new System.Drawing.Point(57, 21);
            this.userIP.Name = "userIP";
            this.userIP.Size = new System.Drawing.Size(142, 21);
            this.userIP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "NACIP";
            // 
            // nacip_text
            // 
            this.nacip_text.Location = new System.Drawing.Point(57, 48);
            this.nacip_text.Name = "nacip_text";
            this.nacip_text.Size = new System.Drawing.Size(142, 21);
            this.nacip_text.TabIndex = 6;
            // 
            // macBox
            // 
            this.macBox.Location = new System.Drawing.Point(57, 102);
            this.macBox.Name = "macBox";
            this.macBox.Size = new System.Drawing.Size(142, 21);
            this.macBox.TabIndex = 7;
            // 
            // LABEL3
            // 
            this.LABEL3.AutoSize = true;
            this.LABEL3.Location = new System.Drawing.Point(15, 107);
            this.LABEL3.Name = "LABEL3";
            this.LABEL3.Size = new System.Drawing.Size(23, 12);
            this.LABEL3.TabIndex = 8;
            this.LABEL3.Text = "MAC";
            // 
            // macbutton1
            // 
            this.macbutton1.Location = new System.Drawing.Point(43, 144);
            this.macbutton1.Name = "macbutton1";
            this.macbutton1.Size = new System.Drawing.Size(75, 23);
            this.macbutton1.TabIndex = 9;
            this.macbutton1.Text = "获取网卡";
            this.macbutton1.UseVisualStyleBackColor = true;
            this.macbutton1.Click += new System.EventHandler(this.macbutton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "ESUIP";
            // 
            // ESUBox
            // 
            this.ESUBox.Location = new System.Drawing.Point(57, 75);
            this.ESUBox.Name = "ESUBox";
            this.ESUBox.Size = new System.Drawing.Size(142, 21);
            this.ESUBox.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 185);
            this.Controls.Add(this.ESUBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.macbutton1);
            this.Controls.Add(this.LABEL3);
            this.Controls.Add(this.macBox);
            this.Controls.Add(this.nacip_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Save_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nacip_text;
        private System.Windows.Forms.TextBox macBox;
        private System.Windows.Forms.Label LABEL3;
        private System.Windows.Forms.Button macbutton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ESUBox;
    }
}