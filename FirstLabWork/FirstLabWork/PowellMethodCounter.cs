using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoggerEvsSpace;
using IntervalSpace;
namespace PowellMethodCounterSpace
{
    public static class PowellMethodCounter
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
            bool searchEnd = false;                 // Конец поиска                        
            double x_min;                           // Значение x, при котором функция будет принимать минимальное значение
            double[] x_values = new double[4];      // Набор значений x
            double x_answer;                        // Найденный ответ

            // Начало расчетов по методу Пауэлла
            LoggerEvs.writeLog("Powell's method has been started!");

            // Шаг первый
            x_values[0] = searchInterval.LeftEdge;
            x_values[1] = 0.5 * (searchInterval.LeftEdge + searchInterval.RightEdge);
            x_values[2] = searchInterval.RightEdge;
            LoggerEvs.writeLog(string.Format("Step 1: (x1, x2, x3) = ({0:f4}, {1:f4}, {2:f4}).", x_values[0], x_values[1], x_values[2]));
            
            for (int iter = 0; !searchEnd; iter++)
            {
                // Шаг второй
                x_min = findMinimum(x_values[0], x_values[1], x_values[2], funcNumber);
                LoggerEvs.writeLog(string.Format("Step 2: x_min value, when function has minimum value: {0:f4}.", x_min));

                // Шаг третий
                x_values[3] = findXFour(x_values[0], x_values[1], x_values[2], funcNumber);
                LoggerEvs.writeLog(string.Format("Step 3: count x4; x4 = {0:f4}.", x_values[3]));

                // Шаг четвертый
                if (Math.Abs(x_values[3] - x_min) <= eps)
                {
                    LoggerEvs.writeLog(string.Format("Step 4: |x4 - x_min| <= eps, |{0:f4} - {1:f4}| <= {2:f4} go to step 7!", x_values[3], x_min, eps));
                    // Перейти на шаг седьмой, поиск окончен
                    searchEnd = true;
                }
                else
                {
                    // Шаг пятый
                    LoggerEvs.writeLog("Step 5: Sorting x values: x1 < x2 < x3 < x4");
                    sort(ref x_values);

                    // Шаг шестой
                    double[] funcValues = new double[4];
                    // Вычислить значения функций от каждого аргумента
                    for (int i = 0; i < 4; i++)
                        funcValues[i] = countFunctionValue(funcNumber, x_values[i]);
                    // Отсортировать аргументы, чтобы получить первые три, при которых значения функций будут наименьшими
                    LoggerEvs.writeLog("Step 6: Sorting x values, for get first 3 values with which function's values will be minimal...");
                    sortXValues(ref x_values, funcValues);
                }
            }
            // Шаг седьмой
            x_answer = x_values[3];
            LoggerEvs.writeLog(string.Format("Step 7: Answer is {0:f4}", x_values[3]));
            return x_answer;
        }

        static void sortXValues(ref double[] x_values, double[] funcValues)
        {
            double buff_x, buff_f; // Буферы для временного хранения x и значения функции

            // Отсортировать аргументы в порядке возрастания функции
            for (int i = 0; i < funcValues.Length - 1; i++)
            {
                for (int j = 0; j < funcValues.Length - i - 1; j++)
                {
                    if (funcValues[j] > funcValues[j + 1])
                    {
                        buff_f = funcValues[j];
                        funcValues[j] = funcValues[j + 1];
                        funcValues[j + 1] = buff_f;

                        buff_x = x_values[j];
                        x_values[j] = x_values[j + 1];
                        x_values[j + 1] = buff_x;
                    }
                }
            }
            // Отсортировать значения x для формирования отрезка
            buff_x = x_values[0];
            x_values[0] = x_values[1];
            x_values[1] = buff_x;
        }

        
        private static double findMinimum(double x_1, double x_2, double x_3, int funcNum)
        {
            double minFuncValue = countFunctionValue(funcNum, x_1);
            double x_answer = x_1;
            if (minFuncValue > countFunctionValue(funcNum, x_2))
            {
                minFuncValue = countFunctionValue(funcNum, x_2);
                x_answer = x_2;
                if (minFuncValue > countFunctionValue(funcNum, x_3))
                {
                    minFuncValue = countFunctionValue(funcNum, x_3);
                    x_answer = x_3;
                }
            }
            else if (minFuncValue > countFunctionValue(funcNum, x_3))
            {
                minFuncValue = countFunctionValue(funcNum, x_3);
                x_answer = x_3;
            }
            return x_answer;
        }

        /// <summary>
        /// Найти значение x4
        /// </summary>
        /// <param name="x_1"></param>
        /// <param name="x_2"></param>
        /// <param name="x_3"></param>
        /// <returns></returns>
        private static double findXFour(double x_1, double x_2, double x_3, int funcNum)
        {
            double answer;  // Результат
            // Числитель
            double numerator = (Math.Pow(x_2, 2) - Math.Pow(x_3, 2)) * countFunctionValue(funcNum, x_1) + (Math.Pow(x_3, 2) - Math.Pow(x_1, 2)) * countFunctionValue(funcNum, x_2) + (Math.Pow(x_1, 2) - Math.Pow(x_2, 2)) * countFunctionValue(funcNum, x_3);
            // Знаменатель
            double denominator = (x_2 - x_3) * countFunctionValue(funcNum, x_1) + (x_3 - x_1) * countFunctionValue(funcNum, x_2) + (x_1 - x_2) * countFunctionValue(funcNum, x_3);
            answer = 0.5 * numerator / denominator;
            return answer;
        }

        /// <summary>
        /// Отсортировать массив по возрастанию
        /// </summary>
        /// <param name="x_values"></param>
        private static void sort(ref double[] x_values)
        {
            double buff; // Буфер для временного хранения x
            for (int i = 0; i < x_values.Length - 1; i++)
            {
                for (int j = 0; j < x_values.Length - i - 1; j++)
                {
                    if (x_values[j] > x_values[j + 1])
                    {
                        buff = x_values[j];
                        x_values[j] = x_values[j + 1];
                        x_values[j + 1] = buff;
                    }
                }
            }
        }    
    }
}
