using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cool.Models;

namespace Cool.ViewModels
{
    public class RandomCarViewModel
    {
        public Car Car { get; set; }
        public List<Rent> Rent { get; set; }
    }
}