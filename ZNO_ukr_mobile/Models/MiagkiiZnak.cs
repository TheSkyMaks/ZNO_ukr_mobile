using System;
using System.Collections.Generic;
using System.Text;

namespace ZNO_ukr_mobile.Models
{
    class MiagkiiZnak
    {
        public List<MiagkiiZnak> Slova { get; set; }

        public string Slovo;
        public string Otvet;
        public bool IsWithMiagkiiZnak;

        public MiagkiiZnak(string slovo, string otvet, bool isWithMiagkiiZnak)
        {
            Slovo = slovo;
            Otvet = otvet;
            IsWithMiagkiiZnak = isWithMiagkiiZnak;
        }

        public void SpisokSlov()
        {
            Slova = new List<MiagkiiZnak>
            {
                new MiagkiiZnak("Різ..ба", "Різьба", true),
                new MiagkiiZnak("Українс..кий", "Український", true),
                new MiagkiiZnak("Компан..йон", "Компаньйон", true),
                new MiagkiiZnak("Трет..яков", "Третьяков", true),
                new MiagkiiZnak("Скрин..ка", "Скринька", true),
                new MiagkiiZnak("Луц..к", "Луцьк", true),
                new MiagkiiZnak("Т.. мяний", "Тьмяний", true),
                new MiagkiiZnak("Піч..", "Піч", false),
                new MiagkiiZnak("Воротар..", "Воротар", false),
                new MiagkiiZnak("Гір..кий", "Гіркий", false),
                new MiagkiiZnak("Перевір..", "Перевір", false),
                new MiagkiiZnak("Дз..вякнути", "Дзвякнути", false),
                new MiagkiiZnak("Велитенс...кий", "Велетенський", true),
                new MiagkiiZnak("Ул..яна", "Уляна", false),
                new MiagkiiZnak("Чотир..ма", "Чотирма", false),
                //new MiagkiiZnak("", "", true),
            };
        }
    }
}