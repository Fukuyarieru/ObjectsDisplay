using System.Security.Cryptography.X509Certificates;

public class Menus
{
    public bool YesNo(string question)
    {
        Console.Write(YesNoQuestion(question));
        string input = Console.ReadLine();
        while (input.ToLower() != "yes" && input.ToLower() != "no")
        {
        }
        return true;
    }
    public string YesNoQuestion(string question)
    {
        return question + "\nAnswer (yes/no): ";
    }
    public string ErrorMessage(string ExpectedInput)
    {
        return "\nWRONG INPUT!\nEXPECTED: (" + ExpectedInput + ")\n";
    }



    public static bool ValidOptions(string[] arr, string input)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == input)
                return true;
        return false; ;
    }
    public static bool ValidOptions(int LowLim, int HighLim, int input)
    {
        if (input >= LowLim && input < HighLim)
            return true;
        return false;
    }
    public static bool ValidOptions(int LowLim, int input)
    {
        return input >= LowLim;
    }
}