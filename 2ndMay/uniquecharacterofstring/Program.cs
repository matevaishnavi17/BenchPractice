using System;

namespace uniquecharacterofstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str=Console.ReadLine();
            for(int i=0;i<str.Length;i++){
                int flag=0;
                for(int j=0;j<str.Length;j++){
                    if(str[i]==str[j]&& i!=j){
                        flag=1;
                        break;

                    }
                }
                if(flag==0){
                    Console.WriteLine(str[i]);
                }
            }
        }
    }
}

