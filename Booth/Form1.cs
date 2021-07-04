using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booth
{
    public partial class Form1 : Form
    {
      
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSoA, "Chỉ có số không kí tự");
      
            }
            else
                errorProvider1.Clear();
        }

        private void txtSoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSoB, "Chỉ được nhập số");
             
            }
            else
                errorProvider1.Clear();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            string stepss = "";
            if (checkInput())
            {
                MessageBox.Show("Mời nhập giá trị cho cả A và B !!");
                return;
            }
            
            int a = Convert.ToInt32(txtSoA.Text.ToString());
            int b = Convert.ToInt32(txtSoB.Text.ToString());

            if (checkInputValue(a, b))
            {
                MessageBox.Show("Mời nhập giá trị nhỏ hơn 128 !!");
                return;
            }

            int[] x = toBinary(a);
            int[] y = toBinary(b);

            txtNhiPhanA.Text = getStringFromArray(x);
            txtNhiPhanB.Text = getStringFromArray(y);

            lbKetQua.Text = (a * b)+"";

            String[] arr = boothMultiply(a, b).Split(',');
            lbBinary.Text = arr[0];
            rTxtStep.Text = arr[1];
        


        }

        public Boolean checkInput()
        {
            return (txtSoA.Text == "" || txtSoB.Text == "");
        }

        public Boolean checkInputValue(int a, int b)
        {
            return (a>127 || b>127);
        }

        public String getStringFromArray(int[] arr){
            string temp ="";
            for(int i=0; i< arr.Count(); i++){
                temp += (arr[i] + "");
            }
           
            return temp.Replace("00000000", "");
        }

     

        public string boothMultiply(int multiplicand, int multiplier)
        {
            String rs = "Các bước giải: \n";
            int[] m = toBinary(multiplicand); // Nhị phân của A 
            int[] m2 = toBinary(-multiplicand); // Số âm bù 2 của số A
            int[] q = toBinary(multiplier); // Nhị phân của số B

            int[] Addition = new int[17]; // mảng nhị phân của A dùng trong phép cộng
            int[] Subtraction = new int[17]; //mảng nhị phân của âm A dùng trong phép cộng
            int[] ProductReg = new int[17]; // mảng chứa A, Q0, Q-1

            // đổ dữ liệu từ nhị phân của A và -A
            for (int i = 0; i < 16; i++)
            {
                Addition[i] = m[i];
                Subtraction[i] = m2[i];
            }

           
            for (int i = 8; i <= 16; i++)
            {
                ProductReg[i] = q[i-8];
            } 

            // Gán giá trị mặc định cho Q1 là 0
            ProductReg[16] = 0;

            //Display the results
             rs += "            A              Q0              Q-1" + " \t BĐ="+ 8 +" \n";
            rs += steps(Addition, "  M:  ") + "\n";
            rs += steps(Subtraction, "-M: ")+ "\n";
            rs += steps(ProductReg, "  Q:  ")+ "\n";
            rs += " \n";

            // Chạy for, kiểm tra Q0 Q1 để tiến hành dịch phải
            for (int i = 0; i < 8; i++)
            {
                if (ProductReg[15] == 0 && ProductReg[16] == 0)
                {
                    rs +="Q0Q-1 = 00 nên dịch phải \n";
                    rs += "       A              Q0              Q-1" + " \t BĐ="+(7-i)+" \n";
                }
                if (ProductReg[15] == 1 && ProductReg[16] == 1)
                {
                    rs += "Q0Q-1 = 11 nên dịch phải \n";
                    rs += "       A              Q0              Q-1"  + " \t BĐ="+(7-i)+"\n";
                }
                if (ProductReg[15] == 1 && ProductReg[16] == 0)
                {
                    rs += "Q0Q-1 = 10 nên A = A- M rồi dịch phải \n";
                    rs += "       A              Q0              Q-1"  + " \t BĐ="+(7-i)+" \n";
                    rs += steps(Subtraction, "") + "\n";
                   add(ProductReg, Subtraction);

                }
                if (ProductReg[15] == 0 && ProductReg[16] == 1)
                {
                    rs += "Q0Q-1 = 01 nên A = A + M  rồi dịch phải \n";
                    rs += "       A              Q0              Q-1" + " \t BĐ="+(7-i)+" \n";
                    rs += steps(Addition, "") + "\n";
                    add(ProductReg, Addition);
                }
                // Tiến hành dịch phải
                shiftRight(ProductReg);
                rs += steps(ProductReg, "") +" \n --------------- \n";
            }

            // convert kết quả thành String
            string original = string.Join("", ProductReg);

            // xóa Q1 từ kết quả
            if (original.Length >= 17)
            {
                string binaryResult = original.Remove(original.Length - 1);
                return binaryResult + "," + rs;
            }
            else
            {
               return original  + "," + rs;;
            }

        }

        // Tiến hành dịch phải
        public void shiftRight(int[] X)
        {
            // dịch phải lần lượt (dữ dấu sau khi dịch phải)
            for (int i = 16; i >= 1; i--)
            {
                X[i] = X[i - 1];
            }
        }


        // Cộng 2 số nhị phân
        public void add(int[] X, int[] Y)
        {
            int carryBit = 0;
            for (int i = 8; i >= 0; i--)
            {
                int temporary = X[i] + Y[i] + carryBit;
                X[i] = temporary % 2;
                carryBit = temporary / 2;
            }

        }

        // Chuyển số decimal hành binary
        public int[] toBinary(int number)
        {
            int n = number;

            var bin = Convert.ToString(n, 2);

            // trường hợp số âm
            if (n < 0)
            {
               
                if (bin.Length == 32)
                {
                    bin = bin.Remove(1, 24);
                    bin = bin.PadRight(16, '0');
                }
                return bin.Select(c => int.Parse(c.ToString())).ToArray();
            }

            // Trường hợp số dương
            if (bin.Length == 32)
            {
                bin = bin.Remove(0, 8);
                bin = bin.PadRight(16, '0');
                return bin.Select(c => int.Parse(c.ToString())).ToArray();
            }

            //Nếu giá trị số nhỏ hơn 8 bit thì chèn 0 lên trước
            if (bin.Length < 8)
            {
                bin = bin.PadLeft(8, '0');
                
                bin = bin.PadRight(16, '0');

                return bin.Select(c => int.Parse(c.ToString())).ToArray();
            }
            return bin.Select(c => int.Parse(c.ToString())).ToArray();
        }

        // Hiển thị các bước làm
        public String steps(int[] X, string name)
        {
            String s = "";
            s += name + "";
            for (int i = 0; i < X.Length; i++)
            {

                if (i == 8)
                {
                    s += "    ";
                }

                if (i == 16)
                {
                    s += "    ";
                }

                s += ""+ X[i];
            }
           

            return s;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
