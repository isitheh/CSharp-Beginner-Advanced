using System.Collections;

namespace C_Part2.Exercises;

public class StackDesign
{
    private readonly ArrayList _mList = new ArrayList();
    public StackDesign()
    {
    }

    public void Push(object obj)
    {
        if (obj == null)
        {
            throw new InvalidOperationException("The received object was null.");
        }
        _mList.Add(obj);
    }

    public object? Pop()
    {
        if (_mList.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        var listCount = _mList.Count - 1;
        object? obj = _mList[listCount];
        _mList.RemoveAt(listCount);
        return obj;
    }

    public void Clear()
    {
        if (_mList.Count != 0)
        {
            _mList.Clear();
        }
    }
}