using MyCompany.Intranet.Core.Entities;
using MyCompany.Intranet.Core.Enums;
using MyCompany.Intranet.Core.Services.Interfaces;

namespace MyCompany.Intranet.Core.Services;

public class ISRService : IISRService{
    
    public ISR Calculator(Person person){

        var isr = new ISR();


        if (person.sueldo <= 7735.00)
        {
            isr.Impuestos = (float)(((1.92) / 100) * (person.sueldo - 0.01) + 0.00);
        } else if (person.sueldo > 7735 && person.sueldo <= 65651.07)
        {
            isr.Impuestos = (float)(((6.40) / 100) * (person.sueldo - 7735.01) + 148.51);
        } else if (person.sueldo > 65651.07 && person.sueldo <= 115375.90)
        {
            isr.Impuestos = (float)(((10.88) / 100) * (person.sueldo - 65651.08) + 3855.14);
        } else if (person.sueldo > 115375.90 && person.sueldo <= 134119.41)
        {
            isr.Impuestos = (float)(((16.00) / 100) * (person.sueldo - 115375.91) + 9265.20);
        } else if (person.sueldo > 134119.41 && person.sueldo <= 160577.65)
        {
            isr.Impuestos = (float)(((17.92) / 100) * (person.sueldo - 134119.42) + 12264.16);
        } else if (person.sueldo > 160577.65 && person.sueldo <= 323862.00)
        {
            isr.Impuestos = (float)(((21.36) / 100) * (person.sueldo - 160577.66) + 17005.47);
        } else if (person.sueldo > 323862.00 && person.sueldo <= 510451.00)
        {
            isr.Impuestos = (float)(((23.52) / 100) * (person.sueldo - 323862.01) + 51863.01);
        } else if (person.sueldo > 510451.00 && person.sueldo <= 974535.03)
        {
            isr.Impuestos = (float)(((30.00) / 100) * (person.sueldo - 510451.01) + 95768.74);
        } else if (person.sueldo > 974535.03 && person.sueldo <= 1299380.04)
        {
            isr.Impuestos = (float)(((32.00) / 100) * (person.sueldo - 974535.04) + 234993.95);
        } else if (person.sueldo > 1299380.04 && person.sueldo <= 3898140.12)
        {
            isr.Impuestos = (float)(((34.00) / 100) * (person.sueldo - 1299380.05) + 338944.34);
        }else if (person.sueldo > 3898140.12)
        {
            isr.Impuestos = (float)(((35.00) / 100) * (person.sueldo - 3898140.12) + 1222522.76);
        }
        
        return isr;

    }
}