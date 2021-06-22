using System;

namespace underflow_overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = Convert.ToByte(Console.ReadLine());
            byte otherByte = Convert.ToByte(Console.ReadLine());
            //Sum(myByte, otherByte);
            Substract(myByte, otherByte);
        }

        public static void Sum(byte first, byte second)
        {
            byte newValue = first += second;
            Console.WriteLine(newValue);
            if (first > newValue | second > newValue)
            {
                Console.WriteLine("Overflow");
            }
        }

        public static void Substract(byte first, byte second)
        {
            byte newValue = first -= second;
            Console.WriteLine(newValue);
            if (first < newValue | second < newValue)
            {
                Console.WriteLine("Underflow");
            }
        }
    }
}
