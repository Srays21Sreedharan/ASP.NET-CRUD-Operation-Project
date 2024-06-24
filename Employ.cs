using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace project1.Models
{
    public class Employ
    {
        
            [Key]
            public int Id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
        
    }
}
