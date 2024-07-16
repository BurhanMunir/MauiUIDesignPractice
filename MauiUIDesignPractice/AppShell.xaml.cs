using MauiUIDesignPractice.Pages;

namespace MauiUIDesignPractice;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        registerRoutes();
    }

    private static readonly List<Type> _routablePagesType = new List<Type>
        {
            typeof(ProfilePage),
          
        };

    private void registerRoutes()
    {
        foreach (Type pageType in _routablePagesType)
        {
            Routing.RegisterRoute(pageType.Name, pageType);
        }
    }
}

