//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickWorkshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class service
    {
        public service()
        {
            this.ordersdetails = new HashSet<ordersdetail>();
        }

        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public string AddSError { get; set; }

        public virtual ICollection<ordersdetail> ordersdetails { get; set; }
    }
}
