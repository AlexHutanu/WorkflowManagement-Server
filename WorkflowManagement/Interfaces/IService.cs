using WorkflowManagement.Entities;

namespace WorkflowManagement.Interfaces;

public interface IService<T>
{
    public T Create(T data);
    public T Find(string name);
}

public interface ITicketsService<T>
{
    public T Create(T data);
}

public interface IActivitiesService<T>
{
    public Activity Create(T data);
}