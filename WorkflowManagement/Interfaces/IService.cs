using WorkflowManagement.Entities;

namespace WorkflowManagement.Interfaces;

public interface IService<T>
{
    public T Create(T data);
    public T? Find(string name);
}