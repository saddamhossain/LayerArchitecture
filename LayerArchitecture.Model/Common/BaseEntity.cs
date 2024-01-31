namespace LayerArchitecture.Model.Common;

public class BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { set; get; }
    public string CreatedBy { set; get; }
    public DateTime CreatedDate { set; get; }
    public string LastModifiedBy { set; get; }
    public DateTime? LastModifiedDate { set; get; }

    [ConcurrencyCheck]
    public Guid Version { get; set; }
}