using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _12._27._2021.Models
{
    public class Service
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("category")]
        public int category_id { get; set; }

        public category category { get; set; }

        [ForeignKey("Client")]
        public int client_id { get; set; }
        public Client Client { get; set; }

        [ForeignKey("ServiceContent")]
        public int content_id { get; set; }
        public ServiceContent ServiceContent { get; set; }
    }
}
