using Windows.UI.Xaml;
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace MessageBox_Sample
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage
    {

        public MainPage()
        {
            this.InitializeComponent();
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationView.GetForCurrentView().TitleBar.ButtonBackgroundColor = Windows.UI.Colors.Transparent;
            Window.Current.SetTitleBar(TittleBar);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(ContentDialogPage));
        }

        private void ContentDialogButton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(ContentDialogPage));
        }

        private void MessageDialogNutton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(MessageDialogPage));
        }

        private void InputDialogNutton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(InputDialogPage));
        }
    }
}
