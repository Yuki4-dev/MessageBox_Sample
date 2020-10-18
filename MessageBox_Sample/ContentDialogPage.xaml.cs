using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace MessageBox_Sample
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class ContentDialogPage : Page
    {
        public ContentDialogPage()
        {
            this.InitializeComponent();
        }
        private async void OkButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ContentDialog()
            {
                Title = "OK Dialog Here!!",
                Content = "Click Ok Button Dialog",
                CloseButtonText = "Ok"
            };

            var result = await dialog.ShowAsync();
            OkText.Text = $"Get Result : {result}";
        }

        private async void YesNoButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ContentDialog()
            {
                Title = "Yes No Dialog Here!!",
                Content = "Click Yes No Button Dialog",
                PrimaryButtonText = "Yes",
                CloseButtonText = "No"
            };

            var result = await dialog.ShowAsync();
            YesNoText.Text = $"Get Result : {result}";
        }

        private async void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ContentDialog()
            {
                Title = "3 Button Dialog Here!!",
                Content = "Click 3 Button Dialog",
                PrimaryButtonText = "Allow",
                SecondaryButtonText = "Delete",
                CloseButtonText = "Cancel"
            };

            var result = await dialog.ShowAsync();
            TreeText.Text = $"Get Result : {result}";
        }
    }
}
