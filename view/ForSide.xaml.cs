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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace VagtplanNy
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ForSide : Page
    {
        public ForSide()
        {
            this.InitializeComponent();
            this.btn_GoToThirdPage.Click += btn_GoToThirdPage_Click;
            this.btn_GoToSecondPage.Click += Btn_GoToSecondPage_Click;
            this.btn_GoToFirstPage.Click += Btn_GoFirstPage_Click;
        }
        private void Btn_GoToSecondPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddVagtSide));
        }
        private void Btn_GoFirstPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MedSide));
        }
        private void btn_GoToThirdPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Vagtplan));
        }
    }
}
