using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _12._27._2021.Models
{
    public class Client
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public int age {get; set;}

        public DateTime time { set; get; }

        public string mail { get; set; }

        public string password { set; get; }

        public float budget { set; get; }

        public List<Service> Services { get; set; }
    }
}
