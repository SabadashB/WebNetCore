using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CoreDAL
{
    public class Library
    {
        public Library()
        {
            this.Books = new HashSet<Book>();
        }

        [KeyAttribute]
        public Guid Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        public string City { get; set; }
        [Required]
        public int XLocation { get; set; }
        [Required]
        public int YLocation { get; set; }
        public virtual ICollection<Book> Books { get; set; }

    }
}
