namespace Forms1
{
    partial class frmLogin
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
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.base2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublist1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublist2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.list2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.list3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_user.Location = new System.Drawing.Point(120, 211);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(145, 20);
            this.tb_user.TabIndex = 0;
            // 
            // tb_pass
            // 
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_pass.Location = new System.Drawing.Point(120, 290);
            this.tb_pass.MaxLength = 32;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(145, 20);
            this.tb_pass.TabIndex = 1;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_user.Location = new System.Drawing.Point(163, 191);
            this.lb_user.Name = "lb_user";
            this.lb_user.Padding = new System.Windows.Forms.Padding(2);
            this.lb_user.Size = new System.Drawing.Size(61, 19);
            this.lb_user.TabIndex = 2;
            this.lb_user.Text = "Username";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_pass.Location = new System.Drawing.Point(163, 270);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Padding = new System.Windows.Forms.Padding(2);
            this.lb_pass.Size = new System.Drawing.Size(59, 19);
            this.lb_pass.TabIndex = 3;
            this.lb_pass.Text = "Password";
            // 
            // bt_login
            // 
            this.bt_login.Font = new System.Drawing.Font("Fira Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.bt_login.Location = new System.Drawing.Point(157, 339);
            this.bt_login.Name = "bt_login";
            this.bt_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_login.Size = new System.Drawing.Size(75, 23);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "LOGIN";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Forms1.Properties.Resources.W_2013_212;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(130, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 116);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.Tomato;
            this.bt_exit.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.Location = new System.Drawing.Point(297, 376);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(0);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 6;
            this.bt_exit.Text = "EXIT";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.base2ToolStripMenuItem,
            this.base3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.list1ToolStripMenuItem2});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.item1ToolStripMenuItem.Text = "Base1";
            // 
            // list1ToolStripMenuItem2
            // 
            this.list1ToolStripMenuItem2.CheckOnClick = true;
            this.list1ToolStripMenuItem2.Name = "list1ToolStripMenuItem2";
            this.list1ToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.list1ToolStripMenuItem2.Text = "List1";
            // 
            // base2ToolStripMenuItem
            // 
            this.base2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.list1ToolStripMenuItem,
            this.list2ToolStripMenuItem});
            this.base2ToolStripMenuItem.Name = "base2ToolStripMenuItem";
            this.base2ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.base2ToolStripMenuItem.Text = "Base2";
            // 
            // list1ToolStripMenuItem
            // 
            this.list1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sublist1ToolStripMenuItem,
            this.sublist2ToolStripMenuItem});
            this.list1ToolStripMenuItem.Name = "list1ToolStripMenuItem";
            this.list1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.list1ToolStripMenuItem.Text = "List1";
            // 
            // sublist1ToolStripMenuItem
            // 
            this.sublist1ToolStripMenuItem.Name = "sublist1ToolStripMenuItem";
            this.sublist1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sublist1ToolStripMenuItem.Text = "Sublist1";
            // 
            // sublist2ToolStripMenuItem
            // 
            this.sublist2ToolStripMenuItem.Name = "sublist2ToolStripMenuItem";
            this.sublist2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sublist2ToolStripMenuItem.Text = "Sublist2";
            // 
            // list2ToolStripMenuItem
            // 
            this.list2ToolStripMenuItem.CheckOnClick = true;
            this.list2ToolStripMenuItem.Name = "list2ToolStripMenuItem";
            this.list2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.list2ToolStripMenuItem.Text = "List2";
            // 
            // base3ToolStripMenuItem
            // 
            this.base3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.list1ToolStripMenuItem1,
            this.list2ToolStripMenuItem1,
            this.list3ToolStripMenuItem});
            this.base3ToolStripMenuItem.Name = "base3ToolStripMenuItem";
            this.base3ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.base3ToolStripMenuItem.Text = "Base3";
            // 
            // list1ToolStripMenuItem1
            // 
            this.list1ToolStripMenuItem1.CheckOnClick = true;
            this.list1ToolStripMenuItem1.Name = "list1ToolStripMenuItem1";
            this.list1ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.list1ToolStripMenuItem1.Text = "List1";
            // 
            // list2ToolStripMenuItem1
            // 
            this.list2ToolStripMenuItem1.Name = "list2ToolStripMenuItem1";
            this.list2ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.list2ToolStripMenuItem1.Text = "List2";
            // 
            // list3ToolStripMenuItem
            // 
            this.list3ToolStripMenuItem.Name = "list3ToolStripMenuItem";
            this.list3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.list3ToolStripMenuItem.Text = "List3";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms1.Properties.Resources.sand_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.ControlBox = false;
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Windows App 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem list1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem base2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem list1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublist1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublist2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem list2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem list1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem list2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem list3ToolStripMenuItem;
    }
}

