using MelodyFusionMobile.Environment;
using MelodyFusionMobile.Models;
using MelodyFusionMobile.Service;

namespace MelodyFusionMobile;

public partial class MainPage : ContentPage
{
	int count = 0;
    private readonly AuthService _authService;

	public MainPage(AuthService authService)
	{
        
        InitializeComponent();
        _authService = authService;
		Shell.SetTabBarIsVisible(this, false);
		Shell.SetNavBarIsVisible(this, false);
	}

	public async void AuthClicked(object sender, EventArgs e)
	{
        var email = emailEntry.Text;
        var password = passwordEntry.Text;
        var loginRequest = new LoginRequest
        {
            UserName = email,
            Password = password
        };
        var loginResponse = await _authService.Login(loginRequest);
        if (loginResponse != null)
        {
            throw new Exception("Login Succeed");
        }
        else
        {
            throw new Exception("Login failed");
        }
    }
}

