namespace WorkflowManagement.Interfaces;

public interface IRepository<T>
{
    public T Create(T data);
    public T FindOneByName(string name);
    public IEnumerable<T> Find();
}