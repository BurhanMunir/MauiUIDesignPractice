using MauiUIDesignPractice.ViewModels;

namespace MauiUIDesignPractice.Pages;

public partial class ProfilePage : ContentPage
{
    public ProfilePage(ProfileViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}
