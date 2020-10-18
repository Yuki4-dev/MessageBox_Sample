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
    public sealed partial class InputDialogPage : Page
    {
        public InputDialogPage()
        {
            this.InitializeComponent();
        }

        private async void InputButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new InputDialog()
            {
                Default = "Empty Input Text"
            };

            var result = await dialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                InputTextBlock.Text = dialog.InputText;
                CancelTextBlock.Visibility = Visibility.Collapsed;
            }
            else
            {
                CancelTextBlock.Visibility = Visibility.Visible;
            }
        }
    }
}
