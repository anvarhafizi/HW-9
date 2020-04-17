using System;
using System.Linq;

namespace MyprojecsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ArrayString = { "a", "b", "c", "d", "е", "f" };
            int[] ArrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] ArrayDouble = { 5.1, 5.2, 5.3, 5.4, 5.5, 5.6, 5.7, 5.8, 5.9 };
            Decimal[] ArrayDecimal = { 2.1m, 2.2m, 2.3m, 2.4m, 2.5m, 2.6m, 2.7m };
            float[] ArrayFloat = { 6.1f, 6.2f, 6.3f, 6.4f, 6.5f, 5.6f, 6.7f, 6.8f, 6.9f };
            Console.WriteLine($"Removed item from array ArrayString: {ArrayHelper.Pop(ref ArrayString)}");
            Console.WriteLine($"Removed item from array ArrayInt: {ArrayHelper.Pop(ref ArrayInt)}");
            Console.WriteLine($"Removed item from array ArrayDouble: {ArrayHelper.Pop(ref ArrayDouble)}");
            Console.WriteLine($"Removed item from array ArrayDecimal: {ArrayHelper.Pop(ref ArrayDecimal)}");
            Console.WriteLine($"Removed item from array ArrayFloat: {ArrayHelper.Pop(ref ArrayFloat)}\n\n");

            Console.WriteLine($"The length of the ArrayString array after adding another element from the end of the array: {ArrayHelper.Push(ref ArrayString, "J")}");
            Console.WriteLine($"The length of the ArrayInt array after adding another element from the end of the array: {ArrayHelper.Push(ref ArrayInt, 11)}");
            Console.WriteLine($"The length of the ArrayDouble array after adding another element from the end of the array: {ArrayHelper.Push(ref ArrayDouble, 6.0)}");
            Console.WriteLine($"The length of the ArrayDecimal array after adding another element from the end of the array: {ArrayHelper.Push(ref ArrayDecimal, 2.8m)}");
            Console.WriteLine($"The length of the ArrayFloat array after adding another element from the end of the array: {ArrayHelper.Push(ref ArrayFloat, 7.0f)}\n\n");

            Console.WriteLine($"Removed item from array ArrayString: {ArrayHelper.Shift(ref ArrayString)}");
            Console.WriteLine($"Removed item from array ArrayInt: {ArrayHelper.Shift(ref ArrayInt)}");
            Console.WriteLine($"Removed item from array ArrayDouble: {ArrayHelper.Shift(ref ArrayDouble)}");
            Console.WriteLine($"Removed item from array ArrayDecimal: {ArrayHelper.Shift(ref ArrayDecimal)}");
            Console.WriteLine($"Removed item from array ArrayFloat: {ArrayHelper.Shift(ref ArrayFloat)}\n\n");

            Console.WriteLine($"The length of the ArrayString array after adding another element to the beginning of the array: {ArrayHelper.UnShift(ref ArrayString, "Aa")}");
            Console.WriteLine($"The length of the ArrayInt array after adding another element to the beginning of the array: {ArrayHelper.UnShift(ref ArrayInt, 0)}");
            Console.WriteLine($"The length of the ArrayDouble array after adding another element to the beginning of the array: {ArrayHelper.UnShift(ref ArrayDouble, 5.0)}");
            Console.WriteLine($"The length of the ArrayDecimal array after adding another element to the beginning of the array: {ArrayHelper.UnShift(ref ArrayDecimal, 2.0m)}");
            Console.WriteLine($"The length of the ArrayFloat array after adding another element to the beginning of the array: {ArrayHelper.UnShift(ref ArrayFloat, 6.0f)}\n\n");
            Console.ReadKey();
            System.Console.WriteLine("");
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