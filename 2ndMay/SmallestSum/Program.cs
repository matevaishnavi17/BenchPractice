using System;
using System.Linq;
namespace SmallestSum
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number of elements");
            int n=Convert.ToInt32(Console.ReadLine());
            int []arr=new int[n];
            int []sum=new int[n-1];
            Console.WriteLine("Enter elements of array");
            for(int i=0;i<n;i++){
                
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int j=0;j<=n-2;j++){
                int res=arr[j]+arr[j+1];
                sum[j]=res;
            }
            Console.WriteLine("The smallest sum of consecutive number is:"+sum.Min());

        }
    }
}
