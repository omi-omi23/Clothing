namespace Clothing
{
    partial class CheckoutForm
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
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.bkashRadio = new System.Windows.Forms.RadioButton();
            this.cardRadio = new System.Windows.Forms.RadioButton();
            this.cashRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.thankYouLabel = new System.Windows.Forms.Label();
            this.orderConfirmedLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.placeOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.placeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.placeOrderButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.placeOrderButton.Location = new System.Drawing.Point(200, 299);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(260, 42);
            this.placeOrderButton.TabIndex = 3;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = false;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(240, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(149, 36);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Checkout";
            //this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.paymentLabel.Location = new System.Drawing.Point(135, 63);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(185, 25);
            this.paymentLabel.TabIndex = 5;
            this.paymentLabel.Text = "Payment Methods";
            // 
            // bkashRadio
            // 
            this.bkashRadio.AutoSize = true;
            this.bkashRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.bkashRadio.Image = global::Clothing.Properties.Resources.bkash_com_logo1;
            this.bkashRadio.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bkashRadio.Location = new System.Drawing.Point(140, 221);
            this.bkashRadio.Name = "bkashRadio";
            this.bkashRadio.Size = new System.Drawing.Size(115, 32);
            this.bkashRadio.TabIndex = 2;
            this.bkashRadio.TabStop = true;
            this.bkashRadio.Text = "      bkash";
            this.bkashRadio.UseVisualStyleBackColor = true;
            //this.bkashRadio.CheckedChanged += new System.EventHandler(this.bkashRadio_CheckedChanged);
            // 
            // cardRadio
            // 
            this.cardRadio.AutoSize = true;
            this.cardRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.cardRadio.Image = global::Clothing.Properties.Resources._17_174872_icon_credit_card_logo_hd_png_download;
            this.cardRadio.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cardRadio.Location = new System.Drawing.Point(140, 177);
            this.cardRadio.Name = "cardRadio";
            this.cardRadio.Size = new System.Drawing.Size(106, 34);
            this.cardRadio.TabIndex = 1;
            this.cardRadio.TabStop = true;
            this.cardRadio.Text = "      Card";
            this.cardRadio.UseVisualStyleBackColor = true;
            //this.cardRadio.CheckedChanged += new System.EventHandler(this.cardRadio_CheckedChanged);
            // 
            // cashRadio
            // 
            this.cashRadio.AutoSize = true;
            this.cashRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.cashRadio.Image = global::Clothing.Properties.Resources.download__1_;
            this.cashRadio.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cashRadio.Location = new System.Drawing.Point(140, 123);
            this.cashRadio.Name = "cashRadio";
            this.cashRadio.Size = new System.Drawing.Size(109, 32);
            this.cashRadio.TabIndex = 0;
            this.cashRadio.TabStop = true;
            this.cashRadio.Text = "      Cash";
            this.cashRadio.UseVisualStyleBackColor = true;
            //this.cashRadio.CheckedChanged += new System.EventHandler(this.cashRadio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(358, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 80);
            this.label1.TabIndex = 6;
            this.label1.Text = " Total Amount: BDT 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
       
            
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.thankYouLabel);
            this.panel1.Controls.Add(this.orderConfirmedLabel);
            this.panel1.Location = new System.Drawing.Point(81, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 61);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            //this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // thankYouLabel
            // 
            this.thankYouLabel.AutoSize = true;
            this.thankYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thankYouLabel.ForeColor = System.Drawing.Color.Black;
            this.thankYouLabel.Location = new System.Drawing.Point(145, 35);
            this.thankYouLabel.Name = "thankYouLabel";
            this.thankYouLabel.Size = new System.Drawing.Size(173, 16);
            this.thankYouLabel.TabIndex = 1;
            this.thankYouLabel.Text = "Thank you for shopping!";
            //this.thankYouLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // orderConfirmedLabel
            // 
            this.orderConfirmedLabel.AutoSize = true;
            this.orderConfirmedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderConfirmedLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.orderConfirmedLabel.Location = new System.Drawing.Point(144, 6);
            this.orderConfirmedLabel.Name = "orderConfirmedLabel";
            this.orderConfirmedLabel.Size = new System.Drawing.Size(164, 22);
            this.orderConfirmedLabel.TabIndex = 0;
            this.orderConfirmedLabel.Text = "Order Confirmed!";
            // 
            // CheckoutFrorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.bkashRadio);
            this.Controls.Add(this.cardRadio);
            this.Controls.Add(this.cashRadio);
            this.Name = "CheckoutFrorm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            //this.Load += new System.EventHandler(this.CheckoutFrorm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton cashRadio;
        private System.Windows.Forms.RadioButton cardRadio;
        private System.Windows.Forms.RadioButton bkashRadio;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label paymentLabel;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label orderConfirmedLabel;
        private System.Windows.Forms.Label thankYouLabel;
    }
}