﻿using Microsoft.Maui.Controls;

namespace PokerClickerV3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            SetupNavigationBar();
        }

        private void SetupNavigationBar()
        {
            var navigationLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromRgb(255, 250, 250),
                Padding = new Thickness(10)
            };

            var homeButton = new Button
            {
                Text = "Home",
                BackgroundColor = Color.FromRgba(0, 0, 0, 0.0),
                TextColor = Color.FromRgb(255, 255, 255)
            };
            homeButton.Clicked += async (sender, e) =>
            {
                await DisplayAlert("Navigation", "You clicked Home", "OK");
            };

            var aboutButton = new Button
            {
                Text = "About",
                BackgroundColor = Color.FromRgb(240, 255, 240),
                TextColor = Color.FromRgb(255, 222, 173)
            };
            aboutButton.Clicked += async (sender, e) =>
            {
                await DisplayAlert("Navigation", "You clicked About", "OK");
            };

            navigationLayout.Children.Add(homeButton);
            navigationLayout.Children.Add(aboutButton);

            NavigationPage.SetTitleView(this, navigationLayout);
        }

        private async void OnPokerImageTapped(object sender, EventArgs e)
        {
            count++;

            // Pildi suuruse muutmine animatsiooniga
            await ((VisualElement)sender).ScaleTo(0.8, 250); // Muudab suurust 80% -le originaalist
            await ((VisualElement)sender).ScaleTo(1, 250); // Taastab originaalsuuruse

            // Skoori väärtuse muutmine vastavalt klõpsude arvule
            ScoreLabel.Text = $"Score: {count}";

            // Asendage SemanticScreenReader.Announce oma eelistatud teabeedastusmeetodiga
            Announce($"Clicked {count} times");
        }

        // Funktsioon teabe edastamiseks (võib olla osa teisest teenusest)
        private void Announce(string message)
        {
            // Asendage see osa oma rakenduse konkreetse teabe edastamise meetodiga
            Console.WriteLine(message);
        }
    }
}
