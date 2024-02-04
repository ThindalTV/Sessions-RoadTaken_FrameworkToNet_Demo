using RoadTakenDemo.Abstractions.Models;

namespace RoadTakenDemo.Abstractions;

public interface IDemoFacade
{
    DemoModel AddNumbers(int number1,  int number2);
}
