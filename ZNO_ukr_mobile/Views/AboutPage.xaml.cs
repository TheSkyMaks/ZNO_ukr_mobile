using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZNO_ukr_mobile.Views
{
    public partial class AboutPage : ContentPage
    {
        private List<NagolosiSlova> Slova;
        private NagolosiSlova SlovoNaOtvet;
        public AboutPage()
        {
            InitializeComponent();
            Start();
        }

        public void Start()
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
            Word_label.Text = SlovoNaOtvet.Slovo;
            ResultOfAnswer.Text = "";
            WordAnswer.Text = "";
        }

        private void CheckAnswer_OnButtonClicked(object sender, System.EventArgs e)
        {
            if(!int.TryParse(NumberSklada.Text, out int Result))
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
    }
}