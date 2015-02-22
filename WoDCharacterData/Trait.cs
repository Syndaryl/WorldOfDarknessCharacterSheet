using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Games.RPG.WoDCharacterData
{
    [XmlInclude(typeof(NamedText)), XmlInclude(typeof(NameTextRating)), XmlInclude(typeof(NamedRatingWithTempValue))]
    public abstract class Trait
    {
    }

    public class TextTrait : Trait, ITextTrait
    {
        public TextTrait()
            : base()
        {
            Text = string.Empty;
        }

        public TextTrait(string Text = "")
            : base()
        {
            this.Text = Text;
        }

        [XmlText()]
        //[XmlElement("TextTrait")]
        //[XmlAttribute("TextTrait")]
        public string Text { get; set; }
    }

    public class NamedText : Trait, INamedTrait,  ITextTrait
    {
        public NamedText() : base()
        {
            Name = string.Empty;
            Text = string.Empty;
        }

        public NamedText(string Name, string Text = "")
            : base()
        {
            this.Name = Name;
            this.Text = Text;
        }
        
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlText()]
        //[XmlElement("TextTrait")]
        //[XmlAttribute("TextTrait")]
        public string Text { get; set; }
    }

    public class TextRating : Trait, ITextTrait, IRatingTrait
    {
        public TextRating()
            : base()
        {
            Text = string.Empty;
            BoundedInt Rating = new BoundedInt();
        }

        public TextRating(string Text, int Rating)
            : base()
        {
            this.Text = Text;
            this.Rating = new BoundedInt(Rating);
        }

        //[XmlText()]
        [XmlElement("Text")]
        public string Text { get; set; }

        [XmlElement("Rating")]
        public BoundedInt Rating { get; set; }
    }

    public class NameTextRating : Trait, INamedTrait,  ITextTrait, IRatingTrait
    {
        public NameTextRating() : base()
        {
            Name = string.Empty;
            Text = string.Empty;
            BoundedInt Rating = new BoundedInt();
        }

        public NameTextRating(string Name, string Text, int Rating) : base()
        {
            this.Name = Name;
            this.Text = Text;
            this.Rating = new BoundedInt(Rating);
        }

        public NameTextRating(string Name, string Text, int Rating, int Minimum, int Maximum)
        {
            // TODO: Complete member initialization
            this.Name = Name;
            this.Text = Text;
            this.Rating = new BoundedInt (Rating, Minimum: Minimum, Maximum: Maximum);
        }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        //[XmlText()]
        [XmlElement("Text")]
        public string Text { get; set; }  

        [XmlElement("Rating")]
        public BoundedInt Rating { get; set; }



        public void slider_Update(object sender, Games.RPG.WoDSheet.NameTextRatingEventArgs e)
        {
            Text = e.TraitText;
            Rating.Value = e.Value;
        }
    }

    public class NamedTempValue : Trait, INamedTrait, ITemporaryValueTrait
    {

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlElement("TemporaryValue")]
        public BoundedInt TemporaryValue
        {
            get;
            set;
        }
    }


    public class NamedRatingWithTempValue : Trait, INamedTrait, IRatingTrait, ITemporaryValueTrait
    {
        public NamedRatingWithTempValue() : base()
        {
            this.Name = string.Empty;
            this.Rating = new BoundedInt();
            this.TemporaryValue = new BoundedInt();
        }
        public NamedRatingWithTempValue(BoundedInt Rating, BoundedInt Temporary, string Name="")
            : base()
        {
            this.Name = Name;
            this.Rating = Rating;
            this.TemporaryValue = Temporary;
        }

        public NamedRatingWithTempValue(string Name, int Rating, int Temporary, int Minimum, int Maximum) {
            // TODO: Complete member initialization
            this.Name = Name;
            this.Rating = new BoundedInt(Rating, Minimum, Maximum);
            this.TemporaryValue = new BoundedInt(Temporary, Minimum, Maximum);
        }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlElement("Rating")]
        public BoundedInt Rating
        {
            get;
            set;
        }

        [XmlElement("TemporaryValue")]
        public BoundedInt TemporaryValue
        {
            get;
            set;
        }
    }

    public class WoundRating : Trait, INamedTrait {
        public WoundRating() : base(){}
        public WoundRating(string Name, int WoundPenalty=0, WoundStates WoundState = WoundStates.Unwounded) { this.Name = Name; this.WoundPenalty = WoundPenalty; this.WoundState = WoundState; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("WoundPenalty")]
        public int WoundPenalty {
            get {
                return woundPenalty;
            }
            set {
                if (value > 0) {
                    value = 0;
                    woundPenalty = value;
                }
            }
        }
        private int woundPenalty = 0;

        [XmlElement("WoundState")]
        public WoundStates WoundState {
            get;
            set;
        }
    }

    public enum WoundStates { Unwounded=0, Bashing, Lethal, Aggravated };

}
