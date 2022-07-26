using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Interfaces
{
  public interface IController<T>
  {
    [HttpGet]
    public ActionResult<List<T>> Get();

    [HttpGet("{id}")]
    public ActionResult<T> Get(int id);

    [HttpPost]
    public Task<ActionResult<T>> Create([FromBody] T tData);

    [HttpPut("{id}")]
    public Task<ActionResult<T>> Edit(int id, [FromBody] T tData);

    [HttpDelete("{id}")]
    public Task<ActionResult<T>> Delete(int id);

  }
}