namespace Clothing
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.btnKids = new System.Windows.Forms.Button();
            this.btnMen = new System.Windows.Forms.Button();
            this.btnWomen = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlTopSIde = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.flpcontentdress = new System.Windows.Forms.FlowLayoutPanel();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSideBar.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTopSIde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.flpContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.White;
            this.pnlSideBar.Controls.Add(this.pnlCategories);
            this.pnlSideBar.Controls.Add(this.btnLogOut);
            this.pnlSideBar.Controls.Add(this.btnCart);
            this.pnlSideBar.Controls.Add(this.btnCategories);
            this.pnlSideBar.Controls.Add(this.btnHome);
            this.pnlSideBar.Controls.Add(this.pictureBox1);
            this.pnlSideBar.Controls.Add(this.lblLogo);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(220, 846);
            this.pnlSideBar.TabIndex = 0;
            this.pnlSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSideBar_Paint);
            // 
            // pnlCategories
            // 
            this.pnlCategories.Controls.Add(this.btnKids);
            this.pnlCategories.Controls.Add(this.btnMen);
            this.pnlCategories.Controls.Add(this.btnWomen);
            this.pnlCategories.Controls.Add(this.btnAll);
            this.pnlCategories.Location = new System.Drawing.Point(56, 340);
            this.pnlCategories.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(149, 170);
            this.pnlCategories.TabIndex = 10;
            this.pnlCategories.Visible = false;
            // 
            // btnKids
            // 
            this.btnKids.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKids.Location = new System.Drawing.Point(32, 113);
            this.btnKids.Margin = new System.Windows.Forms.Padding(4);
            this.btnKids.Name = "btnKids";
            this.btnKids.Size = new System.Drawing.Size(100, 28);
            this.btnKids.TabIndex = 3;
            this.btnKids.Text = "Kids";
            this.btnKids.UseVisualStyleBackColor = true;
            this.btnKids.Click += new System.EventHandler(this.btnKids_Click);
            // 
            // btnMen
            // 
            this.btnMen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMen.Location = new System.Drawing.Point(32, 78);
            this.btnMen.Margin = new System.Windows.Forms.Padding(4);
            this.btnMen.Name = "btnMen";
            this.btnMen.Size = new System.Drawing.Size(100, 28);
            this.btnMen.TabIndex = 2;
            this.btnMen.Text = "Men";
            this.btnMen.UseVisualStyleBackColor = true;
            this.btnMen.Click += new System.EventHandler(this.btnMen_Click);
            // 
            // btnWomen
            // 
            this.btnWomen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWomen.Location = new System.Drawing.Point(32, 42);
            this.btnWomen.Margin = new System.Windows.Forms.Padding(4);
            this.btnWomen.Name = "btnWomen";
            this.btnWomen.Size = new System.Drawing.Size(100, 28);
            this.btnWomen.TabIndex = 1;
            this.btnWomen.Text = "Women";
            this.btnWomen.UseVisualStyleBackColor = true;
            this.btnWomen.Click += new System.EventHandler(this.btnWomen_Click);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(32, 4);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(100, 28);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnLogOut.Location = new System.Drawing.Point(33, 582);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(140, 39);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCart
            // 
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnCart.Location = new System.Drawing.Point(33, 513);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCart.Size = new System.Drawing.Size(140, 39);
            this.btnCart.TabIndex = 6;
            this.btnCart.Text = "My Cart";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(33, 294);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCategories.Size = new System.Drawing.Size(140, 39);
            this.btnCategories.TabIndex = 5;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnHome.Location = new System.Drawing.Point(33, 233);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(155, 34);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(48, 73);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(125, 41);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "CLOSET";
            // 
            // pnlTopSIde
            // 
            this.pnlTopSIde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(243)))));
            this.pnlTopSIde.Controls.Add(this.lblSearch);
            this.pnlTopSIde.Controls.Add(this.textBoxSearch);
            this.pnlTopSIde.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSIde.Location = new System.Drawing.Point(220, 0);
            this.pnlTopSIde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTopSIde.Name = "pnlTopSIde";
            this.pnlTopSIde.Size = new System.Drawing.Size(1675, 70);
            this.pnlTopSIde.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(150, 29);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(149, 25);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search Products";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(305, 23);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(768, 31);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // flpcontentdress
            // 
            this.flpcontentdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpcontentdress.AutoScroll = true;
            this.flpcontentdress.Location = new System.Drawing.Point(15, 344);
            this.flpcontentdress.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.flpcontentdress.Name = "flpcontentdress";
            this.flpcontentdress.Size = new System.Drawing.Size(1660, 460);
            this.flpcontentdress.TabIndex = 5;
            this.flpcontentdress.Paint += new System.Windows.Forms.PaintEventHandler(this.flpcontentdress_Paint);
            // 
            // picBanner
            // 
            this.picBanner.ErrorImage = null;
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.InitialImage = null;
            this.picBanner.Location = new System.Drawing.Point(11, 20);
            this.picBanner.Margin = new System.Windows.Forms.Padding(0, 10, 0, 15);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(1751, 299);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            this.picBanner.Click += new System.EventHandler(this.picBanner_Click);
            // 
            // flpContent
            // 
            this.flpContent.AutoScroll = true;
            this.flpContent.Controls.Add(this.picBanner);
            this.flpContent.Controls.Add(this.flpcontentdress);
            this.flpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContent.Location = new System.Drawing.Point(220, 70);
            this.flpContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpContent.Name = "flpContent";
            this.flpContent.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.flpContent.Size = new System.Drawing.Size(1675, 776);
            this.flpContent.TabIndex = 2;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1895, 846);
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.pnlTopSIde);
            this.Controls.Add(this.pnlSideBar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Closet HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            this.pnlCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTopSIde.ResumeLayout(false);
            this.pnlTopSIde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.flpContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlTopSIde;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Button btnMen;
        private System.Windows.Forms.Button btnWomen;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnKids;
        private System.Windows.Forms.FlowLayoutPanel flpcontentdress;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}