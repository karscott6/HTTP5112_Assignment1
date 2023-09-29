using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InitiativeAssignment1KyleScottN00352594.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/HostingCost/0
        public IEnumerable<string> Get(int id)
        {
            double costPerNight = 5.50;
            int fortNights = 1 + id / 14;
            double fortHst = fortNights * costPerNight * 0.13;

            //round decimals to two places

            double totalFortCost = Math.Round(fortNights * costPerNight, 2);
            double roundedFortHst = Math.Round(fortHst, 2);
            double totalCost = Math.Round(totalFortCost +  roundedFortHst, 2);

            return new string[] { fortNights + " FortNights at $5.50/FN = $" + totalFortCost + " CAD",
                                  "HST 13% = $" + roundedFortHst + " CAD",
                                  "Total = $" + totalCost + " CAD"
            };

        }
    }
}
