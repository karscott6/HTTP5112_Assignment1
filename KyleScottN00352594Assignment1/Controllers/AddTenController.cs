using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KyleScottN00352594Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Receives an input and responds with id + 10.
        /// </summary>
        /// <example>
        /// GET api/AddTen/21 -> 31
        /// </example>
        /// <returns>
        /// id + 10
        /// </returns>

        public int Get(int id)
        {
            return id + 10;
        }



    }
}
