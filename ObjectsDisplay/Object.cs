public class Object<T>
{
    private string Value;

    public Object()
    {
        Value = new string(" ");
    }
    public Object(string CustomObject)
    {
        if (CustomObject != null)
            Value = new string(CustomObject.ToString());
    }
    public Object(T CustomObject)
    {
        if (CustomObject != null)
            Value = new string(CustomObject.ToString());
    }
    public string GetValue()
    {
        return Value;
    }
    public void SetValue()
    {
        Value = new string(" ");
    }
    public void SetValue(string CustomObject)
    {
        if (CustomObject != null)
            Value = new string(CustomObject.ToString());
    }
    public void SetValue(T CustomObject)
    {
        if (CustomObject != null)
            Value = new string(CustomObject.ToString());
    }
    public void SetValue(Object<string> @object)
    {
        this.Value = new string(" ");
    }
    public override string ToString()
    {
        return Value;
    }
}