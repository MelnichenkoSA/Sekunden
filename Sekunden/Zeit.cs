using System;
using System.Collections.Generic;
using System.Text;

namespace Sekunden
{
    class Zeit
    {
        private int sekunden;
        private int minuten;
        private int stunden;
        private int tagen;

        public Zeit (int sek)
        {
            sekunden = sek % 60;
            int tmpminuten = (sek / 60);
            minuten = tmpminuten % 60;
            int tmpstunden = tmpminuten / 60;
            stunden = tmpstunden % 24;
            tagen = tmpstunden / 24;

        }
        public void Drucken ()
        {
            Console.WriteLine($"Дни: {tagen}, Часы: {stunden}, Минуты: {minuten}, Секунды: {sekunden}");
        }
    }
}
