using System.Collections.Generic;
using System.Data;
using System.Linq;
using contracted.Models;
using Dapper;

namespace contracted.Repositories
{
  public class CompanysRepository
  {
    private readonly IDbConnection _db;

    public CompanysRepository(IDbConnection db)
    {
      _db = db;
    }

    internal Company Create(Company companyData)
    {
      string sql = @"
      INSERT INTO companys
      (name)
      VALUES
      (@Name);
      SELECT LAST_INSERT_ID();
      ";
      int id = _db.ExecuteScalar<int>(sql, companyData);
      companyData.Id = id;
      return companyData;
    }

    internal Company Get(int id)
    {
      string sql = @"
      SELECT *
      FROM companys
      WHERE id = @id
      ";
      return _db.Query<Company>(sql, new { id }).FirstOrDefault();
    }

    internal void Edit(Company original)
    {
      string sql = @"
      UPDATE companys
      SET
      name = @Name
      WHERE id = @Id
      ";
      _db.Execute(sql, original);
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM companys WHERE id = @id LIMIT 1";
      _db.Execute(sql, new { id });
    }

    internal List<Company> Get()
    {
      string sql = @"
      SELECT *
      FROM companys
      ";
      return _db.Query<Company>(sql).ToList();
    }
  }
}