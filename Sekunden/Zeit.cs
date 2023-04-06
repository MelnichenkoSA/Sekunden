using System;
using System.Collections.Generic;
using System.Text;

namespace Sekunden
{
    class Zeit
    {
        private int sek;
        private int sekunden { get => sek % 60; }
        private int minuten { get =>(sek / 60) % 60; }
        private int stunden { get => ((sek / 60) / 60) % 24; }
        private int tagen { get => ((sek / 60) / 60) / 24; }

        public Zeit (int sek)
        {
            this.sek = sek;
        }
        public static Zeit operator + (Zeit a, Zeit b)
        {
            int sek = a.sek + b.sek;
            return new Zeit(sek);
        }
        public static Zeit operator -(Zeit a, Zeit b)
        {
            int sek = a.sek - b.sek;
            return new Zeit(sek);
        }
        public static Zeit operator *(Zeit a, Zeit b)
        {
            int sek = a.sek * b.sek;
            return new Zeit(sek);
        }
        public static Zeit operator /(Zeit a, Zeit b)
        {
            int sek = a.sek / b.sek;
            return new Zeit(sek);
        }
        public static Zeit operator ++(Zeit a)
        {
            int sek = a.sek ++;
            return new Zeit(sek);
        }
        public static Zeit operator --(Zeit a)
        {
            int sek = a.sek--;
            return new Zeit(sek);
        }
        public static bool operator ==(Zeit a, Zeit b)
        {
            return a.sek == b.sek;
        }
        public static bool operator !=(Zeit a, Zeit b)
        {
            return a.sek != b.sek;
        }
        public static bool operator >(Zeit a, Zeit b)
        {
            return a.sek > b.sek;
        }
        public static bool operator <(Zeit a, Zeit b)
        {
            return a.sek < b.sek;
        }
        public override string ToString()
        {
            return $"Дни: {tagen}, Часы: {stunden:00}, Минуты: {minuten:00}, Секунды: {sekunden:00}";
        }
    }
}
