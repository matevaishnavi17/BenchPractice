using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,r,i,temp,sum=0;
            Console.WriteLine("Enter Number");
            n=Convert.ToInt32(Console.ReadLine());
            temp=n;
            while(n>0){
                r=n%10;
                sum=(sum*10)+r;
                n=n/10;
            }
            if(temp==sum){
                Console.WriteLine("Number is Palindrome");
            }
            else{
                Console.WriteLine("Number is not Palindrome");
            }
        }
    }
}
