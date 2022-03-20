public interface IDutyService{
Duty AddDuty(Duty duty);
Duty UpdateDuty(Duty duty);

void DeleteDuty(Duty duty);
List<Duty> GetAll();
Duty GetDutyByName(string dutyName);




}