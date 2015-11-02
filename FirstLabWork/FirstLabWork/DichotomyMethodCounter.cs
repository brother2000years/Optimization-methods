using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoggerEvsSpace;
using IntervalSpace;
namespace DichotomyMethodCounterSpace
{
    public static class DichotomyMethodCounter
    {        
        // Рассчитать значение функции
        private static double countFunctionValue(int funcNumber, double x)
        {
            double answer = 0;
            switch (funcNumber)
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

        public static double findMinimum(Interval searchInterval, double eps, int funcNumber)
        {
            LoggerEvs.writeLog("Dichotomy method has been started!");
            double x_end = 0;                       // Найденное значение x
            double x_1, x_2;                        // Границы промежуточных отрезков                        
            bool countStop = false;                 // Остановка расчетов
            double delta = eps / 10;                // Константа "различимости"
            double f_x_1, f_x_2;
            LoggerEvs.writeLog("Counting: delta = eps / 10 = " + delta);
            for (int i = 0; !countStop; i++)
            {
                // Шаг первый                
                x_1 = 0.5 * (searchInterval.LeftEdge + searchInterval.RightEdge) - delta;
                x_2 = 0.5 * (searchInterval.LeftEdge + searchInterval.RightEdge) + delta;
                LoggerEvs.writeLog(string.Format("Step 1: counting x_1 = {0:f4}, x_2 = {1:f4}", x_1, x_2));
                // Шаг второй (вычисление) и третий (сравнение)                
                f_x_1 = countFunctionValue(funcNumber, x_1);
                f_x_2 = countFunctionValue(funcNumber, x_2);
                if (f_x_1 <= f_x_2)
                {
                    searchInterval.RightEdge = x_2;
                    LoggerEvs.writeLog(string.Format("Step 3: f({0:f4}) = {1:f4} <= f({2:f4}) = {3:f4}; b = x_2 = {4:f4}.", x_1, f_x_1, x_2, f_x_2, x_2));
                }
                else
                {
                    searchInterval.LeftEdge = x_1;
                    LoggerEvs.writeLog(string.Format("Step 3: f({0:f4}) = {1:f4} > f({2:f4}) = {3:f4}; a = x_1 = {4:f4}.", x_1, f_x_1, x_2, f_x_2, x_1));
                }
                // Шаг четвертый
                double diff = (searchInterval.RightEdge - searchInterval.LeftEdge)/2;
                if ( diff < eps)
                {
                    countStop = true;
                    LoggerEvs.writeLog(string.Format("Step 4: (b-a)/2 = {0:f4} < eps = {1:f4}; STOP SEARCHING!", diff, eps));
                }
                LoggerEvs.writeLog("Iter " + i + ": Answer is in the range: [" + searchInterval.LeftEdge.ToString("f4") + "; " + searchInterval.RightEdge.ToString("f4") + "]");
            }
            // Шаг пятый
            x_end = (searchInterval.LeftEdge + searchInterval.RightEdge) / 2;
            // Вывод результата
            LoggerEvs.writeLog("Step 5: x_end = (a+b)/2; Minimum x* is: " + x_end.ToString("f4"));
            return x_end;
        }
    
    }
}
