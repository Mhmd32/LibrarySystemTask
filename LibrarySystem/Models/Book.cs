//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibrarySystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.BookAuthors = new HashSet<BookAuthor>();
        }
    
        public int BookId { get; set; }
        public string Title { get; set; }
        public System.DateTime PublicationDate { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> SubcategoryId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual BookSubcategory BookSubcategory { get; set; }
    }
}
