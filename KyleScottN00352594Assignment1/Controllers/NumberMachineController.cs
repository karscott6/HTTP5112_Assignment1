using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KyleScottN00352594Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// <summary>
        /// Recieves an input and returns a number after a math equation is completed.
        /// </summary>
        /// <example>
        /// GET api/NumberMachine/10 -> 10 * 3 - 5 + 10 / 2 = 30
        /// </example>
        /// <returns>
        /// GET id * 3 - 5 + 10 / 2 = return
        /// </returns>

        public IEnumerable<int> Get(int id)
        {
            return new int[] { id * 3 - 5 + 10 / 2 };
        }

    }
}
