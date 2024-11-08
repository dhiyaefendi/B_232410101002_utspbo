using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002_UTSPBO.App.Models
{
    internal class M_Tugas
    {
        [Key]
        public int id_tugas { get; set; }
        [Required]
        public string judul_tugas { get; set; }
        [Required]
        public string deskripsi_tugas { get; set; }
        [Required]
        public string deadline { get; set; }

    }
}
