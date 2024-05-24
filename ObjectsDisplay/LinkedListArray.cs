public class LinkedListArray<T>
{
	private LinkedListArray<T> next;
	private int index;
	private T value;
	private static int total = 0;

	public LinkedListArray(T value)
	{
		this.value = value;
		index = total;
		total++;

	}
	public LinkedListArray(T value, LinkedListArray<T> next)
	{
		this.value = value;
		this.next = next;
		index = total;
		total++;
	}
	public void InsertAtIndex(T value, int index)
	{

	}
	public LinkedListArray<T> RemoveAtIndex(int index)
	{
		return this; // temporery
	}
	public void Push(T value)
	{
		LinkedListArray<T> temp = this;
		while (temp.GetNext() != null)
			temp = temp.GetNext();
		temp.SetNext(new LinkedListArray<T>(value);
	}
	public void Push(LinkedListArray<T> node)
	{
		LinkedListArray<T>temp=this;
		while (temp.GetNext() != null)
			temp = temp.GetNext();
		temp.SetNext(node);
	}
	public void SetValue(T value)
	{
		this.value = value;
	}
	public T GetValue()
	{
		return this.value;
	}
	public LinkedListArray<T> GetNext()
	{
		return next;
	}
	public int GetIndex()
	{
		return this.index;
	}
	public int GetIndexOf(LinkedListArray<T> node)
	{
		LinkedListArray<T> temp = this;
		while (temp != null && temp != node)
			temp = temp.next;
		return temp.GetIndex();
	}
	public void SetNext(LinkedListArray<T> node)
	{
		this.next = node;
	}
}