using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CGI.Entity.Products
{
    [Table("Product", Schema = "dbo")]
    public class ProductEntity
    {
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("SerialNumber")]
        public string SerialNumber { get; set; }

        [Column("Brand")]
        public string Brand { get; set; }

        [Column("Model")]
        public string Model { get; set; }

        [Column("ProductType")]
        public string ProductType { get; set; }
    }
}
