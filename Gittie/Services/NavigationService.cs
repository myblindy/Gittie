using Gittie.ViewModels;
using System.ComponentModel;

namespace Gittie.Services;

public class NavigationService
{
    public async Task InitializeAsync()
    {
        await NavigateTo<OpenPageViewModel>();
    }

    public async Task NavigateTo<TViewModel>() where TViewModel : INotifyPropertyChanged
    {
        await Shell.Current.GoToAsync(new($"//{typeof(TViewModel).Name[..^9]}"));
    }

    public async Task DisplayAlert(string message)
    {
        await Shell.Current.DisplayAlert("Alert", message, "OK");
    }
}
