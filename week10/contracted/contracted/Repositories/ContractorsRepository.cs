using System.Collections.Generic;
using System.Data;
using System.Linq;
using contracted.Models;
using Dapper;

namespace contracted.Repositories
{


  public class ContractorsRepository
  {
    private readonly IDbConnection _db;

    public ContractorsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal Contractor Create(Contractor contractorData)
    {
      string sql = @"
      INSERT INTO contractors
      (name)
      VALUES
      (@Name);
      SELECT LAST_INSERT_ID();
      ";
      int id = _db.ExecuteScalar<int>(sql, contractorData);
      contractorData.Id = id;
      return contractorData;
    }

    internal Contractor Get(int id)
    {
      string sql = @"
      SELECT *
      FROM contractors
      WHERE id = @id
      ";
      return _db.Query<Contractor>(sql, new { id }).FirstOrDefault();
    }

    internal void Edit(Contractor original)
    {
      string sql = @"
      UPDATE contractors
      SET
      name = @Name
      WHERE id = @Id
      ";
      _db.Execute(sql, original);
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM contractors WHERE id = @id LIMIT 1";
      _db.Execute(sql, new { id });
    }

    internal List<Contractor> Get()
    {
      string sql = @"
      SELECT *
      FROM contractors
      ";
      return _db.Query<Contractor>(sql).ToList();
    }
  }
}