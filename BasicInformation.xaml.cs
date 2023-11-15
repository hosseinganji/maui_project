using MauiApp5.Models;

namespace MauiApp5;

public partial class BasicInformation : ContentPage
{
    public PersonModel Person { get; set; } = new PersonModel();
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string FatherName { get; set; }

  
    public BasicInformation()
	{
        BindingContext=this;
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Person.FirstName = FirstName;
        Person.LastName = LastName;
        Person.FatherName = FatherName;
        Navigation.PushAsync(new PersonalInformation(Person));

    }
}