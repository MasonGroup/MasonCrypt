using System.Reflection;

namespace MasonCrypt
{
    partial class Form1
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
            this.gen = new MetroFramework.Controls.MetroButton();
            this.path = new MetroFramework.Controls.MetroTextBox();
            this.Browserbutton = new MetroFramework.Controls.MetroButton();
            this.sleep = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.antikill = new MetroFramework.Controls.MetroCheckBox();
            this.startup = new MetroFramework.Controls.MetroCheckBox();
            this.antidebug = new MetroFramework.Controls.MetroCheckBox();
            this.wddisable = new MetroFramework.Controls.MetroCheckBox();
            this.uacbypass = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.aboubtn = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(54, 170);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(75, 23);
            this.gen.TabIndex = 1;
            this.gen.Text = "build";
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(10, 40);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(135, 23);
            this.path.TabIndex = 2;
            // 
            // Browserbutton
            // 
            this.Browserbutton.Location = new System.Drawing.Point(10, 69);
            this.Browserbutton.Name = "Browserbutton";
            this.Browserbutton.Size = new System.Drawing.Size(135, 23);
            this.Browserbutton.TabIndex = 3;
            this.Browserbutton.Text = "Browser";
            this.Browserbutton.Click += new System.EventHandler(this.Browserbutton_Click);
            // 
            // sleep
            // 
            this.sleep.Location = new System.Drawing.Point(80, 40);
            this.sleep.Name = "sleep";
            this.sleep.Size = new System.Drawing.Size(125, 23);
            this.sleep.TabIndex = 4;
            this.sleep.Click += new System.EventHandler(this.sleep_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.antikill);
            this.metroPanel1.Controls.Add(this.startup);
            this.metroPanel1.Controls.Add(this.antidebug);
            this.metroPanel1.Controls.Add(this.wddisable);
            this.metroPanel1.Controls.Add(this.uacbypass);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.sleep);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(173, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(244, 167);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // antikill
            // 
            this.antikill.AutoSize = true;
            this.antikill.Location = new System.Drawing.Point(119, 110);
            this.antikill.Name = "antikill";
            this.antikill.Size = new System.Drawing.Size(65, 15);
            this.antikill.TabIndex = 15;
            this.antikill.Text = "Anti-kill";
            this.antikill.UseVisualStyleBackColor = true;
            // 
            // startup
            // 
            this.startup.AutoSize = true;
            this.startup.Location = new System.Drawing.Point(119, 88);
            this.startup.Name = "startup";
            this.startup.Size = new System.Drawing.Size(61, 15);
            this.startup.TabIndex = 14;
            this.startup.Text = "Startup";
            this.startup.UseVisualStyleBackColor = true;
            // 
            // antidebug
            // 
            this.antidebug.AutoSize = true;
            this.antidebug.Location = new System.Drawing.Point(27, 131);
            this.antidebug.Name = "antidebug";
            this.antidebug.Size = new System.Drawing.Size(84, 15);
            this.antidebug.TabIndex = 12;
            this.antidebug.Text = "Anti-debug";
            this.antidebug.UseVisualStyleBackColor = true;
            // 
            // wddisable
            // 
            this.wddisable.AutoSize = true;
            this.wddisable.Location = new System.Drawing.Point(27, 109);
            this.wddisable.Name = "wddisable";
            this.wddisable.Size = new System.Drawing.Size(82, 15);
            this.wddisable.TabIndex = 11;
            this.wddisable.Text = "WD disable";
            this.wddisable.UseVisualStyleBackColor = true;
            // 
            // uacbypass
            // 
            this.uacbypass.AutoSize = true;
            this.uacbypass.Location = new System.Drawing.Point(27, 88);
            this.uacbypass.Name = "uacbypass";
            this.uacbypass.Size = new System.Drawing.Size(86, 15);
            this.uacbypass.TabIndex = 10;
            this.uacbypass.Text = "UAC bypass";
            this.uacbypass.UseVisualStyleBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(100, 11);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(54, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Settings";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Sleep:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "File path:";
            // 
            // aboubtn
            // 
            this.aboubtn.Location = new System.Drawing.Point(54, 200);
            this.aboubtn.Name = "aboubtn";
            this.aboubtn.Size = new System.Drawing.Size(75, 23);
            this.aboubtn.TabIndex = 7;
            this.aboubtn.Text = "about";
            this.aboubtn.Click += new System.EventHandler(this.aboubtn_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.path);
            this.metroPanel2.Controls.Add(this.Browserbutton);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(13, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(154, 100);
            this.metroPanel2.TabIndex = 8;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 244);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.aboubtn);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.gen);
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "                   MasonCrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton gen;
        private MetroFramework.Controls.MetroTextBox path;
        private MetroFramework.Controls.MetroButton Browserbutton;
        private MetroFramework.Controls.MetroTextBox sleep;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroCheckBox antidebug;
        private MetroFramework.Controls.MetroCheckBox wddisable;
        private MetroFramework.Controls.MetroCheckBox uacbypass;
        private MetroFramework.Controls.MetroCheckBox startup;
        private MetroFramework.Controls.MetroCheckBox antikill;
        private MetroFramework.Controls.MetroButton aboubtn;
        private MetroFramework.Controls.MetroPanel metroPanel2;
    }
}

