using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CATEGORIES
    {
        [Key]
        public int INT_IDD_CATEG { get; set; }
        public string STR_NAMEE_CATEG { get; set; }
    }
}
