public class DutyService : IDutyService
{
    private readonly IDutyRepository _dutyRepository;

    public DutyService(IDutyRepository dutyRepository)
    {
        _dutyRepository = dutyRepository;
    }

    public Duty AddDuty(Duty duty)
    {
         return _dutyRepository.AddDuty(duty);
    }

    public void DeleteDuty(Duty duty)
    {
         _dutyRepository.DeleteDuty(duty);
    }

    public List<Duty> GetAll()
    {
        return _dutyRepository.GetAll();
    }

    public Duty GetDutyByName(string dutyName)
    {
        return _dutyRepository.GetDutyByName(dutyName);
    }

    public Duty UpdateDuty(Duty duty)
    {
        return _dutyRepository.UpdateDuty(duty);
    }
}
