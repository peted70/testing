using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "peted1", "peted" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "making conflict 1 and merging with 2";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            // Non-conflicting change
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
