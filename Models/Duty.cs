
public class Duty
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string DueDate { get; set; }
    public string StartedDate { get; set; }
    public bool Status  { get; set; }
    public string CompletedDate { get; set; }
    public virtual ICollection<UserNote> UserNotes { get; set; }
}
