using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ZNO_ukr_mobile.Models;

namespace ZNO_ukr_mobile.Views
{
    public partial class AboutPage : ContentPage
    {
        #region Variables
        private StackLayout LayoutOfTask;
        private int ModeOfTask;
        private Label Word_label;
        private Label ResultOfAnswer;
        private Label WordAnswer;
        private Button CheckAnswer;
        private Button NextWord;
        private Button AllTasks;

        private Entry IsAnswerTrueCheck_Entry;

        private Button TrueAnswer;
        #endregion

        #region AllPages        
        public AboutPage()
        {
            InitializeComponent();
            AllPages_NewLayout();
        }
       
        internal void AllPages_NewLayout()
        {
            var AllPages_Layout = NewStackLayout();

            var Nagolosi_tasks = NewButton("Наголоси");
            Nagolosi_tasks.Clicked += Nagolosi_tasks_Clicked;
            AllPages_Layout.Children.Add(Nagolosi_tasks);

            AllPages_Layout.Children.Add(NewLabel());
            var MiagkiiZnak_button = NewButton("М'який знак");
            MiagkiiZnak_button.Clicked += MiagkiiZnak_tasks_Clicked;
            AllPages_Layout.Children.Add(MiagkiiZnak_button);

            AllPages_Layout.Children.Add(NewLabel());
            var ApostrofTask = NewButton("Апострофи");
            ApostrofTask.Clicked += ApostrofTask_Clicked;
            AllPages_Layout.Children.Add(ApostrofTask);

            Content = AllPages_Layout;
        }

        private void AllTasks_OnButtonClicked(object sender, System.EventArgs e)
        {
            AllPages_NewLayout();
        }
        #endregion

        #region Nagolosi
        private List<NagolosiSlova> Nagolosi_Slova;
        private NagolosiSlova Nagolosi_SlovoNaOtvet;

        private void Nagolosi_tasks_Clicked(object sender, EventArgs e)
        {
            ModeOfTask = 1;
            LayoutOfTask = NewStackLayout();
            IsAnswerTrueCheck_Entry = new Entry
            {
                Placeholder = "Номер наголошеного складу",
                ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                Keyboard = Keyboard.Numeric,
                VerticalOptions = LayoutOptions.Center
            };
            Content = ViewCompiler();
            CheckAnswer.Clicked += Nagolosi_CheckAnswer_OnButtonClicked;
            NextWord.Clicked += Nagolosi_NextWord_OnButtonClicked;
            var nagolosiSlova = new NagolosiSlova(default, default, default);
            nagolosiSlova.SpisokSlov();
            Nagolosi_Slova = nagolosiSlova.Slova;
            Nagolosi_NewWord();
        }

        private void Nagolosi_NewWord()
        {
            ClearLabels();
            var index = new Random();
            Nagolosi_SlovoNaOtvet = Nagolosi_Slova[index.Next(Nagolosi_Slova.Count)];
            Word_label.Text = Nagolosi_SlovoNaOtvet.Slovo;
        }

        private void Nagolosi_NextWord_OnButtonClicked(object sender, System.EventArgs e)
        {
            Nagolosi_NewWord();
        }

        private void Nagolosi_CheckAnswer_OnButtonClicked(object sender, System.EventArgs e)
        {
            if (!int.TryParse(IsAnswerTrueCheck_Entry.Text, out int Result))
            {
                ResultOfAnswer.Text = "Помилка вводу відповіді. Необхідно вводити натуральне число. :(";
            }
            else
            {
                CheckAnswerOfTask(Result == Nagolosi_SlovoNaOtvet.NumberSklada, Nagolosi_SlovoNaOtvet.Otvet);                
            }
        }
        #endregion

        #region MiagkiiZnak
        private List<MiagkiiZnak> MiagkiiZnak_Slova;
        private MiagkiiZnak MiagkiiZnak_SlovoNaOtvet;

        private void MiagkiiZnak_tasks_Clicked(object sender, EventArgs e)
        {
            ModeOfTask = 2;
            LayoutOfTask = NewStackLayout();
            Content = ViewCompiler();
            CheckAnswer.Clicked += MiagkiiZnak_false_CheckAnswer_OnButtonClicked;
            NextWord.Clicked += MiagkiiZnak_NextWord_OnButtonClicked;
            TrueAnswer.Clicked += MiagkiiZnak_true_CheckAnswer_OnButtonClicked;
            var miagkiiZnak = new MiagkiiZnak(default, default, default);
            miagkiiZnak.SpisokSlov();
            MiagkiiZnak_Slova = miagkiiZnak.Slova;
            MiagkiiZnak_NewWord();
        }

        private void MiagkiiZnak_NextWord_OnButtonClicked(object sender, System.EventArgs e)
        {
            MiagkiiZnak_NewWord();
        }

        private void MiagkiiZnak_NewWord()
        {
            ClearLabels();
            var index = new Random();
            MiagkiiZnak_SlovoNaOtvet = MiagkiiZnak_Slova[index.Next(MiagkiiZnak_Slova.Count)];
            Word_label.Text = MiagkiiZnak_SlovoNaOtvet.Slovo;
        }

        private void MiagkiiZnak_false_CheckAnswer_OnButtonClicked(object sender, System.EventArgs e)
        {
            CheckAnswerOfTask(false == MiagkiiZnak_SlovoNaOtvet.IsWithMiagkiiZnak, MiagkiiZnak_SlovoNaOtvet.Otvet);
        }

        private void MiagkiiZnak_true_CheckAnswer_OnButtonClicked(object sender, System.EventArgs e)
        {
            CheckAnswerOfTask(true == MiagkiiZnak_SlovoNaOtvet.IsWithMiagkiiZnak, MiagkiiZnak_SlovoNaOtvet.Otvet);
        }
        #endregion

        #region ApostrofTask
        private List<Apostrof> ApostrofTask_Slova;
        private Apostrof ApostrofTask_SlovoNaOtvet;

        private void ApostrofTask_Clicked(object sender, EventArgs e)
        {
            ModeOfTask = 2;
            LayoutOfTask = NewStackLayout();
            Content = ViewCompiler();
            CheckAnswer.Clicked += ApostrofTask_false_CheckAnswer_OnButtonClicked;
            NextWord.Clicked += ApostrofTask_NextWord_OnButtonClicked;
            TrueAnswer.Clicked += ApostrofTask_true_CheckAnswer_OnButtonClicked;
            var apostrofTask = new Apostrof(default, default, default);
            apostrofTask.SpisokSlov();
            ApostrofTask_Slova = apostrofTask.Slova;
            ApostrofTask_NewWord();
        }

        private void ApostrofTask_NextWord_OnButtonClicked(object sender, System.EventArgs e)
        {
            ApostrofTask_NewWord();
        }

        private void ApostrofTask_NewWord()
        {
            ClearLabels();
            var index = new Random();
            ApostrofTask_SlovoNaOtvet = ApostrofTask_Slova[index.Next(ApostrofTask_Slova.Count)];
            Word_label.Text = ApostrofTask_SlovoNaOtvet.Slovo;
        }

        private void ApostrofTask_false_CheckAnswer_OnButtonClicked(object sender, System.EventArgs e)
        {
            CheckAnswerOfTask(false == ApostrofTask_SlovoNaOtvet.IsWithApostrof, ApostrofTask_SlovoNaOtvet.Otvet);
        }

        private void ApostrofTask_true_CheckAnswer_OnButtonClicked(object sender, System.EventArgs e)
        {
            CheckAnswerOfTask(true == ApostrofTask_SlovoNaOtvet.IsWithApostrof, ApostrofTask_SlovoNaOtvet.Otvet);
        }
        #endregion

        #region Logic
        private void ClearLabels()
        {
            Word_label.Text = "";
            ResultOfAnswer.Text = "";
            WordAnswer.Text = "";
        }

        private StackLayout ViewCompiler()
        {
            Word_label = NewLabel();
            LayoutOfTask.Children.Add(Word_label);

            switch (ModeOfTask)
            {
                case 1:
                    LayoutOfTask.Children.Add(IsAnswerTrueCheck_Entry);
                    CheckAnswer = NewButton("Перевірити відповідь");
                    break;
                case 2:
                    TrueAnswer = NewButton("Так");
                    TrueAnswer.BackgroundColor = Color.Green;
                    LayoutOfTask.Children.Add(TrueAnswer);
                    CheckAnswer = NewButton("Ні");
                    CheckAnswer.BackgroundColor = Color.Red;
                    break;
                default:
                    AllPages_NewLayout();
                    break;
            }

            LayoutOfTask.Children.Add(CheckAnswer);

            ResultOfAnswer = NewLabel();
            LayoutOfTask.Children.Add(ResultOfAnswer);

            NextWord = NewButton("Наступне слово");
            LayoutOfTask.Children.Add(NextWord);
            
            WordAnswer = NewLabel();
            LayoutOfTask.Children.Add(WordAnswer);

            AllTasks = NewButton("Всі вправи");
            AllTasks.Clicked += AllTasks_OnButtonClicked;
            LayoutOfTask.Children.Add(AllTasks);

            return LayoutOfTask;
        }        

        private void CheckAnswerOfTask(bool result, string otvet)
        {
            ResultOfAnswer.Text = result ? "Вірно :)" : "Помилка :(";
            WordAnswer.Text = otvet;
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

        private StackLayout NewStackLayout()
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