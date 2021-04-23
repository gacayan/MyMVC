using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC.Models
{
    public class UserModel
    {
        public string Id { get; set; }
        [Required,StringLength(200)]
        public string name { get; set; }
        [Required,Range(18,99)]
        public int age { get; set; }
    }
}
