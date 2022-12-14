//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADONETExample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Track
    {
        public int TrackId { get; set; }
        public string Name { get; set; }
        public Nullable<int> AlbumId { get; set; }
        public int MediaTypeId { get; set; }
        public Nullable<int> GenreId { get; set; }
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public Nullable<int> Bytes { get; set; }
        public decimal UnitPrice { get; set; }
    
        public virtual Album Album { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
