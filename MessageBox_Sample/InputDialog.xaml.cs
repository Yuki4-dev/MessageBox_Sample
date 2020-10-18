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

// コンテンツ ダイアログの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace MessageBox_Sample
{
    public sealed partial class InputDialog : ContentDialog
    {
        public string Default { get; set; } = "";

        public string InputText
        {
            get
            {
                return string.IsNullOrEmpty(InputTextBox.Text) ? Default : InputTextBox.Text;
            }
        }

        public InputDialog()
        {
            this.InitializeComponent();
        }

        private void InputDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void InputDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            InputTextBox.Text = string.Empty;
        }
    }
}
