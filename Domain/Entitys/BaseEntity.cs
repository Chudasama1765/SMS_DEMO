using CampusOne.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CampusOne.Domain.Entitys
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public Row_Status_Enum RowStatus { get; set; }

        //[ForeignKey("CreatedBy")]
        //public User CreatedByUser { get; set; }

        //[ForeignKey("UpdatedBy")]
        //public User UpdatedByUser { get; set; }

    }
}
