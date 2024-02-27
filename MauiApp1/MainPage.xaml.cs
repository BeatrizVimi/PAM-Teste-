namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        //Declaração de variável: tipo nometipoDaVariavel = 0;
        int count = 0;
        string nome = "";


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void onnamecliked(object sender, EventArgs e)
      
        {
            nome = NameEntry.Text;
            //Interpolação
            GreetingLabel.Text = $"Hello, {nome}";


            SemanticScreenReader.Announce(GreetingLabel.Text);
        }


    }




}
