using RoadTakenDemo.Finished.Abstractions;
using RoadTakenDemoTemplate.Models;

namespace RoadTakenDemo.Demo.Implementation;

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
