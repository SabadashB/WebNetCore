using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDAL
{
    public class Book
    {
        public Book()
        {
            this.Libraries = new HashSet<Library>();
        }
        [KeyAttribute]
        public Guid Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(25)]
        public string AuthorName { get; set; }
        public int Pages { get; set; }
        public int CountOfTaken { get; set; }

        public virtual ICollection<Library> Libraries { get; set; }
    }
}
