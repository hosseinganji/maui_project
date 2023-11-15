using MauiApp5.Models;

namespace MauiApp5;

public partial class PersonalInformation : ContentPage
{
    public  PersonModel Person {  get; set; }
    public string NationalCode {  get; set; }
    public string Email {  get; set; }
    public DateTime BirthDate { get; set; }
    public PersonalInformation(PersonModel person )
	{
        this.Person = person;
        BindingContext = this;
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
      Person.NationalCode= NationalCode;
        Person.Email= Email;
        Person.BirthDate=DateOnly.FromDateTime(BirthDate);
        Navigation.PushAsync(new ResultPage(Person));

    }
}