namespace AgeCalc;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }
    
    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        double age = Convert.ToInt32(Input.Text);
        double yearsUntilAlcohol = 21 - age;

        if (age >= 21)
        {
            Years.Text = $"You can legally drink alcohol! ";
        }
        else
        {
            Years.Text = $"You have {yearsUntilAlcohol} year(s) until you can drink alcohol. ";
        }
        
        
    }
    
    void Date_Button_Clicked(System.Object sender, System.EventArgs e)
    {
        var currentDate = DateTime.Now;
        var pickerDate = DatePickerInput.Date;
        TimeSpan resultYears = (currentDate - pickerDate) / 365;
        var age = resultYears.Days;
        double yearsUntilAlcohol = 21 - age;
        
        if (age >= 21)
        {
            Years.Text = $"You can legally drink alcohol! ";
        }
        else
        {
            Years.Text = $"You have {yearsUntilAlcohol} year(s) until you can drink alcohol. ";
        }

    }
}