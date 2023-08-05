using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive;
using System.Reactive.Linq;

namespace UltimaVez;

public class MainViewModel : ReactiveObject
{
    public MainViewModel()
    {
        var clicksStream = this.WhenAnyValue(x => x.Count);

        clicksStream
            .Select(clicks =>
            {
                if (clicks == 1)
                    return $"Clicked {clicks} time";
                else
                    return $"Clicked {clicks} times";
            })
            .ToPropertyEx(this, x => x.CountText);

        var canExecute = clicksStream
            .Select(clicks => clicks < 10);

        CounterCommand = ReactiveCommand.Create(() => { Count++; }, canExecute);
    }

    [Reactive] public int Count { get; set; }
    [ObservableAsProperty] public string CountText { get; }

    public ReactiveCommand<Unit, Unit> CounterCommand { get; }
}


