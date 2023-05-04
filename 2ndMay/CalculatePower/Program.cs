using System;

namespace CalculatePower
{
    class Program
    {

        public static int Power(int exponent,int baseNum){
            int result=1;
            if(exponent==0)
            return 1;
            if(baseNum==0)
            return 0;

            for(int i=1;i<=exponent;i++){
                result=result*baseNum;
                
            }
            return result;
        }
        static void Main(string[] args)
        {
           Console.WriteLine("Enter Base Number");
           int baseNum=Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter Exponent:");
           int exponent=Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(Power(exponent,baseNum));
        }
    }
}
