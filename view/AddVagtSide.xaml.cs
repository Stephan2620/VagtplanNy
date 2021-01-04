using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using VagtplanNy.ModelView;
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
    public sealed partial class AddVagtSide : Page
    {
        public MedarbejderView ViewModel { get; set; }
        public VagtView ViewModel2 { get; set; }
        public NyVagtView ViewModel3 { get; set; }

    public AddVagtSide()
        {
            this.InitializeComponent();
            ViewModel = new MedarbejderView();
            ViewModel2 = new VagtView();
            ViewModel3 = new NyVagtView();

            this.btn_GoBack.Click += Btn_GoBack_Click;
        }
        private void Btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        public List<Medarbejder> medarbejders { get; set; }
        public List<Vagt> vagts { get; set; }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
