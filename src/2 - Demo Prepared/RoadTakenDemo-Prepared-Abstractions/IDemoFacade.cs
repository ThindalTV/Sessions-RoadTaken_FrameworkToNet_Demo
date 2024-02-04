using RoadTakenDemoTemplate.Prepared.Abstractions.Models;

namespace RoadTakenDemoTemplate.Prepared.Abstractions;

public interface IDemoFacade
{
    DemoModel AddNumbers(int number1,  int number2);
}
