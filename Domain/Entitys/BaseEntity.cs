using CampusOne.Shared.Enums;
namespace CampusOne.Domain.Entitys
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public Row_Status_Enum RowStatus { get; set; }

    }
}
