using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class VM_RandomMovie
    {
        public Movie Movie { get; set; }
        public List<Customer>  Customer { get; set; }
    }
}