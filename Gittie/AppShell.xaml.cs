using Gittie.Services;

namespace Gittie;

public partial class AppShell : Shell
{
    private readonly NavigationService navigationService;

    public AppShell(NavigationService navigationService)
    {
        InitializeComponent();
        this.navigationService = navigationService;
    }

    private void ShellParentChanged(object sender, EventArgs e)
    {
        _ = navigationService.InitializeAsync();
    }
}
