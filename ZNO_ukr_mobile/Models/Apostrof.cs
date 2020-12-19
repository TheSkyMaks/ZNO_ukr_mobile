using System;
using System.Collections.Generic;
using System.Text;

namespace ZNO_ukr_mobile.Models
{
    class Apostrof
    {
        public List<Apostrof> Slova { get; set; }

        public string Slovo;
        public string Otvet;
        public bool IsWithApostrof;

        public Apostrof(string slovo, string otvet, bool isWithApostrof)
        {
            Slovo = slovo;
            Otvet = otvet;
            IsWithApostrof = isWithApostrof;
        }

        public void SpisokSlov()
        {
            Slova = new List<Apostrof>
            {
                new Apostrof("св...ято", "свято", false),
                new Apostrof("цв...ях", "цвях", false),
                new Apostrof("ін...єкція", "ін'єкція", true),
                new Apostrof("кон...юнктура", "кон'юнктура", true),
                new Apostrof("кон...юнктивіт", "кон'юнктивіт", true),
                new Apostrof("ад...ютант", "ад'ютант", true),
                new Apostrof("тьм...яний", "тьмяний", false),
                new Apostrof("В...язьма", "Вязьма", false),
                new Apostrof("П...ятигорськ", "П’ятигорськ", true),
                new Apostrof("бур...ян", "бур’ян", true),
                new Apostrof("бур...яний", "буряний", false),
                new Apostrof("пів...яблука", "пів’яблука", true),
                new Apostrof("пан...європейський", "пан’європейський", true),
                new Apostrof("дит...ясла", "дит’ясла", true),
                //new Apostrof("", "", true),
            };
        }        
    }
}
