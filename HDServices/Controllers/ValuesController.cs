using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace HDServices.Controllers
{
    /*
     * https://msdn.microsoft.com/en-us/magazine/dn532203.aspx
     */

    //[EnableCors(origins: "http://localhost:1098/", headers: "*", methods: "*")]
    [EnableCors("*", "*", "*")]
    public class ValuesController : ApiController
    {
        [Route("api/values/GetUsers")]
        public HttpResponseMessage GetUsers()
        {
            var i = 0;
            List<User> users = new List<User>();
            while(i< 10)
            {
                User u = new User(i);
                users.Add(u);

                i++;
            }

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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

    public class User
    {
        public User(int i)
        {
            FirstName = "First name -" + i;
            LastName = "Last name -" + i;
            Age = i + 1;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
