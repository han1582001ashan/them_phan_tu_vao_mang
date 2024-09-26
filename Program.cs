using System;
using System.Buffers;
namespace addArray
{
    class Program{
        static void Main(string[] args){
           int[] array = {10,4,6,7, 8, 0, 0, 0, 0, 0};
           Console.Write("Array: ");
           for(int i=0; i<array.Length; i++ ){
            Console.Write("{0}, ", array[i]);
           }

           Console.WriteLine("Input index: ");
           int index= Int32.Parse(Console.ReadLine());
           Console.WriteLine("Input value: ");
           int x= Int32.Parse(Console.ReadLine());
           if(index >array.Length || index<0){
            Console.WriteLine("can not insert");
           }else{
            for (int i=array.Length-1; i>index; i--){
                 array[i]=array[i-1];

            }
            array[index]=x;


           }
           Console.Write("New Array: ");
           for(int i=0; i<array.Length; i++ ){
            Console.Write("{0}, ", array[i]);
           }

        }
    }
}