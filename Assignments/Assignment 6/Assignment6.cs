namespace Assignments.Assignment_6;

public class GenericCollection<T>
{
    private T[] _array;
    private int _nextIndex = 0;

    public void AddElement(T element)
    {
        _array[_nextIndex] = element;
        _nextIndex++;
    }

    public T GetElement(int index)
    {
        return _array[index];
    }

    public void SetItem(int index, T element)
    {
        _array[index] = element;
    }

    public void Swap(int index1, int index2)
    {
        (_array[index1], _array[index2]) = (_array[index2], _array[index1]);
    }

}