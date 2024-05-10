public class Program
{
    static void Main(string[] args)
    {
        int Width = 3;
        int Height = 3;

        ObjectsDisplay<Object> Display = new ObjectsDisplay<Object>(Width, Height);

        Display.SetObject(2, 2, "X");
        Display.PrintRender();
    }
}
