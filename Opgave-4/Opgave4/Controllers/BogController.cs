using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLib.Model;

namespace Opgave4.Controllers
{ 
    [Route("api/Bog")]
    [ApiController]
    public class Book1Controller : ControllerBase
    {
        private static readonly List<Bog> bogs = new List<Bog>()
        {
            new Bog("Franco", "Amer1", 111, "4545454545455"),
            new Bog("Franco2", "Amer2", 222, "6767676767677"),
            new Bog("Franco3", "Amer3", 333, "9090909090909"),
            new Bog("Franco4", "Amer4", 444, "2543567878645"),
            new Bog("Franco5", "Amer5", 555, "8596958475643")
        };

        // GET
        [HttpGet]
        public IEnumerable<Bog> Get()
        {
            return bogs ;

        }

        //GET
        [HttpGet]
        [Route("{isbn13}")]
        public Bog Get(string isbn13)
        {
            return bogs.Find(i => i.Isbn13 == isbn13);
        }

        // POST
        [HttpPost]
        public void Post([FromBody] Bog value)
        {
            bogs.Add(value);
        }

        // PUT
        [HttpPut]
        [Route("{isbn13}")]
        public void Put(string isbn13, [FromBody] Bog value)
        {
            Bog book = Get(isbn13);
            if (book != null)
            {
                book.Titel = value.Titel;
                book.Forfatter = value.Forfatter;
                book.Sidetal = value.Sidetal;
                book.Isbn13 = value.Isbn13;
            }
        }

        // DELETE
        [HttpDelete]
        [Route("{isbn13}")]
        public void Delete(string isbn13)
        {
            Bog bog = Get(isbn13);
            bogs.Remove(bog);
        }
    }
}
