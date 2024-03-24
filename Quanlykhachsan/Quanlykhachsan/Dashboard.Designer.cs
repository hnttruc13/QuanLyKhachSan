namespace Quanlykhachsan
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMiniSize = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCustomerManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployeeManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnFinancialManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoomManagement = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_FinancialManagement1 = new Quanlykhachsan.All_User_Control.UC_FinancialManagement();
            this.uc_CustomerManagement1 = new Quanlykhachsan.All_User_Control.Uc_CustomerManagement();
            this.uC_RoomManagement1 = new Quanlykhachsan.All_User_Control.UC_RoomManagement();
            this.panelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_EmployeeManagement1 = new Quanlykhachsan.All_User_Control.UC_EmployeeManagement();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.DarkGray;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(24, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(44, 44);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMiniSize
            // 
            this.btnMiniSize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMiniSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMiniSize.FillColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMiniSize.ForeColor = System.Drawing.Color.White;
            this.btnMiniSize.Image = ((System.Drawing.Image)(resources.GetObject("btnMiniSize.Image")));
            this.btnMiniSize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMiniSize.Location = new System.Drawing.Point(24, 71);
            this.btnMiniSize.Name = "btnMiniSize";
            this.btnMiniSize.Size = new System.Drawing.Size(44, 45);
            this.btnMiniSize.TabIndex = 1;
            this.btnMiniSize.Click += new System.EventHandler(this.btnMiniSize_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCustomerManagement);
            this.panel1.Controls.Add(this.btnEmployeeManagement);
            this.panel1.Controls.Add(this.btnFinancialManagement);
            this.panel1.Controls.Add(this.btnRoomManagement);
            this.panel1.Location = new System.Drawing.Point(135, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1765, 130);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCustomerManagement
            // 
            this.btnCustomerManagement.BorderRadius = 18;
            this.btnCustomerManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCustomerManagement.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCustomerManagement.ForeColor = System.Drawing.Color.White;
            this.btnCustomerManagement.Location = new System.Drawing.Point(526, 7);
            this.btnCustomerManagement.Name = "btnCustomerManagement";
            this.btnCustomerManagement.Size = new System.Drawing.Size(284, 116);
            this.btnCustomerManagement.TabIndex = 3;
            this.btnCustomerManagement.Text = "Quản lý khách hàng";
            this.btnCustomerManagement.Click += new System.EventHandler(this.btnCustomerManagement_Click);
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.BorderRadius = 18;
            this.btnEmployeeManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployeeManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeeManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeeManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployeeManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployeeManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEmployeeManagement.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEmployeeManagement.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeManagement.Location = new System.Drawing.Point(1364, 7);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(284, 116);
            this.btnEmployeeManagement.TabIndex = 2;
            this.btnEmployeeManagement.Text = "Quản lý nhân viên";
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // btnFinancialManagement
            // 
            this.btnFinancialManagement.BorderRadius = 18;
            this.btnFinancialManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFinancialManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinancialManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinancialManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinancialManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinancialManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFinancialManagement.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFinancialManagement.ForeColor = System.Drawing.Color.White;
            this.btnFinancialManagement.Location = new System.Drawing.Point(948, 7);
            this.btnFinancialManagement.Name = "btnFinancialManagement";
            this.btnFinancialManagement.Size = new System.Drawing.Size(284, 116);
            this.btnFinancialManagement.TabIndex = 1;
            this.btnFinancialManagement.Text = "Quản lý tài chính";
            this.btnFinancialManagement.Click += new System.EventHandler(this.btnFinancialManagement_Click);
            // 
            // btnRoomManagement
            // 
            this.btnRoomManagement.BorderRadius = 18;
            this.btnRoomManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRoomManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoomManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoomManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRoomManagement.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRoomManagement.ForeColor = System.Drawing.Color.White;
            this.btnRoomManagement.Location = new System.Drawing.Point(102, 7);
            this.btnRoomManagement.Name = "btnRoomManagement";
            this.btnRoomManagement.Size = new System.Drawing.Size(284, 116);
            this.btnRoomManagement.TabIndex = 0;
            this.btnRoomManagement.Text = "Quản lý phòng";
            this.btnRoomManagement.Click += new System.EventHandler(this.btnRoomManagement_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.uC_EmployeeManagement1);
            this.panel2.Controls.Add(this.uC_FinancialManagement1);
            this.panel2.Controls.Add(this.uc_CustomerManagement1);
            this.panel2.Controls.Add(this.uC_RoomManagement1);
            this.panel2.Location = new System.Drawing.Point(83, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1882, 852);
            this.panel2.TabIndex = 3;
            // 
            // uC_FinancialManagement1
            // 
            this.uC_FinancialManagement1.BackColor = System.Drawing.Color.White;
            this.uC_FinancialManagement1.Location = new System.Drawing.Point(-2, -2);
            this.uC_FinancialManagement1.Name = "uC_FinancialManagement1";
            this.uC_FinancialManagement1.Size = new System.Drawing.Size(1882, 852);
            this.uC_FinancialManagement1.TabIndex = 2;
            // 
            // uc_CustomerManagement1
            // 
            this.uc_CustomerManagement1.BackColor = System.Drawing.Color.Gray;
            this.uc_CustomerManagement1.Location = new System.Drawing.Point(-2, -2);
            this.uc_CustomerManagement1.Name = "uc_CustomerManagement1";
            this.uc_CustomerManagement1.Size = new System.Drawing.Size(1882, 852);
            this.uc_CustomerManagement1.TabIndex = 1;
            // 
            // uC_RoomManagement1
            // 
            this.uC_RoomManagement1.BackColor = System.Drawing.Color.White;
            this.uC_RoomManagement1.Location = new System.Drawing.Point(-2, -2);
            this.uC_RoomManagement1.Name = "uC_RoomManagement1";
            this.uC_RoomManagement1.Size = new System.Drawing.Size(1882, 852);
            this.uC_RoomManagement1.TabIndex = 0;
            // 
            // panelMoving
            // 
            this.panelMoving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelMoving.BorderRadius = 18;
            this.panelMoving.Location = new System.Drawing.Point(239, 169);
            this.panelMoving.Name = "panelMoving";
            this.panelMoving.Size = new System.Drawing.Size(280, 6);
            this.panelMoving.TabIndex = 4;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // uC_EmployeeManagement1
            // 
            this.uC_EmployeeManagement1.BackColor = System.Drawing.Color.Gray;
            this.uC_EmployeeManagement1.Location = new System.Drawing.Point(-2, -2);
            this.uC_EmployeeManagement1.Name = "uC_EmployeeManagement1";
            this.uC_EmployeeManagement1.Size = new System.Drawing.Size(1882, 852);
            this.uC_EmployeeManagement1.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panelMoving);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMiniSize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnMiniSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnRoomManagement;
        private Guna.UI2.WinForms.Guna2Button btnCustomerManagement;
        private Guna.UI2.WinForms.Guna2Button btnEmployeeManagement;
        private Guna.UI2.WinForms.Guna2Button btnFinancialManagement;
        private Guna.UI2.WinForms.Guna2Panel panelMoving;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UC_RoomManagement uC_RoomManagement1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.Uc_CustomerManagement uc_CustomerManagement1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.UC_FinancialManagement uC_FinancialManagement1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.UC_EmployeeManagement uC_EmployeeManagement1;
    }
}