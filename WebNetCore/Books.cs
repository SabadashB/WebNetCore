using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebNetCore
{
    public class Books
    {
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
        [Required]
        public int Pages { get; set; }
        [Required]
        public int Count { get; set; }
    }
}
