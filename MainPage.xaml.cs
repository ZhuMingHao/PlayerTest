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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PlayerTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void DeclarativeInlineButton_GotFocus(object sender, RoutedEventArgs e)
        {
            Windows.UI.ViewManagement.InputPane.GetForCurrentView().TryHide();
            TextBox TB = (TextBox)sender;
            FlyoutBase.ShowAttachedFlyout(TB);
            // Windows.UI.ViewManagement.InputPane.GetForCurrentView().TryShow();
        }

        private void datePicker_Closed(object sender, object e)
        {
        }

        private void datePicker0_DatePicked(DatePickerFlyout sender, DatePickedEventArgs args)
        {
        }
    }
}