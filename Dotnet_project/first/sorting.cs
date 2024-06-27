using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
class sorting{

static void selection(){
    int[] arr={2,5,8,1};
    int i,j;
    int temp;
    for(i=0;i<arr.Length;i++){
        int min_ind=i;
        for(j=i+1;j<arr.Length;j++){
            if(arr[j]<arr[min_ind]){
                min_ind=j;
            }

        }
        temp=arr[min_ind];
        arr[min_ind]=arr[i];
        arr[i]=temp;
        
        

    }
    Console.WriteLine("array before sorting: 2 5 8 1");
        
        Console.WriteLine("array after selection sorting:");
        for(i=0;i<arr.Length;i++){
           Console.WriteLine(arr[i]);
        }
    
}
static void insertion(){
    int[] arr={2,5,8,1};
    int i,j;
    int key;
    for(i=1;i<4;i++){
        key=arr[i];
        j=i-1;
    
    while(j>=0 && arr[j]>key){
        arr[j+1]=arr[j];
        j=j-1;
    }
    arr[j+1]=key;
    }
    Console.WriteLine("array before sorting: 2 5 8 1");
        
        Console.WriteLine("array after insertion sorting:");
        for(i=0;i<arr.Length;i++){
           Console.WriteLine(arr[i]);
        }
}
static void bubble(){
    int i,j,temp;
    bool sort;
    int[] arr={2,5,8,1};
    for(i=0;i<3;i++){
        sort=false;
        for(j=0;j<3-i;j++){
            if(arr[j]>arr[j+1]){
                temp=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
                sort=true;
            }
        }
        if(sort==false){
            break;
        }
    }
    Console.WriteLine("array before sorting: 2 5 8 1");
        
        Console.WriteLine("array after bubble sorting:");
        for(i=0;i<arr.Length;i++){
           Console.WriteLine(arr[i]);
        }
}
static void search(){
    int i,a,flag=0;
    int[] ar={2,5,8,1};
    Console.WriteLine("Emter element you want to serach");
    a=Convert.ToInt32(Console.ReadLine());
    for(i=0;i<3;i++){

        if(ar[i]==a){
            //flag=1;
            Console.WriteLine("element found at index:"+i);
        }
       
        

        }
    


}

static void Main(string[] args){
selection();
insertion();
bubble();
search();
}
}