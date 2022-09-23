using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PipelineSampleCore.Models;

namespace PipelineSampleCore.ViewModels;

[ObservableObject]
public partial class MainViewModel
{
    readonly ClickCounter _counter;

    public string CounterButtonText => _counter.CountText;

    public MainViewModel(ClickCounter counter) => _counter = counter;

    [RelayCommand]
    void CountUp()
    {
        _counter.CountUp();

        OnPropertyChanged(nameof(CounterButtonText));
    }
}
