using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cool.Models;

namespace Cool.ViewModels
{
    public class CinemaViewModel
    {
        public List<Cinema> Cinema { get; set; }
        public List<Ticket> Ticket { get; set; }
    }
}