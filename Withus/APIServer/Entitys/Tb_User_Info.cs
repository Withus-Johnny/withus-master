using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIServer.Entitys
{
    [Index(nameof(user_phone), IsUnique = true)]
    [Index(nameof(user_email), IsUnique = true)]
    [Table("tb_user_info")]
    public class Tb_User_Info
    {
        [Key]
        [Column(Order = 1)]
        public int uid { get; set; }

        [Required]
        [Column(Order = 2, TypeName = "VARCHAR")]
        [StringLength(30)]
        public string user_email { get; set; }

        [Required]
        [Column(Order = 3, TypeName = "VARCHAR")]
        [StringLength(64)]
        public string user_password { get; set; }

        [Required]
        [Column(Order = 4, TypeName = "VARCHAR")]
        [StringLength(10)]
        public string user_name { get; set; }

        [Required]
        [Column(Order = 5, TypeName = "VARCHAR")]
        [StringLength(13)]
        public string user_phone { get; set; }

        [Column(Order = 6, TypeName = "VARCHAR")]
        [StringLength(25)]
        public string recommender { get; set; }

        [Column(Order = 7, TypeName = "VARCHAR")]
        [StringLength(25)]
        public string advisor { get; set; }

        [Column(Order = 8, TypeName = "TINYINT(1)")]
        public bool is_activity { get; set; } = true;

        [Column(Order = 9, TypeName = "TIMESTAMP")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime created_datetime { get; set; }

        [Column(Order = 10, TypeName = "TIMESTAMP")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime updated_datetime { get; set; }
    }
}
