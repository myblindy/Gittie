using CommunityToolkit.Mvvm.ComponentModel;

namespace Gittie.ViewModels;

public partial class CommonViewModel : ObservableObject
{
    [ObservableProperty]
    string? currentRepositoryPath;
}
