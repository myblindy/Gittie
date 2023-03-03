using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LibGit2Sharp;

namespace Gittie.ViewModels;

public partial class CommonViewModel : ObservableObject
{
    [ObservableProperty]
    string? currentRepositoryPath;

    internal async Task<bool> LoadRepository(string path)
    {
        if (!Repository.IsValid(path)) return false;

        CurrentRepositoryPath = path;
        return true;
    }
}
