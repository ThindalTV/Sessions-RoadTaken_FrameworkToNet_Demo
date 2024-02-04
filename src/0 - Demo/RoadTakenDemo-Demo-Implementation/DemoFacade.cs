using RoadTakenDemo.Abstractions;
using RoadTakenDemo.Abstractions.Models;

namespace RoadTakenDemo.Implementation;

public class DemoFacade : IDemoFacade { 
    public DemoModel AddNumbers(int number1, int number2)
    {
        return new DemoModel
        {
            FirstNumber = number1,
            SecondNumber = number2,
            Result = number1 + number2
        };
    }
}
