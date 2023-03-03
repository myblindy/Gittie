using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Gittie.Services;
using System.Collections.ObjectModel;

namespace Gittie.ViewModels;

public partial class OpenPageViewModel : ObservableObject
{
    readonly NavigationService navigationService;
    readonly CommonViewModel commonViewModel;

    public OpenPageViewModel(NavigationService navigationService, CommonViewModel commonViewModel)
    {
        this.navigationService = navigationService;
        this.commonViewModel = commonViewModel;
    }

    [ObservableProperty]
    string? currentPath;

    public ObservableCollection<string> RecentPaths { get; } = new()
    {
        @"C:\gitrepos\control-panel",
        @"C:\gitrepos\capture"
    };

    [RelayCommand]
    async Task Open()
    {
        if (!string.IsNullOrWhiteSpace(CurrentPath))
        {
            if (await commonViewModel.LoadRepository(CurrentPath))
                await navigationService.NavigateTo<RepositoryPageViewModel>();
            else
                await navigationService.DisplayAlert($"Invalid repository at '{CurrentPath}'.");
        }
    }
}
