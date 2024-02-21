using MyCompany.Intranet.Core.Entities;
using MyCompany.Intranet.Core.Managers.Interfaces;
using MyCompany.Intranet.Core.Services.Interfaces;

namespace MyCompany.Intranet.Core.Managers;

public class ISRManager : IISRManager {

    private readonly IISRService _service;

    public ISRManager(IISRService service){
        _service = service;
    }

    public ISR Calculator(Person person){
        return _service.Calculator(person);
    }
    
}