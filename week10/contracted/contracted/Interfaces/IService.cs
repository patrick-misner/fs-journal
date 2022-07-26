using System.Collections.Generic;

namespace contracted.Interfaces
{
  public interface IService<T>
  {
    internal List<T> Get();
    internal T Get(int id);
    internal T Create(T tData);
    internal T Edit(T tData);
    internal T Delete(int id);

  }
}