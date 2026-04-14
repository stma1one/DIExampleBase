using DIExample.ViewModels;

namespace DIExample.Views;

public partial class ScorePage : ContentPage
{
	public ScorePage()
	{
		InitializeComponent();
		BindingContext = new ScorePageViewModel();
	}
}