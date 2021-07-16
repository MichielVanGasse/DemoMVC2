using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    public class AutoModel
    {
        public AutoModel()
        {
            autosCreated++;
        }
        private static int autosCreated = 0;
        public int Id { get; set; } = autosCreated;
        [Required(ErrorMessage = "Kilometerstand is verplicht!")]
        public int KilometerStand { get; set; }
        [Required(ErrorMessage ="Merk is verplicht!")]
        public string Merk { get; set; }
        [Required(ErrorMessage = "Type is verplicht!")]
        [MinLength(1,ErrorMessage ="De naam is te kort")]
        [MaxLength(20,ErrorMessage ="Too long")]
        public string Type { get; set; }
    }
}
