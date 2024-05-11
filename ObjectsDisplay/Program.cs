public class Program
{
    static void Main(string[] args)
    {

        int Width = 4;
        int Height = 4;

        ObjectsDisplay<string> Display = new ObjectsDisplay<string>(Width, Height);

        Display.PrintRender();

        Display.FillDisplay(".");
        Display.SetObject(1, 1, "1");
        Display.PrintRender();

        Display.SetObject(2, 2, "X");
        Display.PrintRender();
        Display.FillDisplay("y's");
        Display.PrintRender();
        Display.SetObject(1, 1, "O");
        Display.SetObject(3, 1, "O");
        Display.SetObject(2, 2, "O");
        Display.SetObject(2, 3, "O");
        Display.SetObject(2, 4, "H");
        Display.SetObject(1, 4, "H");
        Display.SetObject(3, 4, "H");
        Display.PrintRender();

        Display.SetObject(3, 3, null);
        Display.PrintRender();


        Display = new ObjectsDisplay<string>(100, "ssa");
        Display.PrintRender();
        Display = new ObjectsDisplay<string>(5823, "IloDi");
        Display.PrintRender();

        Display = Runner.CreateDisplayCords();
        Display.PrintRender();
        Runner.DisplayModification();
        Runner.DisplayConfiguration();
    }
}
