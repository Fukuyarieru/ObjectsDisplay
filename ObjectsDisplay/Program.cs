public class Program
{
    static void Main(string[] args)
    {

        while (Runner())
        { }

        int Width = 4;
        int Height = 4;

        ObjectsDisplay<string> Display = new ObjectsDisplay<string>(Width, Height);

        Display.PrintRender();

        Display.FillDisplay(".");
        Display.SetObject(1, 1, "1");
        Display.PrintRender();

        Display.SetObject(2, 2, "X");
        Display.PrintRender();
        Display.FillDisplay("Balls");
        Display.PrintRender();
        Display.SetObject(1, 1, "O");
        Display.SetObject(3, 1, "O");
        Display.SetObject(2, 2, "O");
        Display.SetObject(2, 3, "O");
        Display.SetObject(2, 4, "H");
        Display.PrintRender();

        Display.SetObject(3, 3, null);
        Display.PrintRender();
    }
    public static bool Runner()
    {
        bool Continue = false;
        string state = "start";


        Console.WriteLine("What would you like to do?:");
        Console.WriteLine(OptionsMenu(state));

        return Continue;
    }
    public static string OptionsMenu(string state)
    {
        string str = "";
        if (state == "start")
        {
            str += "1. Create new Display\n";
            str += "2. Modify current Display\n";
            str += "3. Finish\n";
        }
        else if (state == "ModifyDisplay")
        {
            str += "1. Add object\n";
            str += "2. Clear coordinate\n";
            str += "3. Fill Display with a set Object\n";
            str += "4. Clear Display to be completly empty\n";
            str += "5. Clear Display to be Nulls\n";
        }
        //else if(state=="DisplayConfiguration")
        //{
        //    str
        //}    
        return str;
    }
}
