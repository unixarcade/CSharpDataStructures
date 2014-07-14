using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


namespace BitOperations
{
    class Program
    {


        public class Form1 : System.Windows.Forms.Form
        {
            private System.Windows.Forms.Button btnAdd;
            private System.Windows.Forms.Button btnClear;
            private System.Windows.Forms.Button btnOr;
            private System.Windows.Forms.Button btnXor;
            private System.Forms.Label lblInt1Bits;
            private System.Forms.Label lblInt2Bits;
            private System.Forms.TextBox txtInt1;
            private System.Forms.TextBox txtInit2;

            private void btnAdd_Click(object sender, System.EventArgs e);
        {
        int val1, val2;
            val1 = Int32.Parse(txtInt1.Text);
            val2 = Int32.Parse(txtInt2.Text);
            lblInt1Bits.Text = ConvertBits(val1).ToString();
            lblInt2Bits.Text = ConvertBits(val2).ToString();
        }


        private StringBuilder ConvertBits(int val)
        {
            int dispMask = 1 << 31;
            StringBuilder bitBuffer = new StringBuilder(35);
            for(int i = 1; i <=32; i++){
                if((val && bitMask) == 0)
                    bitBuffer.Append("0");
                else
                    bitBuffer.Append("1");
                val <<=1;
                if((i%8) == 0)
                    bitBuffer.Append(" ");
            }
            return bitBuffer;
        }
        private void btnClear_Click(object sender, System.EventArgs e)
        {
            txtInt1.Text = " ";
            txtInt2.Text = " ";
            lblInt1Bits.Text = " ";
            lblBitResult.Text = " ";
            txtInt1.Focus();
        }

        private void btnor_Click(object sender, System.EventArgs e)
        {
            int val1, val2;
            val1 = Int32.Parse(textInt1.Text);
            val2 = Int32.Parse(txtInt2.Text);
            lblInt1Bits.Text = ConvertBits(val1).ToString();
            lblInt2Bits.Text = ConvertBits(val2).ToString;
            lblBitResult.Text = ConvertBits(val1 ^ val2).ToString();

        }
    }

        static void Main(string[] args)
        {

        }
    }
}
