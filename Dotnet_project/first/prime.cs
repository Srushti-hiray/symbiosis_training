using System;
class prime{
    static void Main(string[] args)
    {
        int i,j,num;
        int flag=0;
        for(i=1;i<100;i++){
            for(j=2;j<i;j++){
            if(i!=j){
               num= i%j;
               if(num==0){
                flag=1;
                
               }
               
            }
            
        }
        if (flag==0){
                Console.WriteLine(i);

            }
            flag=0;
        }
        
    }
}