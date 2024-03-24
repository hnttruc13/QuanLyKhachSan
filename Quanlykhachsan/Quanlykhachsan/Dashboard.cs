using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlykhachsan
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMiniSize_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_RoomManagement1.Visible = false;
            btnRoomManagement.PerformClick();
        }

        private void btnRoomManagement_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnRoomManagement.Left + 105;
            uC_RoomManagement1.Visible=true;
            uC_RoomManagement1.BringToFront();
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnCustomerManagement.Left + 108;
            uc_CustomerManagement1.Visible=true;
            uc_CustomerManagement1.BringToFront();
        }

        private void btnFinancialManagement_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnFinancialManagement.Left + 111;
            uC_FinancialManagement1.Visible=true;
            uC_FinancialManagement1.BringToFront();
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            panelMoving.Left =  btnEmployeeManagement.Left + 114;
            uC_EmployeeManagement1.Visible = true;
            uC_EmployeeManagement1.BringToFront();
        }
    }
}
