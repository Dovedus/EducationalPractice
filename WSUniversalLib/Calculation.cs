using System;

namespace WSUniversalLib
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int product_type, int material_type, int count, float width, float length)
        {
            const float material_type1 = 0.003f;
            const float material_type2 = 0.0012f;
            const float product_type1 = 1.1f;
            const float product_type2 = 2.5f;
            const float product_type3 = 8.43f;

            float a = count * width * length;

            switch (product_type)
            {
                default:
                    return -1;

                case 1:
                    a *= product_type1;
                    break;

                case 2:
                    a *= product_type2;
                    break;

                case 3:
                    a *= product_type3;
                    break;
            }

            switch (material_type)
            {
                default:
                    return -1;
                case 1:
                    a += material_type1 * a;
                    break;

                case 2:
                    a += material_type2 * a;
                    break;
            }

            return Convert.ToInt32(Math.Round((decimal)a, 0, MidpointRounding.AwayFromZero));
        }
    }
}