using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_2Aplicada2.Models
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        [Required (ErrorMessage ="Es necesario definir un semestre")]
        [StringLength(maximumLength:7,MinimumLength =6,ErrorMessage ="La cadena del semestre esta fuera de rango")]
        public string Semestre { get; set; }
        [Required(ErrorMessage = "Es necesario definir un limite")]
        [Range(typeof(int),minimum:"6",maximum:"100",ErrorMessage ="El limite esta fuera de rango, es muy corto o largo")]
        public int Limite { get; set; }
        [Required(ErrorMessage = "Es necesario definir una cantidad de creditos tomados")]
        [Range(typeof(int), minimum: "1", maximum: "100", ErrorMessage = "La cantidad de creditos tomados esta fuera de rango")]
        public int Tomados { get; set; }
        [Required(ErrorMessage = "Es necesario definir una cantidad de creditos desponible")]
        [Range(typeof(int), minimum: "0", maximum: "100", ErrorMessage = "La cantidad de creditos disponibles esta fuera de rango")]
        public int Disponibles { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomados = 0;
            Disponibles = 0;
        }

    }
}
