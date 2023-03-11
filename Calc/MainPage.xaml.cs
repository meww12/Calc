namespace Calc;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void ButtonClear_Clicked(object sender, EventArgs e)
    {
        txtCalc.Text = "0";
    }
    private void ButtonClearOne_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str.Length <= 1) txtCalc.Text = "0";
        else txtCalc.Text = str.Remove(str.Length - 1);
    }
    private void ButtonZero_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "0";
        else txtCalc.Text = string.Concat(str, 0);
    }
    private void ButtonOne_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "1";
        else txtCalc.Text = string.Concat(str, 1);
    }
    private void ButtonTwo_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "2";
        else txtCalc.Text = string.Concat(str, 2);
    }
    private void ButtonThree_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "3";
        else txtCalc.Text = string.Concat(str, 3);
    }
    private void ButtonFour_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "4";
        else txtCalc.Text = string.Concat(str, 4);
    }
    private void ButtonFive_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "5";
        else txtCalc.Text = string.Concat(str, 5);
    }
    private void ButtonSix_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "6";
        else txtCalc.Text = string.Concat(str, 6);
    }
    private void ButtonSeven_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "7";
        else txtCalc.Text = string.Concat(str, 7);
    }
    private void ButtonEight_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "8";
        else txtCalc.Text = string.Concat(str, 8);
    }
    private void ButtonNine_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "9";
        else txtCalc.Text = string.Concat(str, 9);
    }
    private void ButtonPlus_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "0";
        else if (str.Contains("+") == false && str.Contains("-") == false && str.Contains("*") == false && str.Contains("/") == false) txtCalc.Text = string.Concat(str, "+");
    }
    private void ButtonMinus_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "0";
        else if (str.Contains("+") == false && str.Contains("-") == false && str.Contains("*") == false && str.Contains("/") == false) txtCalc.Text = string.Concat(str, "-");
    }
    private void ButtonUmn_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "0";
        else if (str.Contains("+") == false && str.Contains("-") == false && str.Contains("*") == false && str.Contains("/") == false) txtCalc.Text = string.Concat(str, "*");
    }
    private void ButtonDelen_Clicked(object sender, EventArgs e)
    {
        string str = txtCalc.Text;
        if (str == "0") txtCalc.Text = "0";
        else if (str.Contains("+") == false && str.Contains("-") == false && str.Contains("*") == false && str.Contains("/") == false) txtCalc.Text = string.Concat(str, "/");
    }
    private void ButtonRavno_Clicked(object sender, EventArgs e)
    {
        try
        {
            string s = txtCalc.Text;

            char[] operat = { '+', '-', '*', '/' };

            var data = s.Split(operat, StringSplitOptions.None);
            int arg1 = int.Parse(data[0]);
            int arg2 = int.Parse(data[1]);

            if (s.Contains("-")) txtCalc.Text = (arg1 - arg2).ToString();
            else if (s.Contains("+")) txtCalc.Text = (arg1 + arg2).ToString();
            else if (s.Contains("*")) txtCalc.Text = (arg1 * arg2).ToString();
            else txtCalc.Text = (arg1 / arg2).ToString();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ошибка!", ex.ToString(), "OK");
            txtCalc.Text = "0";
        }
    }
    private void ButtonStep_Clicked(object sender, EventArgs e)
    {
        int str = int.Parse(txtCalc.Text);
        if (str == 0) txtCalc.Text = "0";
        else txtCalc.Text = Math.Pow(2, str).ToString();
    }

}

