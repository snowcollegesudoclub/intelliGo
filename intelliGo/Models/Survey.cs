using LinqToDB.Mapping;

namespace intelliGo.Models
{
    [Table(Name = "surveys")]
    public class Survey
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "productname"), NotNull]
        public string Name { get; set; }
    }
}
