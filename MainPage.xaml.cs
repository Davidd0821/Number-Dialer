using System.Text.RegularExpressions;

namespace ACT2Mid;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    async void onDial(object sender, EventArgs e)
    {

        try
        {
            string phonenum = PhoneNum.Text.Trim();
            string phonepattern = @"\d{10}$";

            if (Regex.IsMatch(phonenum, phonepattern))
            {
                PhoneDialer.Open(PhoneNum.Text);

            }

            else
            {
                await DisplayAlert("Invalid input", "Please enter a valid phone number", "OK");
            }
        }

        catch (Exception ex)
        {
            await DisplayAlert(ex.Message, "Error");
        }
    }

    private Task DisplayAlert(string message, string v)
    {
        throw new NotImplementedException();
    }
}

