using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Games.RPG.WoDCharacterData
{
    public class BoundedInt
    {
        private int value = 1;

        [XmlText()]
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if (value < Min)
                    value = Min;
                if (value > Max)
                    value = Max;
                this.value = value;
            }
        }
        int min = 1;
        [XmlAttribute("Min")]
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                    value = 0;
                if (value > Max)
                    value = Max;
                this.min = value;
            }
        }

        int max = 5;

        public BoundedInt(int Rating, int Minimum=1, int Maximum = 5)
        {
            this.Min = Minimum;
            this.Max = Maximum;
            this.Value = Rating;
        }

        public BoundedInt()
        {
        }
        [XmlAttribute("Max")]
        public int Max
        {
            get
            {
                return max;
            }
            set
            {
                if (value < Min)
                    value = Min;
                if (value < 1)
                    value = 1;
                this.max = value;
            }
        }
    }
}
