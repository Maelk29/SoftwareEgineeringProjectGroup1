namespace SoftwareGroup1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCitySelected(object sender, EventArgs e)
        {
            if (City.SelectedIndex == -1)
                return;

            string selectedSensor = City.SelectedItem.ToString();

            string information = selectedSensor switch
            {
                "Eschede MKR" => "Eschede MKR: \n\t latitude: 52.2212025684184\n\t longitude: 6.88635438680649\n\t altitude: 70",
                "Eschede LHT" => "Eschede LHT: \n\t latitude: 52.22121\n\t longitude: 6.8857374\n\t altitude: 66",
                "Wierden MKR" => "Wierden MKR: \n\t latitude: 52.36891310514845\n\t longitude: 6.602898538112641\n\t altitude: 10",
                "Wierden LHT" => "Wierden LHT: \n\t latitude: 52.36891310514845\n\t longitude: 6.602898538112641\n\t altitude: 10",
                "Gronau LHT" => "Gronau LHT: \n\t latitude: 52.212645202154\n\t longitude: 7.03965711534693\n\t altitude: 41",
                "Group1 MKR" => "Group1: \n\t latitude: ?\n\t longitude: ?\n\t altitude: ?"
            };

            SensorInfo.Text = information;
        }


    }

}
