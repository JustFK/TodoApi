using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("[controller]")]
public class DutyController : ControllerBase
{
    private readonly IDutyService _dutyService;

    public DutyController(IDutyService dutyService)
    {
        _dutyService = dutyService;
    }

    [HttpGet("getall")]

    public List<Duty> GetAll()
    { 
        return _dutyService.GetAll();
    }

    [HttpPost("add")]

    public async Task<Duty> AddDuty(Duty duty){
        return  _dutyService.AddDuty(duty);
    }

    [HttpDelete("delete")]

    public async Task Delete(Duty duty){
         _dutyService.DeleteDuty(duty);
    }
    [HttpPut("Update")]
    public async Task<Duty> UpdateDuty(Duty duty){
        return _dutyService.UpdateDuty(duty);
    }
    [HttpGet("get")]
    
    public async Task<Duty> GetByDutyName(string dutyName){
        return _dutyService.GetDutyByName(dutyName);
    }
   
    
}
