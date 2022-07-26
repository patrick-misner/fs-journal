using System;
using System.Collections.Generic;
using contracted.Models;
using contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class ContractorsController : ControllerBase
  {
    private readonly ContractorsService _conServ;

    public ContractorsController(ContractorsService cServ)
    {
      _conServ = cServ;
    }

    [HttpPost]
    public ActionResult<Contractor> Create([FromBody] Contractor contractorData)
    {
      try
      {
        Contractor newContractor = _conServ.Create(contractorData);
        return Ok(newContractor);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet]

    public ActionResult<List<Contractor>> Get()
    {
      try
      {
        List<Contractor> contractors = _conServ.Get();
        return Ok(contractors);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Contractor> Get(int id)
    {
      try
      {
        Contractor contractor = _conServ.Get(id);
        return Ok(contractor);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Contractor> Edit(int id, [FromBody] Contractor contractorData)
    {
      try
      {
        contractorData.Id = id;
        Contractor update = _conServ.Edit(contractorData);
        return Ok(update);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<Contractor> Delete(int id)
    {
      try
      {
        Contractor deletedContractor = _conServ.Delete(id);
        return Ok("Deleted Contractor");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}