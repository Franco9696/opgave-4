using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ModelLib.Model
{
    public class Bog
    {
        private string _forfatter;
        private int _sidetal;
        private string _isbn13;
        public string Titel { get; set; }

        public Bog(string titel, string forfatter, int sidetal, string isbn13)
        {
            Titel = titel;
            Forfatter = forfatter;
            Sidetal = sidetal;
            Isbn13 = isbn13;
        }

        public Bog()
        {

        }


        public string Forfatter
        {
            get => _forfatter;
            set
            {               
                if (value.Length < 2) throw new ArgumentException();
                _forfatter = value;
            }

        }

        public int Sidetal
        {
            get => _sidetal;
            set
            {
                if (value <= 4) throw new ArgumentOutOfRangeException();
                if (value >= 1000) throw new ArgumentOutOfRangeException();
                _sidetal = value;
            }
        }

        public string Isbn13
        {
            get => _isbn13;

            set

            {
                if (value.Length == 13) _isbn13 = value;
                else throw new ArgumentOutOfRangeException();
                _isbn13 = value;
            }
        }
    }
}



