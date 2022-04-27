using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_converter
{
    public static class ms
    {
        public static string name = "m/s";
        public static float to_kmph(float speed)
        {
            return speed * 3.6f;
        }
        public static float to_mph(float speed)
        {
            return speed * 2.237f;
        }
        public static float to_knots(float speed)
        {
            return speed * 1.943844f;
        }
    }

    public static class kmh
    {
        public static string name = "km/h";
        public static float to_SI_unit(float speed)
        {
            return speed / 3.6f;
        }
    }
    public static class mph
    {
        public static string name = "mph";
        public static float to_SI_unit(float speed)
        {
            return speed / 2.237f;
        }
    }
    public static class knots
    {
        public static string name = "knots";
        public static float to_SI_unit(float speed)
        {
            return speed / 1.943844f;
        }
    }
}