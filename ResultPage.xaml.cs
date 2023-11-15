using MauiApp5.Models;

namespace MauiApp5;

public partial class ResultPage : ContentPage
{

    public ResultPage(PersonModel person)
    {
        InitializeComponent();

        FirstName.Text = person.FirstName;
        LastName.Text = person.LastName;
        FatherName.Text = person.FatherName;
        NationalCode.Text = person.NationalCode;
        Email.Text = person.Email;
        BirthDate.Text = person.BirthDate.ToString();
    }
}