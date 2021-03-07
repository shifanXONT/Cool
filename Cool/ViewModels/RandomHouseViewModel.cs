using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cool.Models;

namespace Cool.ViewModels
{
    public class RandomHouseViewModel
    {
        public House House { get; set; }
        public List<Buyer> Buyers { get; set; }
    }
}