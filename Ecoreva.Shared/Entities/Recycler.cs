using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecoreva.Shared.Entities
{
    public class Recycler
    {
        public int id { get; set; }

        [Required(ErrorMessage ="Documento requerido")]
        public string Documento { get; set; } = null;

        [Required(ErrorMessage = "Nombre requerido")]
        public string FirstName { get; set; } = null;

        public string LastName { get; set; } = null;

        [Required(ErrorMessage = "Celular requerido")]
        public string CellPhone { get; set; } = null;

        [Required(ErrorMessage = "Direccion requerida")]
        public string Address { get; set; } = null;

        public string City { get; set; } = null;

        
    }
}
