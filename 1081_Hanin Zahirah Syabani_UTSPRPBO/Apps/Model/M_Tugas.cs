using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1081_Hanin_Zahirah_Syabani_UTSPRPBO.Apps.Model
{
    public class M_Tugas
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string namatugas { get; set; }
        [Required]
        public string deskripsi { get; set; }
        [Required]
        public string deadline { get; set; }
        [Required]
        public int namatugas { get; set; }
        [ForeignKey("M_Tugas")]
        public int id_tugas { get; set; }
    }
}