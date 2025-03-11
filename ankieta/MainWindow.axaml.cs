using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ankieta;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void PersonalDataHandler(object? sender, RoutedEventArgs e)
    {
        Summary1.Text = Name.Text+" Hobby: "+(Hobby.SelectedItem as ComboBoxItem)?.Content.ToString() +" ";
    }

    private void AnswersHandler(object? sender, RoutedEventArgs e)
    {
        int Answers = 0;
       
        
        if (CheckBox1.IsChecked == true)
        {
            Answers++;
        }
        if (CheckBox2.IsChecked == true)
        {
            Answers++;
        }
        if (CheckBox3.IsChecked == true)
        {
            Answers++;
        }
        if (CheckBox4.IsChecked == true)
        {
            Answers++;
        }

        Summary2.Text = "Ilość odpowiedzi Tak: " + Answers;
    }
}