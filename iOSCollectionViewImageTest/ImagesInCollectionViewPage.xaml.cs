using iOSCollectionViewImageTest.ViewModel;

namespace iOSCollectionViewImageTest;

public partial class ImagesInCollectionViewPage : ContentPage
{
    public ImagesInCollectionViewPage(ImagesViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }

    async void PhotoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        try
        {
            Uri uri = new Uri(e.CurrentSelection.FirstOrDefault() as string);
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);

            ((CollectionView)sender).SelectedItem = null;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
