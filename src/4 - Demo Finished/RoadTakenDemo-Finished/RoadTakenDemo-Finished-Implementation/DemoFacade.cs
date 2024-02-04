using RoadTakenDemo_Finished_Abstractions;

namespace RoadTakenDemo_Finished_Implementation
{
    public class DemoFacade : IDemoFacade
    {
        public int AddNumbers(int number1, int number2) => number1 + number2;
    }
}
