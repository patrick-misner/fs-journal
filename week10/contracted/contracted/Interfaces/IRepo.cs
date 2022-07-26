using System.Collections.Generic;

namespace contracted.Interfaces
{
  public interface IRepo<T>
  {
    public List<T> GetAll();
    public T GetByID(int id);
    public T Create(T data);
    public void Edit(T data);
    public void Delete(int Id);
  }
}