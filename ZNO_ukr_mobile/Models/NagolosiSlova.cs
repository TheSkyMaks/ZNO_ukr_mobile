﻿using System.Collections.Generic;

namespace ZNO_ukr_mobile
{
    internal class NagolosiSlova
    {
        public List<NagolosiSlova> Slova { get; set; }

        public string Slovo;
        public string Otvet;
        public int NumberSklada;

        public NagolosiSlova(string slovo, string otvet, int numberSklada)
        {
            Slovo = slovo;
            Otvet = otvet;
            NumberSklada = numberSklada;
        }

        public void SpisokSlov()
        {
            Slova = new List<NagolosiSlova>
            {
                new NagolosiSlova("агрономiя", "агронОмiя", 3),
                //new NagolosiSlova("алфавiт", "алфАвIт", 0), //Подвійний наголос
                new NagolosiSlova("аркушик", "Аркушик", 1),
                new NagolosiSlova("асиметрiя", "асиметрIя", 4),
                new NagolosiSlova("багаторазовий", "багаторазОвий", 5),
                new NagolosiSlova("безпринципний", "безпринцИпний", 3),
                new NagolosiSlova("бешкет", "бЕшкет", 1),
                new NagolosiSlova("благовiст", "блАговiст", 1),
                new NagolosiSlova("близький", "близькИй", 2),
                new NagolosiSlova("болотистий", "болотИстий", 3),
                new NagolosiSlova("бородавка", "борОдавка", 2),
                new NagolosiSlova("босонiж", "босОнiж", 2),
                new NagolosiSlova("боязнь", "боЯзнь", 2),
                new NagolosiSlova("бурштиновий", "бурштинОвий", 3),
                new NagolosiSlova("бюлетень", "бюлетЕнь", 3),
                new NagolosiSlova("ваги", "вАги", 1),
                new NagolosiSlova("вантажiвка", "вантажIвка", 3),
                new NagolosiSlova("веснянИй", "веснЯнИй", 2),
               // new NagolosiSlova("вигода", "вИгода (користь), вигОда (зручнiсть) ", 0),  //Подвійний наголос
                new NagolosiSlova("видання", "видАння", 2),
                new NagolosiSlova("визвольний", "визвОльний", 2),
                new NagolosiSlova("вимога", "вимОга", 2),
                new NagolosiSlova("випадок", "вИпадок", 1),
                new NagolosiSlova("виразний", "вирАзний", 2),
                new NagolosiSlova("висiти", "вИсiти", 1),
                new NagolosiSlova("витрата", "вИтрата", 1),
                new NagolosiSlova("вишиваний", "вишИваний", 2),
                new NagolosiSlova("вiдвезти", "вiдвезтИ", 3),
                new NagolosiSlova("вiдвести", "вiдвестИ", 3),
                new NagolosiSlova("вiдгомiн", "вIдгомiн", 1),
                new NagolosiSlova("вiднести", "вiднестИ", 3),
               // new NagolosiSlova("вiдомiсть", "вIдомiсть (список), вiдОмiсть (повiдомлення, данi, популярнiсть)", 0),  //Подвійний наголос
                new NagolosiSlova("вiршi", "вIршi", 1),
                new NagolosiSlova("вiршовий", "вiршовИй", 3),
                new NagolosiSlova("вiтчим", "вiтчИм", 2),
                new NagolosiSlova("гальмо", "гальмО", 2),
                new NagolosiSlova("гальма", "гАльма", 1),
                new NagolosiSlova("глядач", "глядАч", 2),
                new NagolosiSlova("горошина", "горошИна", 3),
                new NagolosiSlova("граблi", "граблI", 2),
                new NagolosiSlova("гуртожиток", "гуртОжиток", 2),
                new NagolosiSlova("данина", "данИна", 2),
                new NagolosiSlova("дано", "дАно", 1),
                new NagolosiSlova("дециметр", "децимЕтр", 3),
                new NagolosiSlova("дещиця", "дЕщиця", 1),
                new NagolosiSlova("де-юре", "де-Юре", 2),
                new NagolosiSlova("джерело", "джерелО", 3),
                new NagolosiSlova("дивлячись", "дИвлячись", 1),
                new NagolosiSlova("дичавiти", "дичАвiти", 2),
                new NagolosiSlova("дiалог", "дiалОг", 3),
                new NagolosiSlova("добовий", "добовИй", 3),
                new NagolosiSlova("добуток", "добУток", 2),
                new NagolosiSlova("довезти", "довезтИ", 3),
                new NagolosiSlova("довести", "довестИ", 3),
                new NagolosiSlova("довiдник", "довIдник", 2),
                new NagolosiSlova("догмат", "дОгмат", 1),
                new NagolosiSlova("донести", "донестИ", 3),
                new NagolosiSlova("донька", "дОнька", 1),
                new NagolosiSlova("дочка", "дочкА", 2),
                new NagolosiSlova("дрова", "дрОва", 1),
                new NagolosiSlova("експерт", "експЕрт", 2),
                new NagolosiSlova("єретик", "єретИк", 3),
                new NagolosiSlova("жалюзi", "жалюзI", 3),
                new NagolosiSlova("завдання", "завдАння", 2),
                new NagolosiSlova("завезти", "завезтИ", 3),
                new NagolosiSlova("завести", "завестИ", 3),
                new NagolosiSlova("завжди", "зАвжди", 1),
                new NagolosiSlova("завчасу", "завчасУ", 3),
                new NagolosiSlova("загадка", "зАгадка", 1),
                new NagolosiSlova("заiржавiлий", "заiржАвiлий", 3),
                new NagolosiSlova("заiржавiти", "заiржАвiти", 3),
                new NagolosiSlova("закiнчити", "закiнчИти", 3),
                new NagolosiSlova("закладка", "зАкладка (у книзi)", 1),
                new NagolosiSlova("закрутка", "зАкрутка", 1),
                new NagolosiSlova("залишити", "залишИти", 3),
                new NagolosiSlova("замiжня", "замIжня", 2),
                new NagolosiSlova("занести", "занестИ", 3),
                new NagolosiSlova("запонка", "зАпонка", 1),
                new NagolosiSlova("заробiток", "заробIток", 3),
                new NagolosiSlova("заставка", "зАставка", 1),
                new NagolosiSlova("застiбка", "зАстiбка", 1),
                new NagolosiSlova("застопорити", "застОпорити", 2),
                new NagolosiSlova("звисока", "звИсока", 1),
                new NagolosiSlova("здалека", "здАлека", 1),
                new NagolosiSlova("зiбрання", "зiбрАння", 2),
                new NagolosiSlova("зобразити", "зобразИти", 3),
                new NagolosiSlova("зозла", "зОзла", 1),
                new NagolosiSlova("зрання", "зрАння", 1),
                new NagolosiSlova("зручний", "зрУчний", 1),
                new NagolosiSlova("зубожiння", "зубОжiння", 2),
                new NagolosiSlova("iндустрiя", "iндУстрiя", 2),
                new NagolosiSlova("камбала", "кАмбала", 1),
                new NagolosiSlova("каталог", "каталОг", 3),
                new NagolosiSlova("квартал", "квартАл", 2),
                new NagolosiSlova("кишка", "кИшка", 1),
                new NagolosiSlova("кiлометр", "кiломЕтр", 3),
                new NagolosiSlova("кiнчити", "кiнчИти", 2),
                new NagolosiSlova("колесо", "кОлесо", 1),
                new NagolosiSlova("колiя", "кОлiя", 1),
               // new NagolosiSlova("копчений", "кОпчений (дiєприкметник), копчЕний (прикметник)", 0),  //Подвійний наголос
                new NagolosiSlova("корисний", "корИсний", 2),
                new NagolosiSlova("косий", "кОсий", 1),
                new NagolosiSlova("котрий", "котрИй", 2),
                new NagolosiSlova("крицевий", "крицЕвий", 2),
                new NagolosiSlova("кроїти", "крОїти", 1),
                new NagolosiSlova("кропива", "кропивА", 3),
                new NagolosiSlova("кулiнарiя", "кулiнАрiя", 3),
                new NagolosiSlova("курятина", "кУрятина", 1),
                new NagolosiSlova("лате", "лАте", 1),
                new NagolosiSlova("листопад", "листопАд", 3),
                new NagolosiSlova("лiтопис", "лiтОпис", 2),
                new NagolosiSlova("люстро", "лЮстро", 1),
              //  new NagolosiSlova("мабуть", "мАбУть", 0),  //Подвійний наголос
                new NagolosiSlova("магiстерський", "магiстЕрський", 3),
                new NagolosiSlova("маркетинг", "мАркетинг", 1),
                new NagolosiSlova("мережа", "мерЕжа", 2),
                new NagolosiSlova("металургiя", "металУргiя", 3),
                new NagolosiSlova("мiлiметр", "мiлiмЕтр", 3),
                new NagolosiSlova("навчання", "навчАння", 2),
                new NagolosiSlova("нанести", "нанестИ", 3),
                new NagolosiSlova("напiй", "напIй", 2),
                new NagolosiSlova("наскрiзний", "нАскрiзний", 1),
                new NagolosiSlova("начинка", "нАчинка", 1),
                new NagolosiSlova("ненавидiти", "ненАвидiти", 2),
                new NagolosiSlova("ненависний", "ненАвисний", 2),
                new NagolosiSlova("ненависть", "ненАвисть", 2),
                new NagolosiSlova("нести", "нестИ", 2),
                new NagolosiSlova("нiздря", "нIздря", 1),
                new NagolosiSlova("новий", "новИй", 2),
                new NagolosiSlova("обiцянка", "обiцЯнка", 3),
                new NagolosiSlova("обрання", "обрАння", 2),
                new NagolosiSlova("обруч", "обрУч (iменник)", 2),
                new NagolosiSlova("одинадцять", "одинАдцять", 3),
                new NagolosiSlova("одноразовий", "одноразОвий", 4),
                new NagolosiSlova("ознака", "ознАка", 2),
                new NagolosiSlova("олень", "Олень", 1),
                new NagolosiSlova("оптовий", "оптОвий", 2),
                new NagolosiSlova("осетер", "осетЕр", 3),
                new NagolosiSlova("отаман", "отАман", 2),
                new NagolosiSlova("оцет", "Оцет", 1),
                new NagolosiSlova("павич", "павИч", 2),
                new NagolosiSlova("партер", "партЕр", 2),
                new NagolosiSlova("пекарський", "пЕкарський", 1),
                new NagolosiSlova("перевезти", "перевезтИ", 4),
                new NagolosiSlova("перевести", "перевестИ", 4),
                new NagolosiSlova("перекис", "перЕкис", 2),
                new NagolosiSlova("переляк", "перелЯк", 3),
                new NagolosiSlova("перенести", "перенестИ", 4),
                new NagolosiSlova("перепад", "перЕпад", 2),
                new NagolosiSlova("перепис", "перЕпис", 2),
                new NagolosiSlova("пiала", "пiалА", 3),
               // new NagolosiSlova("пiдданий", "пIдданий (дiєприкметник), пiддАний (iменник, iстота)", 0),  //Подвійний наголос
                new NagolosiSlova("пiдлiтковий", "пIдлiтковий", 1),
                new NagolosiSlova("пiзнання", "пiзнАння", 2),
                new NagolosiSlova("пiтний", "пiтнИй", 2),
                new NagolosiSlova("пiцерiя", "пiцЕрiя", 2),
                new NagolosiSlova("подруга", "пОдруга", 1),
                new NagolosiSlova("позначка", "пОзначка", 1),
                new NagolosiSlova("помилка", "пОмилка", 1),
                new NagolosiSlova("помiщик", "помIщик", 2),
                new NagolosiSlova("помовчати", "помОвчати", 2),
                new NagolosiSlova("поняття", "понЯття", 2),
                new NagolosiSlova("порядковий", "порядкОвий", 3),
                new NagolosiSlova("посерединi", "посерЕдинi", 3),
                new NagolosiSlova("привезти", "привезтИ", 3),
                new NagolosiSlova("привести", "привестИ", 3),
                new NagolosiSlova("приморозок", "прИморозок", 1),
                new NagolosiSlova("принести", "принестИ", 3),
                new NagolosiSlova("причiп", "прИчiп", 1),
                new NagolosiSlova("продiл", "прОдiл", 1),
                new NagolosiSlova("промiжок", "промIжок", 2),
                new NagolosiSlova("псевдонiм", "псевдонIм", 3),
                new NagolosiSlova("разом", "рАзом", 1),
                new NagolosiSlova("ремiнь", "рЕмiнь (пояс)", 1),
                new NagolosiSlova("решето", "рЕшето", 1),
                new NagolosiSlova("ринковий", "рИнковий", 1),
                new NagolosiSlova("рiвнина", "рiвнИна", 2),
                new NagolosiSlova("роздрiбний", "роздрiбнИй", 3),
                new NagolosiSlova("розпiрка", "рОзпiрка", 1),
                new NagolosiSlova("рукопис", "рукОпис", 2),
                new NagolosiSlova("русло", "руслО", 2),
                new NagolosiSlova("сантиметр", "сантимЕтр", 3),
                new NagolosiSlova("свердло", "свЕрдло", 1),
                new NagolosiSlova("середина", "серЕдина", 2),
                new NagolosiSlova("сеча", "сЕча", 1),
                new NagolosiSlova("симетрiя", "симетрIя", 3),
                new NagolosiSlova("сiльськогосподарський", "сiльськогосподАрський", 5),
                new NagolosiSlova("сiмдесят", "сiмдесЯт", 3),
                new NagolosiSlova("слина", "слИна", 1),
                new NagolosiSlova("соломинка", "соломИнка", 3),
                new NagolosiSlova("статуя", "стАтуя", 1),
                new NagolosiSlova("стовiдсотковий", "стовiдсОтковий", 3),
                new NagolosiSlova("стрибати", "стрибАти", 2),
                new NagolosiSlova("текстовий", "текстовИй", 3),
                new NagolosiSlova("течiя", "течiЯ", 3),
                new NagolosiSlova("тигровий", "тИгровий", 1),
                new NagolosiSlova("тисовий", "тисОвий", 2),
                new NagolosiSlova("тiм’яний", "тiм’янИй", 3),
                new NagolosiSlova("травестiя", "травестIя", 3),
                new NagolosiSlova("тризуб", "тризУб", 2),
                new NagolosiSlova("тулуб", "тУлуб", 1),
                new NagolosiSlova("український", "украЇнський", 3),
                new NagolosiSlova("уподобання", "уподОбання", 3),
                new NagolosiSlova("урочистий", "урочИстий", 3),
                new NagolosiSlova("усерединi", "усерЕдинi", 3),
                new NagolosiSlova("фартух", "фартУх", 2),
                new NagolosiSlova("фаховий", "фаховИй", 3),
                new NagolosiSlova("феномен", "фенОмен", 2),
                new NagolosiSlova("фольга", "фОльга", 1),
                new NagolosiSlova("форзац", "фОрзац", 1),
              //  new NagolosiSlova("хаос", "хАос (у мiфологiї: стихiя), хаОс (безлад)", 0),  //ПодвIйний наголос
                new NagolosiSlova("царина", "цАрина", 1),
                new NagolosiSlova("цемент", "цемЕнт", 2),
                new NagolosiSlova("центнер", "цЕнтнер", 1),
                new NagolosiSlova("цiнник", "цiннИк", 2),
                new NagolosiSlova("чарiвний", "чарiвнИй", 3),
                new NagolosiSlova("черговий", "черговИй", 3),
                new NagolosiSlova("читання", "читАння", 2),
                new NagolosiSlova("чорнозем", "чорнОзем", 2),
                new NagolosiSlova("чорнослив", "чорнОслив", 2),
                new NagolosiSlova("чотирнадцять", "чотирнАдцять", 3),
                new NagolosiSlova("шляхопровiд", "шляхопровIд", 4),
                new NagolosiSlova("шовковий", "шовкОвий", 2),
                new NagolosiSlova("шофер", "шофЕр", 2),
                new NagolosiSlova("щелепа", "щЕлепа", 1),
                new NagolosiSlova("щипцi", "щИпцi", 1),
                new NagolosiSlova("щодобовий", "щодобовИй", 4),
                new NagolosiSlova("ярмарковий", "ярмаркОвий", 3),
                //new NagolosiSlova("", "", 0),
            };
        }
    }
}