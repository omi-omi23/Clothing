namespace Clothing
{
    partial class AdminDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoard));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOverView = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblAdminDashBoard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMotCustomer = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProductInStock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblActiveInEmployee = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCustomerData = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.flowLayoutPanel1.Controls.Add(this.buttonOverView);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(252, 734);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonOverView
            // 
            this.buttonOverView.AutoSize = true;
            this.buttonOverView.BackColor = System.Drawing.Color.White;
            this.buttonOverView.FlatAppearance.BorderSize = 0;
            this.buttonOverView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOverView.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOverView.ForeColor = System.Drawing.Color.Black;
            this.buttonOverView.Image = ((System.Drawing.Image)(resources.GetObject("buttonOverView.Image")));
            this.buttonOverView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOverView.Location = new System.Drawing.Point(3, 3);
            this.buttonOverView.Name = "buttonOverView";
            this.buttonOverView.Size = new System.Drawing.Size(249, 103);
            this.buttonOverView.TabIndex = 0;
            this.buttonOverView.Text = "Over View";
            this.buttonOverView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOverView.UseVisualStyleBackColor = false;
            this.buttonOverView.Click += new System.EventHandler(this.btnOverView);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 105);
            this.button2.TabIndex = 1;
            this.button2.Text = "Customer";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCustomer);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 109);
            this.button3.TabIndex = 2;
            this.button3.Text = "Employee";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnEmployee);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 338);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(249, 127);
            this.button6.TabIndex = 5;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnLogout);
            // 
            // lblAdminDashBoard
            // 
            this.lblAdminDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAdminDashBoard.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDashBoard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdminDashBoard.Location = new System.Drawing.Point(252, 0);
            this.lblAdminDashBoard.Name = "lblAdminDashBoard";
            this.lblAdminDashBoard.Size = new System.Drawing.Size(848, 41);
            this.lblAdminDashBoard.TabIndex = 1;
            this.lblAdminDashBoard.Text = "Admin Dashboard";
            this.lblAdminDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdminDashBoard.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblMotCustomer);
            this.panel1.Location = new System.Drawing.Point(285, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 126);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 60);
            this.label5.TabIndex = 1;
            this.label5.Text = "0";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblMotCustomer
            // 
            this.lblMotCustomer.AutoSize = true;
            this.lblMotCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotCustomer.ForeColor = System.Drawing.Color.White;
            this.lblMotCustomer.Location = new System.Drawing.Point(3, 0);
            this.lblMotCustomer.Name = "lblMotCustomer";
            this.lblMotCustomer.Size = new System.Drawing.Size(177, 29);
            this.lblMotCustomer.TabIndex = 0;
            this.lblMotCustomer.Text = "Total Customer";
            this.lblMotCustomer.Click += new System.EventHandler(this.lblTotalCustomer);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.flowLayoutPanel2.Controls.Add(this.lblProductInStock);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(583, 52);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 126);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // lblProductInStock
            // 
            this.lblProductInStock.AutoSize = true;
            this.lblProductInStock.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductInStock.ForeColor = System.Drawing.Color.White;
            this.lblProductInStock.Location = new System.Drawing.Point(3, 0);
            this.lblProductInStock.Name = "lblProductInStock";
            this.lblProductInStock.Size = new System.Drawing.Size(177, 26);
            this.lblProductInStock.TabIndex = 4;
            this.lblProductInStock.Text = "Products in Stock";
            this.lblProductInStock.Click += new System.EventHandler(this.lblProductStock);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 60);
            this.label6.TabIndex = 5;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.flowLayoutPanel3.Controls.Add(this.lblActiveInEmployee);
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(853, 52);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 126);
            this.flowLayoutPanel3.TabIndex = 3;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // lblActiveInEmployee
            // 
            this.lblActiveInEmployee.AutoSize = true;
            this.lblActiveInEmployee.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveInEmployee.ForeColor = System.Drawing.Color.White;
            this.lblActiveInEmployee.Location = new System.Drawing.Point(3, 0);
            this.lblActiveInEmployee.Name = "lblActiveInEmployee";
            this.lblActiveInEmployee.Size = new System.Drawing.Size(190, 29);
            this.lblActiveInEmployee.TabIndex = 0;
            this.lblActiveInEmployee.Text = "Active Employee";
            this.lblActiveInEmployee.Click += new System.EventHandler(this.lblActiveEmployee);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 60);
            this.label7.TabIndex = 6;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dgvCustomerData
            // 
            this.dgvCustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerData.Location = new System.Drawing.Point(259, 211);
            this.dgvCustomerData.Name = "dgvCustomerData";
            this.dgvCustomerData.RowHeadersWidth = 51;
            this.dgvCustomerData.RowTemplate.Height = 24;
            this.dgvCustomerData.Size = new System.Drawing.Size(841, 531);
            this.dgvCustomerData.TabIndex = 4;
            this.dgvCustomerData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerData_CellContentClick);
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 734);
            this.Controls.Add(this.dgvCustomerData);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAdminDashBoard);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashBoard_FormClosing);
            this.Load += new System.EventHandler(this.AdminDashBoard_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonOverView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblAdminDashBoard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblMotCustomer;
        private System.Windows.Forms.Label lblProductInStock;
        private System.Windows.Forms.Label lblActiveInEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvCustomerData;
    }
}