namespace iOSCollectionViewImageTest;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ImagesInCollectionViewPage), typeof(ImagesInCollectionViewPage));
    }
}

