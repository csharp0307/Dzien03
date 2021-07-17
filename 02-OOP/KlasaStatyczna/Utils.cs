using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP.KlasaStatyczna
{
    static class Utils
    {
        public static string hostname = "127.0.0.1";

        public static int GetMaxValue(params int[] args)
        {
            return args.Max();
        }
    }
}
