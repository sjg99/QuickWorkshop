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

    public partial class order
    {
        public order()
        {
            this.orderpdetails = new HashSet<orderpdetail>();
            this.ordersdetails = new HashSet<ordersdetail>();
        }
    
        public int OrderId { get; set; }
        [DataType(DataType.DateTime)]
        public string Date { get; set; }
        public double TotalPrice { get; set; }
        public int ProductQ { get; set; }
        public int ServiceQ { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
    
        public virtual ICollection<orderpdetail> orderpdetails { get; set; }
        public virtual ICollection<ordersdetail> ordersdetails { get; set; }
        public virtual user user { get; set; }
    }
}
