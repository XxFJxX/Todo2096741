using Todo2096741.Views;
namespace Todo2096741;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));
    }
}
