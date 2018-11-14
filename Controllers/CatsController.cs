using System;
using System.Collections.Generic;
using testbuild2.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using testbuild2.Models;

namespace testbuild2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : Controller
    {
        CatsRepository _repo;
        public CatsController(CatsRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Cat> Get()
        {
            return _repo.GetAll();
        }


        [HttpPost]
        public Cat Post([FromBody] Cat cat)
        {


            cat = new Cat(cat.Name, cat.Description);
            return _repo.Create(cat);

            throw new Exception("INVALID CAT");
        }

    }

}