using System;
namespace Fibonacci{
    class Program{
        public static void Main(string[] args){
            int n1=0,n2=1,n3,i;
            Console.WriteLine("Enter number of elements");
            int num=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n1 +" " +n2);
            for(i=2;i<num;++i){
                n3=n1+n2;
                Console.WriteLine(n3+" ");
                n1=n2;
                n2=n3;
            }
        }
    }
}