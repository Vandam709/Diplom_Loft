//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom_Loft.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservations
    {
        public int ID { get; set; }
        public int IdLoft { get; set; }
        public int IdProfile { get; set; }
        public System.DateTime TimeReservation { get; set; }
    
        public virtual Lоft Lоft { get; set; }
        public virtual Profiles Profiles { get; set; }
    }
}
