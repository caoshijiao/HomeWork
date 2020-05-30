using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class draw : Form
    {
        private Graphics graphics;
        double th1;//右分支角度
        double th2;//左分支角度
        double per1;//右分支长度比
        double per2;//左分支长度比
        int n;//递归深度
        double leng;//主干长度
        Pen penColor;
        bool[] flag=new bool[6];
        
        public draw()
        {
            InitializeComponent();
           
           
        }

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {

            
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(penColor , (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            
            if (flag[0] == true&& flag[1] == true && flag[2] == true && flag[3] == true && flag[4] == true && flag[5] == true)
            {
                if (graphics == null) graphics = this.CreateGraphics();
                drawCayleyTree(n, 130, 270, leng, -Math.PI / 2);
                result.Text = "绘图成功！";
            }
            else
            {
                result.Text = "输入错误,请确认！";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            graphics = pnlDraw.CreateGraphics();
        }

        

        private void tbRecursionDepth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = Int32.Parse(RecursionDepth.Text.Trim());
                flag[0] = true;
                result.Text = "输入正确！";
            }
            catch (OverflowException)
            {
                flag[0] = false;
                result.Text = "溢出异常！";
            }
            catch (ArgumentNullException)
            {
                flag[0] = false;
                result.Text = "输入为空！";
            }
            catch (FormatException)
            {
                flag[0] = false;
                result.Text = "格式异常！";
            }
        }

        private void tbTruckLeng_TextChanged(object sender, EventArgs e)
        {
            try
            {
                leng = double.Parse(TruckLeng.Text.Trim());
                flag[1] = true;
                result.Text = "输入正确！";
            }
            catch (OverflowException)
            {
                flag[1] = false;
                result.Text = "溢出异常！";
            }
            catch (ArgumentNullException)
            {
                flag[1]= false;
                result.Text = "输入为空！";
            }
            catch (FormatException)
            {
                flag[1] = false;
                result.Text = "格式异常！";
            }

            
        }

        private void tbLeftLeng_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                double t = double.Parse(LeftLeng.Text.Trim());
                if (t > 0 && t < 1)
                {
                    per2 = t;
                    flag[2] = true;
                    result.Text = "输入正确！";
                }
                else
                {
                    flag[2] = false;
                    result.Text = "输入范围错误！";
                }

            }
            catch (OverflowException)
            {
                flag[2] = false;
                result.Text = "溢出异常！";
            }
            catch (ArgumentNullException)
            {
                flag[2] = false;
                result.Text = "输入为空！";
            }
            catch (FormatException)
            {
                flag[2] = false;
                result.Text = "格式异常！";
            }


        }

        private void tbRightLeng_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double t = double.Parse(RightLeng.Text.Trim());
                if (t > 0 && t < 1)
                {
                    per1 = t;
                    flag[3] = true;
                    result.Text = "输入正确！";
                }
                else
                {
                    flag[3] = false;
                    result.Text = "输入范围错误！";
                }
            }
            catch (OverflowException)
            {
                flag[3] = false;
                result.Text = "溢出异常！";
            }
            catch (ArgumentNullException)
            {
                flag[3] = false;
                result.Text = "输入为空！";
            }
            catch (FormatException)
            {
                flag[3] = false;
                result.Text = "格式异常！";
            }



        }


        private void tbLeftAngle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double leftAngle = double.Parse(LeftAngle.Text.Trim());
                if (leftAngle > 0 && leftAngle < 90)
                {
                    th2 = leftAngle * Math.PI / 180;
                    flag[4] = true;
                    result.Text = "输入正确！";
                }
                else
                {
                    flag[4] = false;
                    result.Text = "输入范围错误！";
                }
                
            }
            catch (OverflowException)
            {
                flag[4] = false;
                result.Text = "溢出异常！";
            }
            catch (ArgumentNullException)
            {
                flag[4] = false;
                result.Text = "输入为空！";
            }
            catch (FormatException)
            {
                flag[4] = false;
                result.Text = "格式异常！";
            }



        }

        private void tbRightAngle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double rightAngle = double.Parse(RightAngle.Text.Trim());
                if (rightAngle > 0 && rightAngle < 90)
                {
                    th1 = rightAngle * Math.PI / 180;
                    flag[5] = true;
                    result.Text = "输入正确！";
                }
                else
                {
                    flag[5] = false;
                    result.Text = "输入范围错误！";
                }
                
            }
            catch (OverflowException)
            {
                flag[5] = false;
                result.Text = "溢出异常！";
            }
            catch (ArgumentNullException)
            {
                flag[5] = false;
                result.Text = "输入为空！";
            }
            catch (FormatException)
            {
                flag[5] = false;
                result.Text = "格式异常！";
            }


        }

        private void cbxBrushColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (BrushColor.Text)
            {
                case "blue":
                    penColor = Pens.Blue;

                    break;
                case "red":
                    penColor = Pens.Red;
                    break;
                case "black":
                    penColor = Pens.Black;
                    break;
                case "yellow":
                    penColor = Pens.Yellow;
                    break;
                case "green":
                    penColor = Pens.Green;
                    break;
                default:
                    break;
            }


        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            result.Text = "结果";
        }
    }
}
