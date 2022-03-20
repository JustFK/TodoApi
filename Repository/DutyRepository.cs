public class DutyRepository : IDutyRepository
{
    private readonly DbContextBase _context;

    public DutyRepository(DbContextBase context)
    {
        _context = context;
    }

    public Duty AddDuty(Duty duty)
    {
       _context.Add(duty);
        _context.SaveChanges();
        return duty;
    }

    public void DeleteDuty(Duty duty)
    {
        _context.Remove(duty);
        _context.SaveChanges();
    }

    public List<Duty> GetAll()
    {
        return _context.Duties.ToList();
    }

    public Duty GetDutyByName(string dutyName)
    {
        var FindedDuty = _context.Duties.FirstOrDefault(u=>u.Name==dutyName);
        return FindedDuty;
    }

    public Duty UpdateDuty(Duty duty)
    {
        _context.Duties.Update(duty);
        _context.SaveChanges();
        return duty;
    }
}