using PipelineSampleCore.Models;

namespace PipelineSampleTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var counter = new ClickCounter();
        Assert.Equal("Click me", counter.CountText);

        counter.CountUp();
        Assert.Equal("Clicked 1 time", counter.CountText);

        counter.CountUp();
        Assert.Equal("Clicked 2 times", counter.CountText);

        counter.CountUp();
        Assert.Equal("Clicked 3 times", counter.CountText);
    }
}