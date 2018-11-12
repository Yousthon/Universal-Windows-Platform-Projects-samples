using Windows.UI.Xaml.Controls;
using Aurora.Models;
using System.Collections.ObjectModel;

namespace Aurora.Views.Reception
{
    public sealed partial class PatientRegistry : Page
    {
        public PatientRegistry()
        {
            this.InitializeComponent();

            ObservableCollection<Models.Patient> patients = new ObservableCollection<Models.Patient>();
            patients.Add(new Models.Patient()
            {
                Id = 3,
                Adresse = "22BP1616Abidjan22",
                Email = "test@cubexy.com",
                Nom = $"VENCESLAS",
                Prenom = $"Baudoin",
                Phone = "22503046",
                ImageUrl = "ms-appx:///Assets/user.png"
            });
            patients.Add(new Models.Patient()
            {
                Id = 5,
                Adresse = "22BP1616Abidjan22",
                Email = "test@cubexy.com",
                Nom = $"KACOU",
                Prenom = $"Morokro",
                Phone = "22503046",
                ImageUrl = "ms-appx:///Assets/user.png"
            });
            patients.Add(new Models.Patient()
            {
                Id = 4,
                Adresse = "22BP1616Abidjan22",
                Email = "test@cubexy.com",
                Nom = $"ZOUKOU",
                Prenom = $"Mahi",
                Phone = "22503046",
                ImageUrl = "ms-appx:///Assets/user.png"
            });
            patients.Add(new Models.Patient()
            {
                Id = 6,
                Adresse = "22BP1616Abidjan22",
                Email = "test@cubexy.com",
                Nom = $"TAYORO",
                Prenom = $"Christian",
                Phone = "22503046",
                ImageUrl = "ms-appx:///Assets/NavigationViewItemIcons/profile.jpg"
            });
            patients.Add(new Models.Patient()
            {
                Id = 7,
                Adresse = "22BP1616Abidjan22",
                Email = "test@cubexy.com",
                Nom = $"KOFFI",
                Prenom = $"Yves",
                Phone = "22503046",
                ImageUrl = "ms-appx:///Assets/user.png"
            });
            patients.Add(new Models.Patient()
            {
                Id = 3,
                Adresse = "22BP1616Abidjan22",
                Email = "test@cubexy.com",
                Nom = $"VENCESLAS",
                Prenom = $"Baudoin",
                Phone = "22503046",
                ImageUrl = "ms-appx:///Assets/user.png"
            });
            patients.Add(new Models.Patient()
            {
                Id = 5,
                Adresse = "22BP1616Abidjan22",
                Email = "test@cubexy.com",
                Nom = $"KACOU",
                Prenom = $"Morokro",
                Phone = "22503046",
                ImageUrl = "ms-appx:///Assets/user.png"
            });
            patients.Add(new Models.Patient()
            {
                Id = 4,
                Adresse = "22BP1616Abidjan22",
                Email = "test@cubexy.com",
                Nom = $"ZOUKOU",
                Prenom = $"Mahi",
                Phone = "22503046",
                ImageUrl = "ms-appx:///Assets/user.png"
            });
            patients.Add(new Models.Patient()
            {
                Id = 6,
                Adresse = "22BP1616Abidjan22",
                Email = "test@cubexy.com",
                Nom = $"TAYORO",
                Prenom = $"Christian",
                Phone = "22503046",
                ImageUrl = "ms-appx:///Assets/NavigationViewItemIcons/profile.jpg"
            });
            patients.Add(new Models.Patient()
            {
                Id = 7,
                Adresse = "22BP1616Abidjan22",
                Email = "test@cubexy.com",
                Nom = $"KOFFI",
                Prenom = $"Yves",
                Phone = "22503046",
                ImageUrl = "ms-appx:///Assets/user.png"
            });
            AdaptiveGridViewControl.ItemsSource = patients;
        }
    }
}
