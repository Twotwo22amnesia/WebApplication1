using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DET_ACTOR_MOVIE
    {
        [Key]
        public int INT_IDD_DETAL { get; set; }
        public int INT_IDD_MOVIE { get; set; }
        public int INT_IDD_ACTOR { get; set; }
    }
}
