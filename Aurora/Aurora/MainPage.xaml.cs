using Aurora.Views.Doctor;
using Aurora.Views.HMI;
using Aurora.Views.Hospital;
using Aurora.Views.Kiosk;
using Aurora.Views.Patient;
using Aurora.Views.Pharma;
using Aurora.Views.Reception;
using System.Linq;
using Windows.UI.Xaml.Controls;

namespace Aurora
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            contentFrame.Navigate(typeof(ReceptionDashboard));
        }

        private void navView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var item = sender.MenuItems.OfType<NavigationViewItem>()
                .First(x => (string)x.Content == (string)args.InvokedItem);

            NavView_Navigate(item as NavigationViewItem);
        }

        private void NavView_Navigate(NavigationViewItem item)
        {
            switch (item.Tag)
            {
                case "reception":
                    contentFrame.Navigate(typeof(ReceptionDashboard));
                    break;
                case "doctor":
                    contentFrame.Navigate(typeof(DoctorDashboard));
                    break;
                case "patient":
                    contentFrame.Navigate(typeof(PatientDashboard));
                    break;
                case "kiosk":
                    contentFrame.Navigate(typeof(KioskDashboard));
                    break;
                case "pharma":
                    contentFrame.Navigate(typeof(PharmaDashboard));
                    break;
                case "hmi":
                    contentFrame.Navigate(typeof(HMIDashboard));
                    break;
                case "hospital":
                    contentFrame.Navigate(typeof(HospitalDashboard));
                    break;
            }
        }

    }
}
