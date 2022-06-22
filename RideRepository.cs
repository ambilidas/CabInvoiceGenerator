using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        //Dictionary to store userid and rides in list
        Dictionary<string, List<Ride>> userRides = null;

        //Constructor to create dictionary
        public RideRepository()
        {
            this.userRides = new Dictionary<string, List<Ride>>();
        }
        //Method to add ride list to specified user id
    }
}
