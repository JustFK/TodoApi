public class UserNote{
public int Id { get; set; }
public string Title { get; set; }
public virtual ICollection<Duty> Duties { get; set; }

public virtual User User{get; set;}
public int UserId{get; set;}
}
