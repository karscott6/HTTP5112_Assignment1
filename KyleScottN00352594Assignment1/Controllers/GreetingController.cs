using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KyleScottN00352594Assignment1.Controllers
{
    public class GreetingController : ApiController
    {

        /// <summary>
        /// Recieve POST api/Greeting request and returns string.
        /// Recieves an input and returns string with id. 
        /// </summary>
        /// <example>
        /// POST api/Greeting -> "Hello World!"
        /// GET api/Greeting/10 -> "Greetings to 10 people!"
        /// </example>
        /// <returns>
        /// string "Hello World!"
        /// string "Greetings to {id} people!"
        /// </returns>


        public IEnumerable<string> Post()
        {
            return new string[] { "Hello World!" };
        }

        public IEnumerable<string> Get(int id)
        {
            return new string[] { "Greetings to " + id + " people!" };
        }



    }
}
