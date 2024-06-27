using System;
class matrix{
    static void Main(string[] args){
        int i,j;
        int op,ch;
        int[,] mat=new int[3,3];
        int[,] mat2=new int[3,3];
        int[,] mat3=new int[3,3];

        Console.WriteLine("Enter the matrix");
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                mat[i,j]=Convert.ToInt32(Console.ReadLine());

            }
        }

        Console.WriteLine("Enter the matrix");
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                mat2[i,j]=Convert.ToInt32(Console.ReadLine());

            }
        }
        do{
        Console.WriteLine("1:Addition");
        Console.WriteLine("2:substraction");
        Console.WriteLine("3:divisiom");
        Console.WriteLine("4:Multiplication");
        Console.WriteLine("5:Modulus");
        Console.WriteLine("6:Transpose of matrix");
        Console.WriteLine("7:Interchange rows");
        Console.WriteLine("8:Interchange column");
        op=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        switch(op){
            case 1:
            for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                mat3[i,j]=mat[i,j]+mat2[i,j];

            }
        }
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                Console.Write(mat3[i,j]+" ");

            }
            Console.WriteLine();
        }
         break;
        case 2:
            for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                mat3[i,j]=mat[i,j]-mat2[i,j];

            }
        }
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                Console.Write(mat3[i,j]+" ");

            }
            Console.WriteLine();
        }
         break;
        case 3:
            for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                mat3[i,j]=mat[i,j]/mat2[i,j];

            }
        }
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                Console.Write(mat3[i,j]+" ");

            }
            Console.WriteLine();
        }
         break;
         case 4:
            for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                mat3[i,j]=mat[i,j]*mat2[i,j];

            }
        }
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                Console.Write(mat3[i,j]+" ");

            }
            Console.WriteLine();
        }
         break;
         case 5:
            for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                mat3[i,j]=mat[i,j]%mat2[i,j];

            }
        }
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                Console.Write(mat3[i,j]+" ");

            }
            Console.WriteLine();
        }
         break;
         case 6:
            for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                mat3[j,i]=mat[i,j];

            }
        }
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                Console.Write(mat3[i,j]+" ");

            }
            Console.WriteLine();
        }
         break;
         case 7:
            for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                mat3[((i+1)%3),j]=mat[i,j];

            }
        }
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                Console.Write(mat3[i,j]+" ");

            }
            Console.WriteLine();
        }
         break;
        case 8:
            for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                mat3[i,((j+1)%3)]=mat[i,j];

            }
        }
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                Console.Write(mat3[i,j]+" ");

            }
            Console.WriteLine();
        }
         break;

        }
        
        Console.WriteLine("do you want to continue, then enter 1");
        ch=Convert.ToInt32(Console.ReadLine());
        }while(ch==1);

    }
}