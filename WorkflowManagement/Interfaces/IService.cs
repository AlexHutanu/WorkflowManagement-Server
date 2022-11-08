namespace WorkflowManagement.Interfaces;

public interface IService<T>
{
    public T Create(T data);
    public IEnumerable<T> Find(string name);
}