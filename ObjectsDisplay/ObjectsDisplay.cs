public class ObjectsDisplay<T>
{
    private int Width;
    private int Height;
    private Object<T>[,] Display;

    public ObjectsDisplay(int Width, int Height)
    {
        this.Width = Width;
        this.Height = Height;
        Display = new Object<T>[Width, Height];
        //FillDisplay(" "); // Initialize display with default value
    }

    public ObjectsDisplay(int Width, int Height, T CustomObject)
    {
        this.Width = Width;
        this.Height = Height;
        Display = new Object<T>[Width, Height];
        FillDisplay(CustomObject); // Initialize display with custom object
    }
    public void FillDisplay(T CustomObject)
    {
        if (Display != null && CustomObject != null)
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    if (Display[i, j] != null)
                        Display[i, j].SetValue(CustomObject);
                    else
                        Display[i, j] = new Object<T>(CustomObject);
    }
    public void FillDisplay(string CustomObject)
    {
        if (Display != null && CustomObject != null)
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    if (Display[i, j] != null)
                        Display[i, j].SetValue(CustomObject);
                    else
                        Display[i, j] = new Object<T>(CustomObject);
    }
    public void ClearDisplay()
    {
        if (Display != null)
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    if (Display[i, j] != null)
                        Display[i, j].SetValue();
                    else
                        Display[i, j] = new Object<T>();
    }
    public void PrintRender()
    {
        if (this != null)
            Console.WriteLine(this.ToString());
    }
    public override string ToString()
    {
        if (Display == null)
        {
            Console.WriteLine("\n\tDisplay has not been created before action\n");
            return "null";
        }
        string str = "";
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
                if (Display[i, j] != null)
                    str += Display[j, i].ToString() + "\t";
                else str += "null\t";
            str += "\n";
        }
        return str;
    }
    public void SetObject(int x, int y, T CustomObject)
    {
        x--;
        y = Height - y;
        if (x > Width || x < 0 || y < 0 || y > Height)
        {
            Console.WriteLine("\n\tOut of bounds of array\n");
            return;
        }
        if (Display == null)
        {
            Console.WriteLine("\n\tDisplay has not been created before action\n");
            return;
        }
        if (CustomObject != null)
        {
            if (Display[x, y] != null)
                Display[x, y].SetValue(CustomObject);
            else
                Display[x, y] = new Object<T>(CustomObject);
        }
        else
        {
            if (Display[x, y] != null)
                Display[x, y].SetValue("null");
            else
                Display[x, y] = new Object<T>("null");
        }
    }
    public void SetObject(int x, int y, string CustomObject)
    {
        x--;
        y = Height - y;
        if (x > Width || x < 0 || y < 0 || y > Height)
        {
            Console.WriteLine("\n\tOut of bounds of array\n");
            return;
        }
        if (Display == null)
        {
            Console.WriteLine("\n\tDisplay has not been created before action\n");
            return;
        }
        if (CustomObject != null)
        {
            if (Display[x, y] != null)
                Display[x, y].SetValue(CustomObject);
            else
                Display[x, y] = new Object<T>(CustomObject);
        }
        else
        {
            if (Display[x, y] != null)
                Display[x, y].SetValue("null");
            else
                Display[x, y] = new Object<T>("null");
        }
    }
    public void SetObject(int x, int y)
    {
        x--;
        y = Height - y;
        if (x > Width || x < 0 || y < 0 || y > Height)
        {
            Console.WriteLine("\n\tOut of bounds of array\n");
            return;
        }
        if (Display == null)
        {
            Console.WriteLine("\n\tDisplay has not been created before action\n");
            return;
        }
        if (Display[x, y] != null)
            Display[x, y].SetValue();
        else
            Display[x, y] = new Object<T>();
    }
    public int GetWidth()
    {
        return Width;
    }
    public int GetHeight()
    {
        return Height;
    }
}