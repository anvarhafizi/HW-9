using System;
using System.Linq;

namespace MyprojecsApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    static class ArrayHelper
    {
        public static string Pop(ref string[] Arr)
        {
            int IRE = Arr.Length - 1;
            string RE = Arr[IRE];
            Arr = Arr.Where((item, index) => index != IRE).ToArray();
            return RE;
        }
        public static int Pop(ref int[] Arr)
        {
            int IRE = Arr.Length - 1;
            int RE = Arr[IRE];
            Arr = Arr.Where((item, index) => index != IRE).ToArray();
            return RE;
        }
        public static double Pop(ref double[] Arr)
        {
            int IRE = Arr.Length - 1;
            double RE = Arr[IRE];
            Arr = Arr.Where((item, index) => index != IRE).ToArray();
            return RE;
        }
        public static Decimal Pop(ref Decimal[] Arr)
        {
            int IRE = Arr.Length - 1;
            Decimal RE= Arr[IRE];
            Arr = Arr.Where((item, index) => index != IRE).ToArray();
            return RE;
        }
        public static float Pop(ref float[] Arr)
        {
            int IRE = Arr.Length - 1;
            float RE = Arr[IRE];
            Arr = Arr.Where((item, index) => index != IRE).ToArray();
            return RE;
        }

        public static int Push(ref string[] Arr, string Element)
        {
            Arr = Arr.Concat(new string[] { Element }).ToArray();
            int LUA = Arr.Length;
            return LUA;
        }
        public static int Push(ref int[] Arr, int Element)
        {
            Arr = Arr.Concat(new int[] { Element }).ToArray();
            int LUA = Arr.Length;
            return LUA;
        }
        public static int Push(ref double[] Arr, double Element)
        {
            Arr = Arr.Concat(new double[] { Element }).ToArray();
            int LUA = Arr.Length;
            return LUA;
        }
        public static int Push(ref Decimal[] Arr, Decimal Element)
        {
            Arr = Arr.Concat(new Decimal[] { Element }).ToArray();
            int LUA = Arr.Length;
            return LUA;
        }
        public static int Push(ref float[] Arr, float Element)
        {
            Arr = Arr.Concat(new float[] { Element }).ToArray();
            int LUA = Arr.Length;
            return LUA;
        }
 
        public static string Shift(ref string[] Arr)
        {
            string RE = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RE;
        }
        public static int Shift(ref int[] Arr)
        {
            int RE = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RE;
        }
        public static double Shift(ref double[] Arr)
        {
            double RE = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RE;
        }
        public static Decimal Shift(ref Decimal[] Arr)
        {
            Decimal RE = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RE;
        }
        public static float Shift(ref float[] Arr)
        {
            float RE = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RE;
        }

        public static int UnShift(ref string[] Arr, string Element)
        {
            var NewArray = new string[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LUA = NewArray.Length;
            return LUA;
        }
        public static int UnShift(ref int[] Arr, int Element)
        {
            var NewArray = new int[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LUA = NewArray.Length;
            return LUA;
        }
        public static int UnShift(ref double[] Arr, double Element)
        {
            var NewArray = new double[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LUA = NewArray.Length;
            return LUA;
        }
        public static int UnShift(ref Decimal[] Arr, Decimal Element)
        {
            var NewArray = new Decimal[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LUA = NewArray.Length;
            return LUA;
        }
        public static int UnShift(ref float[] Arr, float Element)
        {
            var NewArray = new float[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LUA = NewArray.Length;
            return LUA;
        }
    }
}