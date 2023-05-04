using System;

namespace ReverseStringWithRecurssion
{
    class Program
    {
        public static string Reverse(string Input){
            if(Input.Length<=1){
                return Input;
            }
            char firstLetter=Input[0];
            string rest=Input.Substring(1);
            return Reverse(rest)+firstLetter;
        }
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            Console.WriteLine(Reverse(Input));
        }
    }
}
