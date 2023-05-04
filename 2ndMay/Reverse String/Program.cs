using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string originalstring=Console.ReadLine();
            string reversestring=string.Empty;
            for(int i=originalstring.Length-1;i>=0;i--){
                reversestring+=originalstring[i];
            }
            Console.WriteLine("Reverse string: "+reversestring);
        }
    }
}
