namespace LayerArchitecture.Model.Entities;

public class Employee
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { set; get; }
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public string Email { set; get; }
    public string PhoneNumber { set; get; }
    public string Address { set; get; }
    public double Salary { set; get; }
    public DateTime JoiningDate { set; get; }
    public DateTime PermanentDate { set; get; }
}