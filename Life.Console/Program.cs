
using Life.Menu;

try
{
    Menu.PrintMenu();
}
catch (Exception ex)
{
    Console.WriteLine("Error en el sistema {0}", ex.ToString());
}
 