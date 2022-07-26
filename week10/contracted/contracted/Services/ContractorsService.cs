using System;
using System.Collections.Generic;
using contracted.Models;
using contracted.Repositories;

namespace contracted.Services
{
  public class ContractorsService
  {
    private readonly ContractorsRepository _repo;

    public ContractorsService(ContractorsRepository repo)
    {
      _repo = repo;
    }

    internal Contractor Create(Contractor ContractorData)
    {

      return _repo.Create(ContractorData);
    }

    internal List<Contractor> Get()
    {
      return _repo.Get();
    }

    internal Contractor Get(int id)
    {
      return _repo.Get(id);
    }

    internal Contractor Edit(Contractor contractorData)
    {
      Contractor original = Get(contractorData.Id);
      original.Name = contractorData.Name ?? original.Name;
      _repo.Edit(original);
      return original;
    }

    internal Contractor Delete(int id)
    {
      Contractor original = Get(id);
      if (original == null)
      {
        throw new Exception("Invalid Id");
      }
      _repo.Delete(id);
      return original;
    }
  }
}