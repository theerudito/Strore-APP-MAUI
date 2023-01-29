
using Heaven.Model;
using Newtonsoft.Json;
using System.Text;
using System.Windows.Input;

namespace Heaven.ViewModel
{
    public class VM_Page_Home : BaseViewModel
    {
        HttpClient httpClient = new HttpClient();
        MClient mClient = new MClient();
        string url = "http://localhost:3010/api/v1/clients";

        #region CONSTRUCTOR
        public VM_Page_Home(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region VARIABLES
        private string _DNI;
        private string _FirstName;
        private string _LastName;
        private string _Direction;
        private string _Phone;
        private string _Email;
        private string _City;
        #endregion

        #region OBJETOS
        public string DNI
        {
            get { return _DNI; }
            set { SetValue(ref _DNI, value); }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { SetValue(ref _FirstName, value); }
        }
        public string LastName
        {
            get { return _LastName; }
            set { SetValue(ref _LastName, value); }
        }
        public string Direction
        {
            get { return _Direction; }
            set { SetValue(ref _Direction, value); }
        }
        public string Phone
        {
            get { return _Phone; }
            set { SetValue(ref _Phone, value); }
        }
        public string Email
        {
            get { return _Email; }
            set { SetValue(ref _Email, value); }
        }
        public string City
        {
            get { return _City; }
            set { SetValue(ref _City, value); }
        }
        #endregion


        #region METODOS ASYNC
        public async Task Add_Client()
        {
            mClient.DNI = DNI;
            mClient.FirstName = FirstName;
            mClient.LastName = LastName;
            mClient.Direction = Direction;
            mClient.Phone = Phone;
            mClient.Email = Email;
            mClient.City = City;

            var json = JsonConvert.SerializeObject(mClient);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                await Application.Current.MainPage.DisplayAlert("Mensaje", "Cliente Agregado", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Mensaje", "Error al agregar cliente", "OK");
            }
        }
        #endregion

        #region COMANDOS
        public ICommand addNewClient => new Command(async () => await Add_Client());

        #endregion
    }


}
