using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Kitap Adı 2 ile 20 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name ="Kitap Adı")]
        public string Title { get; set; } // nvarchar(512), not nullable
        
        [Display(Name = "Sayfa Sayısı")]
        public int? PageCount { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Yazar Adı 2 ile 100 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Yazarlar")]
        public string Authors { get; set; }

        [StringLength(400, MinimumLength = 10, ErrorMessage = "Açıklama 10 ile 400 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Açıklama")]
        public string Description  { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Fiyat")]
        public Decimal Price { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Basım Yılı")]
        public int PressYear { get; set; }

        [Display(Name = "Ürün Adedi")]
        public int StockCount { get; set; }


        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        public  Category Category { get; set; }

        [Editable(false)]
        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreatedDate { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            CreatedDate = DateTime.Now;
          //  double result = 4.0 / 2.0; //2.0000000000000000000000001 1.9999999999999999999999998
        }

    }
}
