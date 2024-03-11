using PokerClickerV3;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new MainPage());
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}