using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 계산기
{
    public partial class Form1 : Form
    {
        enum Operators
        {
            None, Add, Subtract, Multiply, Divide, Result
        }

        Operators currentOperator = Operators.None;
        Operators lastOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        double firstOperand = 0;
        double secondOperand = 0;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(243, 243, 243);
            textBox1.Text = "0";
            timer1.Start();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                textBox1.Text = "";
                operatorChangeFlag = false;
            }

            if (textBox1.Text == "0" && sender != null)
            {
                textBox1.Text = "";
            }

            textBox1.Text += "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                textBox1.Text = "";
                operatorChangeFlag = false;
            }

            if (textBox1.Text == "0" && sender != null)
            {
                textBox1.Text = "";
            }

            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                textBox1.Text = "";
                operatorChangeFlag = false;
            }

            if (textBox1.Text == "0" && sender != null)
            {
                textBox1.Text = "";
            }

            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                textBox1.Text = "";
                operatorChangeFlag = false;
            }

            if (textBox1.Text == "0" && sender != null)
            {
                textBox1.Text = "";
            }

            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                textBox1.Text = "";
                operatorChangeFlag = false;
            }

            if (textBox1.Text == "0" && sender != null)
            {
                textBox1.Text = "";
            }

            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                textBox1.Text = "";
                operatorChangeFlag = false;
            }

            if (textBox1.Text == "0" && sender != null)
            {
                textBox1.Text = "";
            }

            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                textBox1.Text = "";
                operatorChangeFlag = false;
            }

            if (textBox1.Text == "0" && sender != null)
            {
                textBox1.Text = "";
            }

            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                textBox1.Text = "";
                operatorChangeFlag = false;
            }

            if (textBox1.Text == "0" && sender != null)
            {
                textBox1.Text = "";
            }

            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                textBox1.Text = "";
                operatorChangeFlag = false;
            }

            if (textBox1.Text == "0" && sender != null)
            {
                textBox1.Text = "";
            }

            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                textBox1.Text = "";
                operatorChangeFlag = false;
            }

            if (textBox1.Text == "0" && sender != null)
            {
                textBox1.Text = "";
            }

            textBox1.Text += "9";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(textBox1.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (lastOperator != Operators.None)
            {
                // 이전에 수행한 연산을 반복
                if (lastOperator == Operators.Add)
                {
                    firstOperand += secondOperand;
                }
                else if (lastOperator == Operators.Multiply)
                {
                    firstOperand *= secondOperand;
                }
                else if (lastOperator == Operators.Subtract)
                {
                    firstOperand -= secondOperand;
                }
                else if (lastOperator == Operators.Divide)
                {
                    if (secondOperand == 0)
                    {
                        textBox1.Text = "0으로 나눌 수 없습니다.";
                        return;
                    }
                    else
                    {
                        firstOperand /= secondOperand;
                    }
                }

                textBox1.Text = firstOperand.ToString();
            }
            else
            {
                secondOperand = double.Parse(textBox1.Text);

                if (currentOperator == Operators.Add)
                {
                    firstOperand += secondOperand;
                }
                else if (currentOperator == Operators.Multiply)
                {
                    firstOperand *= secondOperand;
                }
                else if (currentOperator == Operators.Subtract)
                {
                    firstOperand -= secondOperand;
                }
                else if (currentOperator == Operators.Divide)
                {
                    if (secondOperand == 0)
                    {
                        textBox1.Text = "0으로 나눌 수 없습니다.";
                        return;
                    }
                    else
                    {
                        firstOperand /= secondOperand;
                    }
                }

                textBox1.Text = firstOperand.ToString();
            }

            // 현재 연산을 lastOperator에 저장
            lastOperator = currentOperator;
            currentOperator = Operators.Result;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(textBox1.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(textBox1.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(textBox1.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            lastOperator = Operators.None;
            textBox1.Text = "0";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double currentValue = double.Parse(textBox1.Text);

                // 현재 값에 0.01을 곱하여 백분율로 계산
                double newValue = currentValue * 0.01;

                // 새로운 값을 textBox1.Text에 설정
                textBox1.Text = newValue.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDisplay(double.Parse(textBox1.Text));
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (textBox1.Text.Length >= 15)
            {
                // 현재 Font 속성을 가져와서 복사
                Font currentFont = textBox1.Font;

                // 새로운 Font 객체 생성, 크기는 20으로 설정 (다른 속성은 유지)
                Font newFont = new Font(currentFont.FontFamily, 30, currentFont.Style);

                // textBox1에 새로운 Font를 할당
                textBox1.Font = newFont;
            }
            if (textBox1.Text.Length >= 18)
            {
                // 현재 Font 속성을 가져와서 복사
                Font currentFont = textBox1.Font;

                // 새로운 Font 객체 생성, 크기는 20으로 설정 (다른 속성은 유지)
                Font newFont = new Font(currentFont.FontFamily, 20, currentFont.Style);

                // textBox1에 새로운 Font를 할당
                textBox1.Font = newFont;
            }
            if (textBox1.Text.Length >= 21)
            {
                // 현재 Font 속성을 가져와서 복사
                Font currentFont = textBox1.Font;

                // 새로운 Font 객체 생성, 크기는 20으로 설정 (다른 속성은 유지)
                Font newFont = new Font(currentFont.FontFamily, 18, currentFont.Style);

                // textBox1에 새로운 Font를 할당
                textBox1.Font = newFont;
            }
            if (textBox1.Text.Length < 12)
            {
                // 현재 Font 속성을 가져와서 복사
                Font currentFont = textBox1.Font;

                // 새로운 Font 객체 생성, 크기는 20으로 설정 (다른 속성은 유지)
                Font newFont = new Font(currentFont.FontFamily, 36, currentFont.Style);

                // textBox1에 새로운 Font를 할당
                textBox1.Font = newFont;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "0")
            {
                double currentValue = double.Parse(textBox1.Text);

                // 양수이면 음수로, 음수이면 양수로 바꾸기
                double newValue = currentValue * -1;

                // 새로운 값을 textBox1.Text에 설정
                textBox1.Text = newValue.ToString();
            }
            // 0이면 아무것도 안함
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double currentValue = double.Parse(textBox1.Text);

                // 루트를 계산하여 새로운 값을 textBox1.Text에 설정
                double newValue = Math.Sqrt(currentValue);

                textBox1.Text = newValue.ToString();
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double currentValue = double.Parse(textBox1.Text);

                // 제곱을 계산하여 새로운 값을 textBox1.Text에 설정
                double newValue = Math.Pow(currentValue, 2);

                textBox1.Text = newValue.ToString();
            }
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double currentValue = double.Parse(textBox1.Text);

                // 역수를 계산하여 새로운 값을 textBox1.Text에 설정
                double reciprocalValue = 1 / currentValue;

                textBox1.Text = reciprocalValue.ToString();
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            // 이미 소수점이 추가되었으면 무시
            if (!textBox1.Text.Contains("."))
            {
                // 현재 문자열이 비어있으면 "0."을 추가
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.Text = "0.";
                }
                else
                {
                    // 소수점 추가
                    textBox1.Text += ".";
                }

                // 연산자 변경 플래그 초기화
                operatorChangeFlag = false;
            }
        }

        private void UpdateDisplay(double value)
        {
            // 숫자를 천 단위로 쉼표(,)를 포함한 문자열로 변환하여 표시
            textBox1.Text = string.Format("{0:#,##0.########}", value);
        }
    }
}
