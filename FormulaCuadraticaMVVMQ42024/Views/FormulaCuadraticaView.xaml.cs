using FormulaCuadraticaMVVMQ42024.ViewModels;

namespace FormulaCuadraticaMVVMQ42024.Views;

public partial class FormulaCuadraticaView : ContentPage
{
	FormulaCuadraticaViewModel ViewModel;
	public FormulaCuadraticaView()
	{
		InitializeComponent();
		ViewModel = new FormulaCuadraticaViewModel();
		BindingContext = ViewModel;
	}
}