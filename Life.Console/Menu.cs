namespace Life.Menu;
using Life.Base;
using Life.Business;

public class Menu
{
    public static void PrintMenu(){

        Console.WriteLine("Menu");
        Console.WriteLine("1 Calculo de cuotas");
        Console.WriteLine("2 Optener Correos");

        int value = Tools.StringToInt32(Console.ReadLine() ?? "0");

        switch(value) 
        {
             case 1:
            
             PayableParts.CalculateFees();
            
           break;
         case 0:
           // code block
          break;
        default:
          // code block
          break;
        }




    }
}