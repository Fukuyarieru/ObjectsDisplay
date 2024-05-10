using System;

public class ObjectsDisplay<T>
{
    private int Height = 0, Width = 0;
    private Object<T>[,] Display;

    public ObjectsDisplay(int Width, int Height)
    {
        Display = new Object<T>[Width, Height];
        this.Height = Height;
        this.Width = Width;
    }
     public ObjectsDisplay(int Width, int Height, T CustomObject)
    {
        this.Height = Height;
        this.Width = Width;
        Display = new Object<T>[Width, Height];
        this.FillDisplay(CustomObject);
    }
    public void FillDisplay(T CustomObject)
    {
        for (int i = 0; i < Width; i++)
            for (int j = 0; j < Height; j++)
                Display[i, j].SetValue(CustomObject);
    }
    public void PrintRender()
    {
        if(this!=null)
            Console.WriteLine(this.ToString());
    }
    public override string ToString()
    {
        string str = "";
        for (int i = 0; i < Width; i++)
            for (int j = 0; j < Height; j++)
                str += Display[i, j].ToString() + "\t";
        return str;
    }
    public void SetObject(int x, int y, T CustomObject)
    {
        Display[x, y].SetValue(CustomObject);
    }
    public void SetObject(int x, int y, string CustomObject)
    {
        Display[x, y].SetValue(CustomObject);
    }
    public void SetObject(int x, int y)
    {
        Display[x, y] = new Object<T>();
    }
}