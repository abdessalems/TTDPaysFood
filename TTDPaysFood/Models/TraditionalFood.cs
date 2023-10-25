// Models/TraditionalFood.cs
public class TraditionalFood
{
    public int Id { get; set; }
    public string Name { get; set; }
    // Other properties related to traditional foods
    public int PayId { get; set; } // Foreign key to link to Pay
}
