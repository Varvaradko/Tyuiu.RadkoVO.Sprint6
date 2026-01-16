using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RadkoVO.Sprint6.Task1.V22.Lib
{
    public class DataService : ISprint6Task1V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + 1; // знаменатель дроби
                double y;

                if (Math.Abs(denominator) < 0.00001) // проверка деления на 0 с учетом погрешности
                {
                    y = 0;
                }
                else
                {
                    y = 3 * x + 2 - ((2 * x - x) / denominator);
                    y = Math.Round(y, 2);
                }

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
