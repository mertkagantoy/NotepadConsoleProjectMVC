using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Notepad.Models
{
    public class Note
    {
        [Key] // Birincil anahtar olarak belirtiyoruz.
        public int Id { get; set; }

        [Required] // Boş olamaz
        public string Content { get; set; }
    }
}
