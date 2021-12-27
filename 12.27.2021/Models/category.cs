using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _12._27._2021.Models
{
    public class category
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public List<Service> Services { get; set; }

    }
}
