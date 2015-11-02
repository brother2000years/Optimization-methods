using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DichotomyMethodCounterSpace;
using PowellMethodCounterSpace;
using LoggerEvsSpace;
using DSKMethodSpace;
using IntervalSpace;
namespace FirstLabWork
{
    public partial class Form1 : Form
    {
        Interval argInterval = new Interval();
        int funcNumber = -1;
        public Form1()
        {
            double eps = 0.01;
            LoggerEvs.messageCame += writeToLogWidget;
            InitializeComponent();
            LoggerEvs.writeLog("Application has been started!");
            rbDichotomy.Checked = true;
            rbFuncTest.Checked = true;
            funcNumber = 0;
            nudEpsilon.Value = Convert.ToDecimal(eps);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {   // Кнопка "Рассчитать" нажата
            // Проверить размер шага
            if(correctDatainput())
            {
                setFunctionNumber();
                argInterval = DSKMethodCounter.countInterval(funcNumber, Convert.ToDouble(nudH.Value), Convert.ToDouble(nudX0.Value));
                // Выбор метода расчета            
                double answer = 0;
                if (rbDichotomy.Checked)
                {
                    answer = DichotomyMethodCounter.findMinimum(argInterval, Convert.ToDouble(nudEpsilon.Value), funcNumber);
                    tbDichotomyAnswer.Text = answer.ToString("f4");
                }
                else if (rbPowell.Checked)
                {
                    answer = PowellMethodCounter.findMinimum(argInterval, Convert.ToDouble(nudEpsilon.Value), funcNumber);
                    tbPowellAnswer.Text = answer.ToString("f4");
                }            
            }                
        }
   
        // Метод для записи логов в специальный виджет
        public void writeToLogWidget(string message)
        {
            rtbLogs.AppendText(message);
            rtbLogs.ScrollToCaret();
        }

        // Проверить входные данные
        private bool correctDatainput()
        {
            bool correctData = true;
            if (nudH.Value <= 0)
            {
                LoggerEvs.writeLog("Step h must be > 0");
                correctData = false;
            }
            else if (funcNumber == -1)
            {
                LoggerEvs.writeLog("Choose the function for counting.");
                correctData = false;
            }
            else if (nudEpsilon.Value <= 0 || nudEpsilon.Value >= 1)
            {
                LoggerEvs.writeLog("Epsilon must be > 0 and < 1!");
                correctData = false;
            }
            return correctData;
        }

        // Установить номер расчетной функции
        private void setFunctionNumber()
        {
            if (rbFuncA.Checked)
                funcNumber = 1;
            else if (rbFuncB.Checked)
                funcNumber = 2;
            else if (rbFuncTest.Checked)
                funcNumber = 0;
        }
    }
}
