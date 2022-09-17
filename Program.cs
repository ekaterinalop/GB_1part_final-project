// массив строк.Создать массив строк с меньше либо равно 3 символа
using System;
class Program
{

static void Main(string[] args)
{
   Console.WriteLine("Введите через запятую несколько элементов текста");
   string text=Console.ReadLine();  
   string[] array=text.Split(",");
   string selection="[";
      
   for (int i = 0; i < array.Length; i++)
    { 
        if (array[i].Length<=3)
        selection=selection+array[i]+",";
    }  
    string[] result=selection.Split(",");
       
    for (int i = 0; i < result.Length-2; i++)
    {
        Console.Write (result[i]+",");
    }
    Console.Write (result[(result.Length-2)]+"]");
               
}
}