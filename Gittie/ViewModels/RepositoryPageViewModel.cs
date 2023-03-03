using CommunityToolkit.Mvvm.ComponentModel;

namespace Gittie.ViewModels;

public class RepositoryPageViewModel : ObservableObject
{
    readonly CommonViewModel commonViewModel;

    public RepositoryPageViewModel(CommonViewModel commonViewModel)
    {
        this.commonViewModel = commonViewModel;
    }
}
