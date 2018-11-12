using Aurora.Data;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace Aurora.Views.Reception
{
    public sealed partial class ReceptionDashboard : Page
    {
        public ReceptionDashboard()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PatientRegistry));
        }
    }
}
