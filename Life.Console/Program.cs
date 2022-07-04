using Life.Business;
try
{
    PayableParts.CalculateFees();
}
catch (Exception ex)
{
    Console.WriteLine("Error en el sistema {0}", ex.ToString());
}
 