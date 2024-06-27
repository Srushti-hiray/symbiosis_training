using System;
namespace num{
    class even{
        static void Main(string[] args){
            int a;
            Console.WriteLine("enter nuber");
            a=Convert.ToInt32(Console.ReadLine());
            if(a%2==0){
                Console.WriteLine("even");

            }
            else{
                Console.WriteLine("odd");
            }
        }
    }
}