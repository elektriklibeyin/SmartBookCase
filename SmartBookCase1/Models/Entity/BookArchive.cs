//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartBookCase1.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookArchive
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookArchive()
        {
            this.BookRent = new HashSet<BookRent>();
        }
    
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookCategory { get; set; }
        public int BookStock { get; set; }
        public string BookAuthor { get; set; }
        public string BookBarcode { get; set; }
        public string BookPublisherHouse { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookRent> BookRent { get; set; }
    }
}
