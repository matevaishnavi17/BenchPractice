using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string a=Console.ReadLine();
            Console.WriteLine("Enter second string");
            string b=Console.ReadLine();
            string reverseString=null;
            for(int i=b.Length-1;i>=0;i--){
                reverseString+=b[i];
            }
            if(a.Equals(reverseString)){
                Console.WriteLine("Both are equal");
            }
            else{
                Console.WriteLine("Both are not equal");
            }
        }
    }
}
