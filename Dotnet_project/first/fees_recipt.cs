using System;
class recipt{
    public static void Main(string[] args){
        
        string name,branch;
        int year,sem,entrance=10000,exam=1500,library=1000,hostel=30000,lab=20000,pro=40000;
        int total=entrance+exam+library+hostel+lab+pro;
        Console.WriteLine("Enter name: ");
        name=Console.ReadLine();
        Console.WriteLine("Enter branch: ");
        branch=Console.ReadLine();
        Console.WriteLine("Enter year: ");
        year=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter sem: ");
        sem=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("--------------------------------------");
        Console.WriteLine(" * Sanjivani College of Engineering * ");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine(" ~       Academic fees Recipt        ~");
        Console.WriteLine("--------------------------------------");
        Console.Write("Name     : "+name+"         ");
       // DateTime obj=DateTime.Now;
        
       Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
        Console.Write("Branch   : "+branch+"              ");
        Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
        Console.WriteLine("Year     : "+year);
        Console.WriteLine("semester : "+name);
        Console.WriteLine("1] Entrance                  "+entrance);
        Console.WriteLine("2] Exam                      "+exam);
        Console.WriteLine("3] Library                   "+library);
        Console.WriteLine("4] Hostel                    "+hostel);
        Console.WriteLine("5] Labarotory                "+lab);
        Console.WriteLine("6] Project & class           "+pro);
         Console.WriteLine("--------------------------------------");
        Console.WriteLine("    Total :                rs"+total);
        Console.WriteLine("                            +18%GST");
         Console.WriteLine("--------------------------------------");
        Console.WriteLine("    Grand Total:             "+(total+total*0.18));

    }
}