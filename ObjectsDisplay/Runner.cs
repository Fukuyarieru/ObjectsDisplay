public static class Runner
{
    public static int StartOptions()
    {
        int input = 0;
        // I should really consider having the input be a string for much more robust
        string str = "";
        str += "What would you like to do?\n";
        str += "1. Create new Display\n";
        str += "2. Modify current Display\n";
        str += "3. Finish\n";
        str += "Your answer:\t";

        input = int.Parse(Console.ReadLine());

        while (input > 0 && input < 4)
        {
            Console.Write("\nIncorrect input.\nYour answer:");
            input = int.Parse(Console.ReadLine());
        }

        return input;
    }
    public static int DisplayModification()
    {
        int input = 0;

        string str = "";
        str += "What would you like to do\n?";
        str += "1. Add object\n";
        str += "2. Clear coordinate\n";
        str += "3. Fill Display with a set Object\n";
        str += "4. Clear Display to be completly empty\n";
        str += "5. Clear Display to be Nulls\n";
        str += "Your answer:\t";

        input = int.Parse(Console.ReadLine());

        while (input > 0 && input < 6)
        {
            Console.Write("\nIncorrect input.\nYour answer:");
            input = int.Parse(Console.ReadLine());
        }

        return input;
    }
    public static int DisplayConfiguration()
    {
        int input = 0;

        string str = "";
        str += "How would you like to create the Display?\n";
        str += "1. Create using width and height";
        str += "2. Craete using a set object amount";
        str += "Your answer:\t";

        input = int.Parse(Console.ReadLine());

        while (input > 0 && input < 3)
        {
            Console.Write("\nIncorrect input.\nYour answer:");
            input = int.Parse(Console.ReadLine());
        }

        return input;
    }
    public static ObjectsDisplay<string> CreateDisplayCords()
    {
        int iWidth; // i- for input
        int iHeight;

        Console.Write("Enter width:\t");
        iWidth = int.Parse(Console.ReadLine());
        while (iWidth <= 0)
        {
            Console.Write("\nIncorrect input, value must be greater than 0.\nEnter width:\t");
            iWidth = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        Console.Write("Enter height:\t");
        iHeight = int.Parse(Console.ReadLine());
        while (iHeight <= 0)
        {
            Console.Write("\nIncorrect input, value must be greater than 0.\nEnter height:\t");
            iHeight = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Width=" + iWidth + " ,Height=" + iHeight);
        Console.WriteLine();

        Console.WriteLine("Would you like to set a custom object to fill the Display?");
        Console.Write("Enter Yes/No:\t");
        string str = "";
        str = Console.ReadLine();
        while (str.ToLower() != "yes" && str.ToLower() != "no")
        {
            Console.Write("Incorrect input, value must be Yes/No.\nEnter Yes/No:\t");
            str = Console.ReadLine();
        }
        if (str.ToLower() == "yes")
        {
            Console.WriteLine("What would you like the objects to be?");
            Console.Write("Your answer:\t");
            str = Console.ReadLine();

            Console.WriteLine("Are you sure you want " + str + " to be the objects?");
            Console.Write("Enter Yes/No:\t");
            string str2 = "";
            str2 = Console.ReadLine();
            while (str2.ToLower() != "yes" && str2.ToLower() != "no")
            {
                Console.WriteLine("Incorrect input, value must be Yes/No.\nEnter Yes/No:\t");
                str2 = Console.ReadLine();
            }
            if (str2.ToLower() == "yes")
                return new ObjectsDisplay<string>(iWidth, iHeight, str);
            while (str2.ToLower() == "no")
            {
                Console.WriteLine("What would you like the objects to be?");
                Console.Write("Your answer:\t");
                str = Console.ReadLine();

                Console.WriteLine("Are you sure you want " + str + " to be the objects?");
                Console.Write("Enter Yes/No:\t");
                str2 = "";
                str2 = Console.ReadLine();
                while (str2.ToLower() != "yes" && str2.ToLower() != "no")
                {
                    Console.WriteLine("Incorrect input, value must be Yes/No.\nEnter Yes/No:\t");
                    str2 = Console.ReadLine();
                }
                if (str2.ToLower() == "yes")
                    return new ObjectsDisplay<string>(iWidth, iHeight, str);
            }
            return new ObjectsDisplay<string>(iWidth, iHeight, str);
        }
        return new ObjectsDisplay<string>(iWidth, iHeight);
    }






    //public static void Runner()
    //{
    //    bool Continue = false;
    //    string state = "start";


    //    Console.WriteLine("What would you like to do?:");
    //    Console.WriteLine(OptionsMenu(state));

    //    return Continue;
    //}
    //public static string OptionsMenu(string state)
    //{
    //    string str = "";
    //    if (state == "start")
    //    {
    //        str += "1. Create new Display\n";
    //        str += "2. Modify current Display\n";
    //        str += "3. Finish\n";
    //    }
    //    else if (state == "ModifyDisplay")
    //    {
    //        str += "1. Add object\n";
    //        str += "2. Clear coordinate\n";
    //        str += "3. Fill Display with a set Object\n";
    //        str += "4. Clear Display to be completly empty\n";
    //        str += "5. Clear Display to be Nulls\n";
    //    }
    //    //else if(state=="DisplayConfiguration")
    //    //{
    //    //    str
    //    //}    
    //    return str;
    //}
}