using System.Collections;

namespace C_Part2.Exercises;

public class StackDesign
{
    private ArrayList _mList = new ArrayList();
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
        if (_mList.Count != 0)
        {
            object? obj = _mList[_mList.Count - 1];
            _mList.RemoveAt(_mList.Count - 1);
            return obj;
        }
        throw new InvalidOperationException("The stack is empty.");
    }

    public void Clear()
    {
        if (_mList.Count != 0)
        {
            _mList.Clear();
        }
    }
}