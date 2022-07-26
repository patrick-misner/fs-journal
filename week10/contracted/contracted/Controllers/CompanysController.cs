using System;
using System.Collections.Generic;
using contracted.Models;
using contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class CompanysController : ControllerBase
  {
    private readonly CompanysService _cServ;

    public CompanysController(CompanysService cServ)
    {
      _cServ = cServ;
    }

    [HttpPost]
    public ActionResult<Company> Create([FromBody] Company companyData)
    {
      try
      {
        Company newCompany = _cServ.Create(companyData);
        return Ok(newCompany);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet]

    public ActionResult<List<Company>> Get()
    {
      try
      {
        List<Company> companys = _cServ.Get();
        return Ok(companys);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Company> Get(int id)
    {
      try
      {
        Company company = _cServ.Get(id);
        return Ok(company);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Company> Edit(int id, [FromBody] Company companyData)
    {
      try
      {
        companyData.Id = id;
        Company update = _cServ.Edit(companyData);
        return Ok(update);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<Company> Delete(int id)
    {
      try
      {
        Company deletedCompany = _cServ.Delete(id);
        return Ok("Deleted Company");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}