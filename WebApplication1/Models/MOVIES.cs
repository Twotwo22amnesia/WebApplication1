using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MOVIES
    {
        [Key]
        public int INT_IDD_MOVIE { get; set; }
        public string STR_NAMEE_MOVIE { get; set; }
        public string STR_MOVIE_DESCR { get; set; }
    }
}
