using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cool.Models;

namespace Cool.ViewModels
{
    public class CompanyViewModel
    {
        public List<Company> Company { get; set; }
        public List<Phone> Phone { get; set; }

    }
}