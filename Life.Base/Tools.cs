namespace Life.Base;

public class Tools
{
    public static string CompleteStringSize(byte size,string word ,char caracter=' ')
    {
        int actualSize = word.Length;
        int stringToAdd = (-actualSize) + size;
        string newWord=String.Empty;

        if (stringToAdd > 0)
        {
            int pad = stringToAdd / 2;
            if (stringToAdd % 2 == 0)
            {
                
                newWord = word.PadLeft(pad,caracter).PadRight(pad,caracter);
            }
            else
            {
                newWord=word.PadLeft(pad,caracter).PadRight(pad+1,caracter);
            }
        }

        return newWord;
    }

    public static double StringToDouble(string value)
    {
        try
        {
            if (String.IsNullOrEmpty(value)) return 0;
            return Convert.ToDouble(value);
            
        }
        catch
        {
            return 0;
        }    
    }

    public static int StringToInt32(string value)
    {
        try
        {
            if (String.IsNullOrEmpty(value)) return 0;
            return Convert.ToInt32(value);
            
        }
        catch
        {
            return 0;
        }    
    }
}