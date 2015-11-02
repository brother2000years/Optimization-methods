using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoggerEvsSpace;
using IntervalSpace;
namespace DSKMethodSpace
{
    public static class DSKMethodCounter
    {
        // Рассчитать значение функции
        private static double countFunctionValue(int funcNumber, double x)
        {
            double answer = 0;
            switch(funcNumber)
            {
                case 0: // функция тестовая
                {
                    answer = Math.Pow(x - 1, 2);
                    break;
                }
                case 1: // Функция А
                {
                    answer = x + (3 / Math.Pow(x, 2));
                    break;
                }
                case 2: // Функция Б
                {
                    answer = 4 * Math.Pow(x, 3) - 8 * Math.Pow(x, 2) - 11 * x + 5;
                    break;
                }
            }
            return answer;
        }

        public static Interval countInterval(int funcNumber, double h, double x_0)
        {
            LoggerEvs.writeLog("DSK method started!");
            Interval answer = new Interval(0, 1);           // Убрать инициализацию
            int functionNumber = 0;                         // Номер функции                        
            double f_x_0;                                   // Значение функции в точке x_0
            double f_x_0_h;                                 // Значение функции в точке x_0 + h            
            bool searchEnd = false;                         // Конец поиска            
            List<double> x_values = new List<double>();     // Коллекция значений x_0
            x_values.Add(x_0);
            // Шаг 1
            f_x_0 = countFunctionValue(funcNumber, x_0);
            f_x_0_h = countFunctionValue(funcNumber, x_0 + h);
            int k = 0;
            LoggerEvs.writeLog("Step 1: f(x_0)=" + f_x_0.ToString("f4") + ", f(x_0 + h)=" + f_x_0_h.ToString("f4") + "; k=0;");
            // Шаг 2
            if (f_x_0 > f_x_0_h)
            {                
                answer.LeftEdge = x_0;
                double x_tmp = x_0 + h;
                x_values.Add(x_tmp);
                k = 2;
                LoggerEvs.writeLog("Step 2: a=" + x_0.ToString("f4") + ", x_1=" + x_tmp.ToString("f4") + ", k=2; Go to step 4!");
                // Перейти на шаг 4
            }
            else
            {
                // Шаг 3
                if (countFunctionValue(funcNumber, x_0 - h) >= f_x_0)
                {
                    answer.LeftEdge = x_0 - h;
                    answer.RightEdge = x_0 + h;
                    LoggerEvs.writeLog("Step 3: a=" + answer.LeftEdge.ToString("f4") + ", b=" + answer.RightEdge.ToString("f4") + "; Go to step 6!");
                    // Перейти на шаг 6
                    searchEnd = true;
                }
                else
                {
                    answer.RightEdge = x_0;
                    x_values.Insert(1, x_0 - h);
                    h = -h;
                    k = 2;
                    LoggerEvs.writeLog("Step 3: b=" + x_0.ToString("f4") + ", x_1=" + (x_0 - h).ToString("f4") + ", h=" + h.ToString("f4") + ", k=2.");
                }
            }
            while (!searchEnd)
            {
                // Шаг 4
                x_values.Insert(k, 0);
                x_values[k] = x_0 + Math.Pow(2, k - 1) * h;
                LoggerEvs.writeLog("Step 4: x_k=" + x_values[k].ToString("f4"));
                // Шаг 5
                if (countFunctionValue(funcNumber, x_values[k - 1]) <= countFunctionValue(funcNumber, x_values[k]))
                {
                    if (h > 0)
                    {
                        answer.RightEdge = x_values[k];
                        LoggerEvs.writeLog("Step 5: h > 0; b=x_k=" + answer.RightEdge.ToString("f4"));
                    }
                    else
                    {
                        answer.LeftEdge = x_values[k];
                        LoggerEvs.writeLog("Step 5: h < 0; a=x_k" + answer.LeftEdge.ToString("f4"));
                    }
                    searchEnd = true;
                }
                else
                {
                    if (h > 0)
                    {
                        answer.LeftEdge = x_values[k - 1];
                        LoggerEvs.writeLog("Step 5: h > 0; a=x_(k-1)=" + answer.LeftEdge.ToString("f4"));
                    }
                    else
                    {
                        answer.RightEdge = x_values[k - 1];
                        LoggerEvs.writeLog("Step 5: h > 0; b=x_(k-1)=" + answer.RightEdge.ToString("f4"));
                    }

                    // Перейти на шаг 4
                    k++;
                    LoggerEvs.writeLog("k = k + 1 = " + k + "; Go to step 4!");
                }
            }
            // Шаг 6
            LoggerEvs.writeLog("Step 6: Interval is: [" + answer.LeftEdge.ToString("f4") + " ; " + answer.RightEdge.ToString("f4") + "]");
            return answer;
        }
    }
}
