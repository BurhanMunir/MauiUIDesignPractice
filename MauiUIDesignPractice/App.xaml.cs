using MauiUIDesignPractice.Pages;
using MauiUIDesignPractice.ViewModels;

namespace MauiUIDesignPractice;

public partial class App : Application
{
    public App(ProfileViewModel viewModel)
    {
        InitializeComponent();

        MainPage = new ProfilePage(viewModel);
    }
}

