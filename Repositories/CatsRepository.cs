using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using testbuild2.Models;


namespace testbuild2.Repositories
{
    public class CatsRepository
    {
        private IDbConnection _db;

        public CatsRepository(IDbConnection db)
        {
            _db = db;
        }

        //SQL


        //GET ALL Cats
        public IEnumerable<Cat> GetAll()
        {
            return _db.Query<Cat>("SELECT * FROM cats;");
        }

        //GET CAT BY ID
        public Cat GetById(int id)
        {
            return _db.Query<Cat>("SELECT * FROM cats WHERE id = @id;", new { id }).FirstOrDefault();
        }



        // CREATE CAT

        public Cat Create(Cat Cat)
        {
            {
                int id = _db.ExecuteScalar<int>(@"
        INSERT INTO cats (name, description)
        VALUES (@Name, @Description);
        SELECT LAST_INSERT_ID();", cat
                );
                cat.Id = id;
                return cat;
            }

        }



    }
}