using System;

class rectangle{
    int area;
    public static void Print(int a,int b){
        area=a*b;
        Console.Write(area);
    }
}
class square : rectangle{
    string adi="aditi";
}
class objec{
static void Main(string[] args){
    square obj=new square();
    obj.print(5,6);
}
}