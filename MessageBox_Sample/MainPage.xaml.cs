using MessageBox_Sample;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.ApplicationModel.UserDataTasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

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
            Windows.ApplicationModel.Core.CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().TitleBar.ButtonBackgroundColor = Windows.UI.Colors.Transparent;
            Window.Current.SetTitleBar(TittleBar);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Content.Navigate(typeof(ContentDialogPage));
        }

        private void ContentDialogButton_Click(object sender, RoutedEventArgs e)
        {
            Content.Navigate(typeof(ContentDialogPage));
        }

        private void MessageDialogNutton_Click(object sender, RoutedEventArgs e)
        {
            Content.Navigate(typeof(MessageDialogPage));
        }

        private void InputDialogNutton_Click(object sender, RoutedEventArgs e)
        {
            Content.Navigate(typeof(InputDialogPage));
        }
    }
}
