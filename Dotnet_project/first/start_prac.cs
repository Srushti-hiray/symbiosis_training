/*using System;
class star5{
    static void Main(string[] args){
        int i,j,k;
        int num=10;
        for(i=num;i>0;i--){
            for(j=i;j<num;j++){
                Console.Write(" ");

            }
            for(k=0;k<((i*2)-1);k++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
using System;
class area{
    static void Main(string[] args){
        int a,b;
        double c;
        Console.WriteLine("Enter two number as lenght as breath");
        a=Convert.ToInt32(Console.ReadLine());
        b=Convert.ToInt32(Console.ReadLine());
        c= 0.5 * a * b;

        Console.WriteLine("area of polygon is:"+c);
        c=a*b;
        Console.WriteLine("area of rectangle is:"+c);

    }
}
*/
using System;
class star6{
    static void Main(string[] args){
        int i,j,k;
        int n=5;
        //int d=n/2;
        for(i=1;i<=n;i++){
            for(j=0;j<n;j++){
                Console.Write(" ");
            }
            for(k=0;k<=((i*2)-1);k++){
                Console.Write("*");
            }Console.WriteLine();
        }

    }
}