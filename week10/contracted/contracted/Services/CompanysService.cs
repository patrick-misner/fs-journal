using System;
using System.Collections.Generic;
using contracted.Models;
using contracted.Repositories;

namespace contracted.Services
{
  public class CompanysService
  {
    private readonly CompanysRepository _repo;

    public CompanysService(CompanysRepository repo)
    {
      _repo = repo;
    }

    internal Company Create(Company companyData)
    {

      return _repo.Create(companyData);
    }

    internal List<Company> Get()
    {
      return _repo.Get();
    }

    internal Company Get(int id)
    {
      return _repo.Get(id);
    }

    internal Company Edit(Company companyData)
    {
      Company original = Get(companyData.Id);
      original.Name = companyData.Name ?? original.Name;
      _repo.Edit(original);
      return original;
    }

    internal Company Delete(int id)
    {
      Company original = Get(id);
      if (original == null)
      {
        throw new Exception("Invalid Id");
      }
      _repo.Delete(id);
      return original;
    }
  }
}
