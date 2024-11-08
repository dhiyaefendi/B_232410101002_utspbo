using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002_UTSPBO.App.Models
{
    internal class M_Pengguna
    {
        [Key]
        public int id_pengguna { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password_pengguna { get; set; }

    }
}
