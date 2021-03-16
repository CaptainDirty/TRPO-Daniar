using System;

namespace TRPO_Lab3.Lib
{
    public class Channel
    {
        public static double Formula(double R, double r, double h)
        {
            if (R <= 0)
            {
                throw new ArgumentException("Переменная R не может быть отрицательной");
            }
            if (r <= 0)
            {
                throw new ArgumentException("Переменная r не может быть отрицательной");
            }
            if (h <= 0)
            {
                throw new ArgumentException("Переменная h не может быть отрицательной");
            }
            return Math.PI * R*(2d * h + r);
        }
    }
}
