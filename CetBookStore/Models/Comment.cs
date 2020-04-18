using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Comment
    {
        [Key]
        public int Id{ get; set; }

        [StringLength(10, MinimumLength = 3, ErrorMessage = "Ünvan Alanı 2 ile 10 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Ünvan")]
        public string Title { get; set; }

        [StringLength(400, MinimumLength = 3, ErrorMessage = "Detay Alanı 2 ile 400 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Detay")]
        public string Detail { get; set; }

        [Display(Name = "Derecelendirme")]
        public int? Rating { get; set; }

        [Editable(false)]
        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreatedDate { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
