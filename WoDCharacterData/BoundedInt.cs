using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Games.RPG.WoDCharacterData
{
    public class Bounded<T> : 
        IComparable<T>, IComparable<Bounded<T>>, IEquatable<T>, IEquatable<Bounded<T>>
        where T:IComparable<T>  {
        #region Constructors
        public Bounded<T>()
        {
        }

        public Bounded(T d)
        {
            this.Value = d;
        }
        #endregion Constructors

        #region Properties
        [XmlText()]
        public T Value {
            get {
                return value;
            }
            set {
                if (value.CompareTo(Min) < 0)
                    value = Min;
                if (value.CompareTo(Max) > 0)
                    value = Max;
                this.value = value;
            }
        }

        [XmlAttribute("Min")]
        public T Min {
            get {
                return min;
            }
            set {
                if (value.CompareTo(Max) > 0)
                    value = Max;
                this.min = value;
            }
        }

        [XmlAttribute("Max")]
        public T Max
        {
            get
            {
                return max;
            }
            set
            {
                if (value.CompareTo(Min) < 0 )
                    value = Min;
                this.max = value;
            }
        }
        #endregion Properties

        #region fields
        private T value;
        private T max;
        private T min;
        #endregion fields

        #region Operators and Interfaces
        public static implicit operator T(Bounded<T> d)  // implicit BoundedInt to int conversion operator
        {
            return d.Value;  // implicit conversion
        }
        public static implicit operator Bounded<T>(T d)  // implicit BoundedInt to int conversion operator
        {
            return new Bounded<T>(d);  // implicit conversion
        }
    
        int IComparable<T>.CompareTo(T other)
        {
 	        return Value.CompareTo(other);
        }

        int IComparable<Bounded<T>>.CompareTo(Bounded<T> other)
        {
 	        return Value.CompareTo(other.Value);
        }
    
        bool IEquatable<T>.Equals(T other)
        {
 	        return Value.Equals(other);
        }

        bool IEquatable<Bounded<T>>.Equals(Bounded<T> other)
        {
 	        return Value.Equals(other.Value);
        }
        #endregion
    }

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

        public static implicit operator int(BoundedInt d)  // implicit BoundedInt to int conversion operator
        {
            return d.Value;  // implicit conversion
        }
        public static implicit operator BoundedInt(int d)  // implicit BoundedInt to int conversion operator
        {
            return new BoundedInt(d);  // implicit conversion
        }

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
