using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002_UTSPBO.App.Models
{
    internal class M_Admin
    {
        [Key]
        public int id_admin { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password_admin { get; set; }

    }
}
