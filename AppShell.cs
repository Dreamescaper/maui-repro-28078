namespace ShellBugRepro
{
    public class AppShell : Shell
    {
        public AppShell()
        {
            Items.Add(new LogInPage(this));
        }

        public void LoggedIn()
        {
            Items.Clear();

            Items.Add(new Page1());
            Items.Add(new Page2());
        }
    }

    public class LogInPage : ContentPage
    {
        public LogInPage(AppShell shell)
        {
            Title = "LogIn Page";

            var button = new Button { Text = "Click Me to Log In!" };
            button.Clicked += (_, _) => shell.LoggedIn();

            Content = new VerticalStackLayout
            {
                Children = { button }
            };
        }
    }


    public class Page1 : ContentPage
    {
        public Page1()
        {
            Title = "Page 1";
            Content = new VerticalStackLayout
            {
                Children = { new Label { Text = "Just a first page, nothing fancy." } }
            };
        }
    }

    public class Page2 : ContentPage
    {
        public Page2()
        {
            Title = "Page 2";
            Content = new VerticalStackLayout
            {
                Children = { new Label { Text = "Just a second page, nothing fancy." } }
            };
        }
    }
}
