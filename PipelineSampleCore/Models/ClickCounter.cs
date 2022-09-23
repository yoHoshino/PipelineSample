namespace PipelineSampleCore.Models;

public class ClickCounter
{
    int _counter = 0;

    public string CountText { get; private set; } = "Click me";


    public void CountUp()
    {
        _counter++;

        CountText = _counter == 1 ? $"Clicked {_counter} time" : $"Clicked {_counter} times";
    }
}
