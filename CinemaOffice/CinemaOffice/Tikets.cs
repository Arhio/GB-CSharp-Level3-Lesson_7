//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaOffice
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tikets
    {
        public int TiketsId { get; set; }
        public int Count { get; set; }
        public System.DateTime Time { get; set; }
        public int MoviesID { get; set; }
    
        public virtual Movies MoviesSet { get; set; }
    }
}
