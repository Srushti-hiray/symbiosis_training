using System;
namespace structure{
    public struct record{
        public int no;
        public string name;
        public string branch;
        public int sem;
        public string college;

    }
    class insert{
        static void Main(string[] args){
        int n,i;
        Console.Write("enter number of record you want to insert");
        n=Convert.ToInt32(Console.ReadLine());

        record[] records = new record[n+1];
            
            for(i=1;i<n+1;i++){
                Console.WriteLine("record for"+i);

                Console.Write("enter sr.no:");
                records[i].no=Convert.ToInt32(Console.ReadLine());

                Console.Write("enter name:");
                records[i].name=(Console.ReadLine());
                
                Console.Write("enter branch:");
                records[i].branch=(Console.ReadLine());

                Console.Write("enter sem:");
                records[i].sem=Convert.ToInt32(Console.ReadLine());

                Console.Write("enter college:");
                records[i].college=(Console.ReadLine());
                
            }
                Console.WriteLine("*************************************");
            for(i=1;i<=n;i++){
                Console.WriteLine("sr.no: "+records[i].no);
                Console.WriteLine("name: "+records[i].name);
                Console.WriteLine("branch: "+records[i].branch);
                Console.WriteLine("sem: "+records[i].sem);
                Console.WriteLine("college: "+records[i].college);
                Console.WriteLine();
            }

        }
    }
}