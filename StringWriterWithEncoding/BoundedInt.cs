using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Games.RPG.WoDCharacterData
{
    /// <summary>
    /// A bounded generic object - this object has its possible range of values limited within the range normally available to its datatype.
    /// The generic object type must be IComparable and IEquatable - it must be an object that can be said to be "equal to", "less than" 
    /// or "greater than" another object of the same type.
    /// 
    /// The bounded generic object can be converted between itself and the generic type, and compared against itself and the generic type.
    /// 
    /// Bounded objects can be serialized to XML - the value will become the text value of the node, and the Min and Max will be attributes.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Bounded<T> : 
        IComparable<T>, IComparable<Bounded<T>>, IEquatable<T>, IEquatable<Bounded<T>>
        where T:IComparable<T>, IEquatable<T>  {
        #region Constructors
        public Bounded() {
            Value = default(T);
            Min = default(T);
            Max = default(T);
        }

        /// <summary>
        /// Constructor of most use
        /// </summary>
        /// <param name="initial">Initial value of this bounded object - will be immediately bounded by the minimum and maximum Properties even if not specified</param>
        /// <param name="minimum">Minimum value that this object is allowed to be set to (uses default(T) if not specified)</param>
        /// <param name="maximum">Maximum value that this object is allowed to be set to (uses default(T) if not specified)</param>
        public Bounded(T initial, T minimum = default(T), T maximum = default(T)) {
            min = minimum;
            max = maximum;
            this.Value = initial;
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// The actual value of the bounded object. This is the value used in comparisons. . XMLSerialized as #text
        /// </summary>
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

        /// <summary>
        /// The minimum value of the bounded object. XMLSerialized as @Min
        /// </summary>
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

        /// <summary>
        /// The maximum value of the bounded object. XMLSerialized as @Max
        /// </summary>
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

        #region Helper Methods

        ///// <summary>
        ///// For Mike so he can get all LINQy with it.
        ///// </summary>
        ///// <typeparam name="T">The generic type of the object</typeparam>
        ///// <param name="initial"></param>
        ///// <param name="function"></param>
        ///// <returns></returns>
        //public static Bounded<T> Bind<T>(this Bounded<T> initial, Func<T, Bounded<T>> function)
        //    where T : IEquatable<T>, IComparable<T> {
        //    return function(initial.Value);
        //}

        #endregion Helper Methods

        #region Operators and Interfaces
        /// <summary>
        /// implicit Bounded to T conversion operator
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static implicit operator T(Bounded<T> d)
        {
            return d.Value;  // implicit conversion
        }

        /// <summary>
        /// implicit T to Bounded conversion operator
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static implicit operator Bounded<T>(T d)
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
}
