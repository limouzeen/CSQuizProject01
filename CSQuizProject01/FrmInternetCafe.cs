using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSQuizProject01
{
    public partial class FrmInternetCafe : Form
    {
        public FrmInternetCafe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void FrmInternetCafe_Load(object sender, EventArgs e)
        {
            btReset.PerformClick();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            mcServiceDate.SetDate(DateTime.Today);
            mtbIDCard.Clear();
            tbFullName.Clear();
            rbMember.Checked = true;
            rbStudent.Checked = false;
            rbGeneral.Checked = false;
            cbUsagePlan.SelectedIndex = 0;
            tbUsageHours.Clear();
            chkConfirmPayment.Checked = false;
            lbTotalPrice.Text = "00.00";

           
            mcServiceDate.SetDate(DateTime.Today);
            lbServiceDate.Text = "-";
            lbIDCard.Text = "-";
            lbFullName.Text = "-";
            lbServiceType.Text = "-";
            lbUsagePlan.Text = "-";
            lbTotalTime.Text = "-";
        }


        private bool ValidateInputs()
        {
            if (!mtbIDCard.MaskCompleted) 
            {
                ShareData.showWarningMSG("กรุณากรอกรหัสบัตรประชาชนให้ครบ 13 หลัก");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbFullName.Text))
            {
                ShareData.showWarningMSG("กรุณากรอกชื่อ-สกุล");
                return false;
            }
            if (!rbMember.Checked && !rbStudent.Checked && !rbGeneral.Checked)
            {
                ShareData.showWarningMSG("กรุณาเลือกประเภทผู้ใช้บริการ");
                return false;
            }
            if (!double.TryParse(tbUsageHours.Text, out double hours) || hours <= 0)
            {
                ShareData.showWarningMSG("กรุณากรอกจำนวนชั่วโมงที่ถูกต้อง (ตัวเลขมากกว่า 0)");
                return false;
            }
            return true;
        }


        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

        
            if (cbUsagePlan.SelectedIndex == -1)
            {
                ShareData.showWarningMSG("กรุณาเลือกประเภทการใช้งาน");
                return;
            }

            if (!chkConfirmPayment.Checked)
            {
                ShareData.showWarningMSG("กรุณายืนยันการชำระเงินก่อนคำนวณ");
                return;
            }


            DateTime selectedDate = mcServiceDate.SelectionStart;
            lbServiceDate.Text = ShareData.ConvertToThaiDate(selectedDate);


            lbIDCard.Text = mtbIDCard.Text;
            lbFullName.Text = tbFullName.Text;

            
            if (rbMember.Checked) lbServiceType.Text = "สมาชิก";
            else if (rbStudent.Checked) lbServiceType.Text = "นักเรียน/นักศึกษา";
            else if (rbGeneral.Checked) lbServiceType.Text = "บุคคลทั่วไป";

       
            lbUsagePlan.Text = cbUsagePlan.SelectedItem?.ToString() ?? "-";

            
            double basePrice = 0;
            switch (cbUsagePlan.SelectedItem.ToString())
            {
                case "อินเตอร์เน็ต ชั่วโมงละ 20.50 บาท": basePrice = 20.50; break;
                case "พิมพ์งาน ชั่วโมงละ 10.50 บาท": basePrice = 10.50; break;
                case "เล่นเกมส์ Offline ชั่วโมงละ 15.50 บาท": basePrice = 15.50; break;
                case "เล่นเกมส์ Online  ชั่วโมงละ 25.50 บาท": basePrice = 25.50; break;
                default:
                    ShareData.showWarningMSG("ประเภทการใช้งานไม่ถูกต้อง");
                    return;
            }


            double discountRate = 0;
            if (rbMember.Checked) discountRate = 0.10; 
            else if (rbStudent.Checked) discountRate = 0.05; 
           

            if (!double.TryParse(tbUsageHours.Text, out double totalHours) || totalHours <= 0)
            {
                ShareData.showWarningMSG("กรุณากรอกจำนวนชั่วโมงให้ถูกต้อง");
                return;
            }

           
            lbTotalTime.Text = totalHours.ToString("0.00") + " ชั่วโมง";

          
            double totalPrice = basePrice * totalHours;
            double discountAmount = totalPrice * discountRate;
            double finalPrice = totalPrice - discountAmount;

            
            lbTotalPrice.Text = finalPrice.ToString("0.00") + " บาท";
        }

        private void tbUsageHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.inputDecimal_KeyPress(sender, e);
        }

        private void mtbIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.idCard_KeyPress(sender, e);
        }

        private void tbFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.ValidateName_KeyPress(sender, e);
        }
    }
}
