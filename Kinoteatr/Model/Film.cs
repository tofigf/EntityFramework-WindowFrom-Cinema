//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kinoteatr.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            this.FilmCountries = new HashSet<FilmCountry>();
            this.FilmGenres = new HashSet<FilmGenre>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Year { get; set; }
        public string Director { get; set; }
        public string AgeRes { get; set; }
        public string About { get; set; }
        public string Photo { get; set; }
        public string Trialer { get; set; }
        public Nullable<int> is3D { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<System.DateTime> Premiere { get; set; }
        public int LanguageID { get; set; }
        public int CcID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmCountry> FilmCountries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmGenre> FilmGenres { get; set; }
        public virtual Language Language { get; set; }
        public virtual Language Language1 { get; set; }
    }
}
