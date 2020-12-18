using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ZNO_ukr_mobile.Views
{
    public partial class AboutPage : ContentPage
    {
        #region Variables
        private StackLayout LayoutNagolosi;
        private List<NagolosiSlova> Slova;
        private NagolosiSlova SlovoNaOtvet;
        private Entry NumberSklada;
        private Label Word_label;
        private Label ResultOfAnswer;
        private Label WordAnswer;
        private Button CheckAnswer;
        private Button NextWord;
        private Button AllTasks;
        #endregion

        #region AllPages        
        public AboutPage()
        {
            InitializeComponent();
            AllPages_NewLayout();
        }
       
        internal void AllPages_NewLayout()
        {
            var AllPages_Layout = NewLayoutNagolosi();

            var Nagolosi_tasks = NewButton("Наголоси");
            Nagolosi_tasks.Clicked += Nagolosi_tasks_Clicked;
            AllPages_Layout.Children.Add(Nagolosi_tasks);

            var NameOftasks_1 = NewButton("NameOftasks_Clicked_1");
            NameOftasks_1.Clicked += NameOftasks_Clicked_1;
            AllPages_Layout.Children.Add(NameOftasks_1);

            var NameOftasks_2 = NewButton("NameOftasks_Clicked_2");
            NameOftasks_2.Clicked += NameOftasks_Clicked_2;
            AllPages_Layout.Children.Add(NameOftasks_2);

            Content = AllPages_Layout;
        }

        private void AllTasks_OnButtonClicked(object sender, System.EventArgs e)
        {
            AllPages_NewLayout();
            return;
        }
        #endregion

        #region Nagolosi
        private void Nagolosi_tasks_Clicked(object sender, EventArgs e)
        {
            LayoutNagolosi = NewLayoutNagolosi();
            Content = Nagolosi_ViewCompiler();
            Nagolosi();
            return;
        }


        public void Nagolosi()
        {
            var nagolosiSlova = new NagolosiSlova(default, default, default);
            nagolosiSlova.SpisokSlov();
            Slova = nagolosiSlova.Slova;
            NewWord();
        }

        private void NewWord()
        {
            var index = new Random();
            SlovoNaOtvet = Slova[index.Next(Slova.Count)];
            Word_label.Text = "";
            Word_label.Text = SlovoNaOtvet.Slovo;
            ResultOfAnswer.Text = "";
            WordAnswer.Text = "";
        }

        internal StackLayout Nagolosi_ViewCompiler()
        {
            NumberSklada = new Entry
            {
                Placeholder = "Номер наголошеного складу",
                ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                Keyboard = Keyboard.Numeric,
                VerticalOptions = LayoutOptions.Center
            };

            CheckAnswer = NewButton("Перевірити відповідь");
            CheckAnswer.Clicked += CheckAnswer_OnButtonClicked;

            NextWord = NewButton("Наступне слово");
            NextWord.Clicked += NextWord_OnButtonClicked;

            AllTasks = NewButton("Всі вправи");
            AllTasks.Clicked += AllTasks_OnButtonClicked;

            Word_label = NewLabel();
            ResultOfAnswer = NewLabel();
            WordAnswer = NewLabel();

            LayoutNagolosi.Children.Add(Word_label);
            LayoutNagolosi.Children.Add(NumberSklada);
            LayoutNagolosi.Children.Add(CheckAnswer);
            LayoutNagolosi.Children.Add(ResultOfAnswer);
            LayoutNagolosi.Children.Add(NextWord);
            LayoutNagolosi.Children.Add(WordAnswer);
            LayoutNagolosi.Children.Add(AllTasks);

            return LayoutNagolosi;
        }
        private void CheckAnswer_OnButtonClicked(object sender, System.EventArgs e)
        {
            if (!int.TryParse(NumberSklada.Text, out int Result))
            {
                ResultOfAnswer.Text = "Помилка вводу відповіді. Необхідно вводити натуральне число. :(";
            }
            if (Result == SlovoNaOtvet.NumberSklada)
            {
                ResultOfAnswer.Text = "Вірно :)";
            }
            else
            {
                ResultOfAnswer.Text = "Помилка :(";
            }
            WordAnswer.Text = SlovoNaOtvet.Otvet;
        }

        private void NextWord_OnButtonClicked(object sender, System.EventArgs e)
        {
            NewWord();
        }
        #endregion

        #region NameOftasks_1
        private void NameOftasks_Clicked_1(object sender, System.EventArgs e)
        {
            AllPages_NewLayout();
            return;
        }
        #endregion

        #region NameOftasks_2
        private void NameOftasks_Clicked_2(object sender, System.EventArgs e)
        {
            AllPages_NewLayout();
            return;
        }
        #endregion

        #region NewItem
        private Label NewLabel()
        {
            return new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Title, typeof(Label))
            };
        }

        private Button NewButton(string textOnButton)
        {
            return new Button
            {
                VerticalOptions = LayoutOptions.Center,
                Text = textOnButton
            };
        }

        private StackLayout NewLayoutNagolosi()
        {
            return new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(30, 24, 30, 24),
                Spacing = 10
            };
        }
        #endregion
    }
}