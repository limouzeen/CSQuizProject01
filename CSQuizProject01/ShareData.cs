using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CSQuizProject01
{
    internal class ShareData
    {
        public static void showWarningMSG(String msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public static string ConvertToThaiDate(DateTime date)
        {
            CultureInfo thaiCulture = new CultureInfo("th-TH");
            return date.ToString("dd MMMM yyyy", thaiCulture);
        }

        public static void ValidateName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            // Allow only Thai/English letters and spaces
            Regex regex = new Regex(@"^[a-zA-Zก-๙\s]$");

            if (!char.IsControl(e.KeyChar) && !regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true; // Block invalid characters
                showWarningMSG("กรุณากรอกเฉพาะตัวอักษรภาษาไทยหรือภาษาอังกฤษ");
            }
        }

        public static void idCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent non-numeric characters
            }
        }

        // ✅ Only Allow Decimal Numbers (For Usage Hours)
        public static void inputDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return; // Safety check

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Prevent non-numeric characters
            }

            // ✅ Prevent multiple decimal points
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        public static void ValidateNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
