namespace Dental_Bill
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDentalBill = new System.Windows.Forms.Label();
            this.tblDentalBill = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFillings = new System.Windows.Forms.Label();
            this.chkXRay = new System.Windows.Forms.CheckBox();
            this.chkTeethWhitening = new System.Windows.Forms.CheckBox();
            this.chkScaling = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblScaling = new System.Windows.Forms.Label();
            this.lblTeethWhitening = new System.Windows.Forms.Label();
            this.lblXRay = new System.Windows.Forms.Label();
            this.lblFillings_price = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfrm = new System.Windows.Forms.Button();
            this.nudFillings = new System.Windows.Forms.NumericUpDown();
            this.tblDentalBill.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFillings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDentalBill
            // 
            this.lblDentalBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDentalBill.AutoSize = true;
            this.lblDentalBill.BackColor = System.Drawing.Color.Transparent;
            this.lblDentalBill.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDentalBill.ForeColor = System.Drawing.Color.Blue;
            this.lblDentalBill.Location = new System.Drawing.Point(3, 0);
            this.lblDentalBill.Name = "lblDentalBill";
            this.lblDentalBill.Size = new System.Drawing.Size(428, 29);
            this.lblDentalBill.TabIndex = 0;
            this.lblDentalBill.Text = "Dental Bill";
            this.lblDentalBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblDentalBill
            // 
            this.tblDentalBill.ColumnCount = 1;
            this.tblDentalBill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDentalBill.Controls.Add(this.lblDentalBill, 0, 0);
            this.tblDentalBill.Location = new System.Drawing.Point(3, 12);
            this.tblDentalBill.Name = "tblDentalBill";
            this.tblDentalBill.RowCount = 1;
            this.tblDentalBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDentalBill.Size = new System.Drawing.Size(434, 35);
            this.tblDentalBill.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 23);
            this.txtName.TabIndex = 3;
            this.txtName.Click += new System.EventHandler(this.txtTenKhachHang_Click);
            // 
            // lblFillings
            // 
            this.lblFillings.AutoSize = true;
            this.lblFillings.Location = new System.Drawing.Point(3, 120);
            this.lblFillings.Name = "lblFillings";
            this.lblFillings.Size = new System.Drawing.Size(60, 15);
            this.lblFillings.TabIndex = 1;
            this.lblFillings.Text = "Trám răng";
            // 
            // chkXRay
            // 
            this.chkXRay.AutoSize = true;
            this.chkXRay.Location = new System.Drawing.Point(3, 83);
            this.chkXRay.Name = "chkXRay";
            this.chkXRay.Size = new System.Drawing.Size(84, 19);
            this.chkXRay.TabIndex = 0;
            this.chkXRay.Text = "Chụp hình răng";
            this.chkXRay.UseVisualStyleBackColor = true;
            // 
            // chkTeethWhitening
            // 
            this.chkTeethWhitening.AutoSize = true;
            this.chkTeethWhitening.Location = new System.Drawing.Point(3, 43);
            this.chkTeethWhitening.Name = "chkTeethWhitening";
            this.chkTeethWhitening.Size = new System.Drawing.Size(75, 19);
            this.chkTeethWhitening.TabIndex = 0;
            this.chkTeethWhitening.Text = "Tẩy trắng";
            this.chkTeethWhitening.UseVisualStyleBackColor = true;
            // 
            // chkScaling
            // 
            this.chkScaling.AutoSize = true;
            this.chkScaling.Location = new System.Drawing.Point(3, 3);
            this.chkScaling.Name = "chkScaling";
            this.chkScaling.Size = new System.Drawing.Size(66, 19);
            this.chkScaling.TabIndex = 0;
            this.chkScaling.Text = "Cạo vôi";
            this.chkScaling.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.chkScaling, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkTeethWhitening, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkXRay, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFillings, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 140);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(90, 163);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblScaling
            // 
            this.lblScaling.AutoSize = true;
            this.lblScaling.Location = new System.Drawing.Point(304, 140);
            this.lblScaling.Name = "lblScaling";
            this.lblScaling.Size = new System.Drawing.Size(52, 15);
            this.lblScaling.TabIndex = 6;
            this.lblScaling.Text = "$300.000";
            this.lblScaling.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTeethWhitening
            // 
            this.lblTeethWhitening.AutoSize = true;
            this.lblTeethWhitening.Location = new System.Drawing.Point(304, 183);
            this.lblTeethWhitening.Name = "lblTeethWhitening";
            this.lblTeethWhitening.Size = new System.Drawing.Size(61, 15);
            this.lblTeethWhitening.TabIndex = 6;
            this.lblTeethWhitening.Text = "$1.302.002";
            this.lblTeethWhitening.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblXRay
            // 
            this.lblXRay.AutoSize = true;
            this.lblXRay.Location = new System.Drawing.Point(304, 223);
            this.lblXRay.Name = "lblXRay";
            this.lblXRay.Size = new System.Drawing.Size(52, 15);
            this.lblXRay.TabIndex = 6;
            this.lblXRay.Text = "$500.000";
            this.lblXRay.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFillings_price
            // 
            this.lblFillings_price.AutoSize = true;
            this.lblFillings_price.Location = new System.Drawing.Point(304, 260);
            this.lblFillings_price.Name = "lblFillings_price";
            this.lblFillings_price.Size = new System.Drawing.Size(52, 15);
            this.lblFillings_price.TabIndex = 6;
            this.lblFillings_price.Text = "$200.000";
            this.lblFillings_price.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(178, 343);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 15);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            this.lblTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(232, 343);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(114, 23);
            this.txtTotal.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(57, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfrm
            // 
            this.btnConfrm.Location = new System.Drawing.Point(290, 411);
            this.btnConfrm.Name = "btnConfrm";
            this.btnConfrm.Size = new System.Drawing.Size(75, 23);
            this.btnConfrm.TabIndex = 8;
            this.btnConfrm.Text = "Tính Tiền";
            this.btnConfrm.UseVisualStyleBackColor = true;
            this.btnConfrm.Click += new System.EventHandler(this.btnConfrm_Click);
            // 
            // nudFillings
            // 
            this.nudFillings.Location = new System.Drawing.Point(93, 260);
            this.nudFillings.Name = "nudFillings";
            this.nudFillings.Size = new System.Drawing.Size(67, 23);
            this.nudFillings.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConfrm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(434, 465);
            this.Controls.Add(this.nudFillings);
            this.Controls.Add(this.btnConfrm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFillings_price);
            this.Controls.Add(this.lblXRay);
            this.Controls.Add(this.lblTeethWhitening);
            this.Controls.Add(this.lblScaling);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tblDentalBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tblDentalBill.ResumeLayout(false);
            this.tblDentalBill.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFillings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDentalBill;
        private TableLayoutPanel tblDentalBill;
        private Label lblName;
        private TextBox txtName;
        private Label lblFillings;
        private CheckBox chkXRay;
        private CheckBox chkTeethWhitening;
        private CheckBox chkScaling;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblScaling;
        private Label lblTeethWhitening;
        private Label lblXRay;
        private Label lblFillings_price;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnCancel;
        private Button btnConfrm;
        private NumericUpDown nudFillings;
    }
}