public class Object<T>
{
    private string Value;

    public Object()
    {
        Value = " ";
    }
    public Object(string CustomObject)
    {
        Value = CustomObject;
    }
     public Object(T CustomObject)
    {
        Value = GenericHandler(CustomObject);
    }
    public string GetValue()
    {
        return Value;
    }
    public void SetValue(string Value)
    {
        this.Value = Value;
    }
    public void SetValue(T CustomObject)
    {
        this.Value = GenericHandler(CustomObject);
    }
    public void SetValue()
    {
        this.Value = " ";
    }
    public override string ToString()
    {
        return Value;
    }
    private string GenericHandler(T CustomObject)
    {
        // temporary fix:
        return "A0";
        //if (CustomObject == null)
        //    return " ";
        //return CustomObject.ToString();
    }
}