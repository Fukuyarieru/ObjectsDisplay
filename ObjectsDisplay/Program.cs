﻿public class Program
{
    static void Main(string[] args)
    {

        //int Width = 4;
        //int Height = 4;

        //ObjectsDisplay<string> Display = new ObjectsDisplay<string>(Width, Height);

        string decision = Runner.StartOptions();
        while (decision != "3")
        {
            if (decision == "2")
            {
                string decision = Runner.DisplayModification();
                if (decision == "1")
                {

                }
                if (decision == "2")
                {

                }
                if (decision == "3")
                {

                }
                if (decision == "4")
                {

                }
                if (decision == "5")
                {

                }
            }
        }
        //Display.PrintRender();

        //Display.FillDisplay(".");
        //Display.SetObject(1, 1, "1");
        //Display.PrintRender();

        //Display.SetObject(2, 2, "X");
        //Display.PrintRender();
        //Display.FillDisplay("y's");

        //Console.WriteLine(Display.GetObject(1, 1));
        //Console.WriteLine(Display.GetCustomObject(1, 1));

        //Display.PrintRender();
        //Display.SetObject(1, 1, "O");
        //Display.SetObject(3, 1, "O");
        //Display.SetObject(2, 2, "O");
        //Display.SetObject(2, 3, "O");
        //Display.SetObject(2, 4, "H");
        //Display.SetObject(1, 4, "H");
        //Display.SetObject(3, 4, "H");
        //Display.PrintRender();

        //Display.SetObject(3, 3, null);
        //Display.PrintRender();


        //Display = new ObjectsDisplay<string>(100, "ssa");
        //Display.PrintRender();
        //Display = new ObjectsDisplay<string>(5823, "IloDi");
        //Display.PrintRender();

        //Display = Runner.CreateDisplayCords();
        //Display.PrintRender();
        //Runner.DisplayModification();
        //Runner.DisplayConfiguration();
    }
}
