using CommunityToolkit.Maui.Storage;
using Gittie.ViewModels;

namespace Gittie;

public partial class OpenPage : ContentPage
{
    public OpenPageViewModel ViewModel => (OpenPageViewModel)BindingContext;

    public OpenPage()
    {
        InitializeComponent();
    }

    private async void Browse_Clicked(object sender, EventArgs e)
    {
        var result = await FolderPicker.Default.PickAsync(CancellationToken.None);
        if (result.IsSuccessful)
            ViewModel.CurrentPath = result.Folder.Path;
    }

    private void RecentItemTapped(object sender, ItemTappedEventArgs e)
    {
        ViewModel.CurrentPath = (string)e.Item;
    }
}