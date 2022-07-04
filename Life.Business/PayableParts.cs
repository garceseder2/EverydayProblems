namespace Life.Business;
using Life.Base;

public class PayableParts
{
    //public PayableParts() { }
    public static void CalculateFees()
    {
        Console.WriteLine("Calculo recibo de agua");

        Console.WriteLine("Digite Valor de servicio de agua:");
        var serviceValue = Tools.StringToDouble(Console.ReadLine() ?? "0.00");

        Console.WriteLine("Digite Valor de servicio de Aseo Residencial:");
        var residentialCleaning = Tools.StringToDouble(Console.ReadLine() ?? "0.00");

        Console.WriteLine("Digite Valor de servicio de Aseo NO Residencial:");
        var noResidentialCleaning = Tools.StringToDouble(Console.ReadLine() ?? "0.00");

        Console.WriteLine("Digite Valor de servicio del Aporte:");
        var contribution = Tools.StringToDouble(Console.ReadLine() ?? "0.00");

        Console.WriteLine("Digite Valor del Subsidio:");
        var subsidy = Tools.StringToDouble(Console.ReadLine() ?? "0.00");

        Console.WriteLine("Digite Valor del Ajustes:");
        var adjustmentValue = Tools.StringToDouble(Console.ReadLine() ?? "0.00");

        Console.WriteLine("Digite Valor de cobros no Autorizados:");
        var unauthorizedCharges = Tools.StringToDouble(Console.ReadLine() ?? "0.00");
        

        double neighborsShare = NeighborsShare(serviceValue,residentialCleaning,contribution,subsidy, adjustmentValue, unauthorizedCharges);
        double myShare=MyShare(serviceValue,residentialCleaning,contribution,subsidy, adjustmentValue, unauthorizedCharges);
        double localShare=LocalShare(serviceValue,noResidentialCleaning,contribution,subsidy, adjustmentValue, unauthorizedCharges);
        string total = (neighborsShare + localShare + myShare).ToString("C");
        
        

        Console.WriteLine("┌------------------┬------------------┬------------------┬------------------┐");
        Console.WriteLine("|{0} |{1} |{2} |{3} |",("Cuota del vecino").PadLeft(17,' '),("Cuota del local").PadLeft(17,' '),("Mi Cuota").PadLeft(17,' '),("Total").PadLeft(17,' '));
        Console.WriteLine("├------------------┼------------------┼------------------┼------------------┤");
        Console.WriteLine("|{0} |{1} |{2} |{3} |",neighborsShare.ToString("C").PadLeft(17,' '),localShare.ToString("C").PadLeft(17,' '),myShare.ToString("C").PadLeft(17,' '),total.PadLeft(17,' '));
        Console.WriteLine("└------------------┴------------------┴------------------┴------------------┘");
    }
    

    private static double NeighborsShare(double serviceValue,double residentialCleaning, double contribution,double subsidy,double adjustmentValue, double unauthorizedCharges)
    {
        
        double neighborsShareValue =  (serviceValue*0.3)+(residentialCleaning/2)+(contribution/3)-(subsidy/3)+(adjustmentValue/3)-(unauthorizedCharges/3);
        return neighborsShareValue;

    }
    
    private static double LocalShare(double serviceValue,double noResidentialCleaning, double contribution, double subsidy, double adjustmentValue, double unauthorizedCharges)
    {
        
        double localShareValue =  (serviceValue*0.4)+(noResidentialCleaning)+(contribution/3)-(subsidy/3)+(adjustmentValue/3)-(unauthorizedCharges/3);
        return localShareValue;
    }
    
    private static double MyShare(double serviceValue,double residentialCleaning, double contribution,double subsidy, double adjustmentValue, double unauthorizedCharges)
    {
        double myShareValue = NeighborsShare(serviceValue,residentialCleaning,contribution,subsidy,  adjustmentValue, unauthorizedCharges);
        return myShareValue;

    }
    
}