using Syndaryl.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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

        public void Text_TextChanged(object sender, EventArgs e) {
            this.Text = ((TextBox)sender).Text;
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

        public void Text_TextChanged(object sender, EventArgs e) {
            this.Text = ((TextBox)sender).Text;
        }
        
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlText()]
        //[XmlElement("TextTrait")]
        //[XmlAttribute("TextTrait")]
        public string Text { get; set; }
    }

    public class UnnamedTextRating : Trait, ITextTrait, IRatingTrait
    {
        public UnnamedTextRating()
            : base()
        {
            Text = string.Empty;
            Bounded<int> Rating = new Bounded<int>();
        }

        public UnnamedTextRating(string Text, int Rating)
            : base()
        {
            this.Text = Text;
            this.Rating = new Bounded<int>(Rating);
        }

        public void Text_TextChanged(object sender, EventArgs e) {
            this.Text = ((TextBox)sender).Text;
        }

        public void boundControl_Update(object sender, NameTextRatingEventArgs e) {
            Text = e.TraitText;
            Rating.Value = e.Value;
        }
        //[XmlText()]
        [XmlElement("Text")]
        public string Text { get; set; }

        [XmlElement("Rating")]
        public Bounded<int> Rating { get; set; }
    }

    public class NameTextRating : Trait, INamedTrait,  ITextTrait, IRatingTrait
    {
        public NameTextRating() : base()
        {
            Name = string.Empty;
            Text = string.Empty;
            Bounded<int> Rating = new Bounded<int>();
        }

        public NameTextRating(string Name, string Text, int Rating) : base()
        {
            this.Name = Name;
            this.Text = Text;
            this.Rating = new Bounded<int>(Rating);
        }

        public NameTextRating(string Name, string Text, int Rating, int Minimum, int Maximum)
        {
            // TODO: Complete member initialization
            this.Name = Name;
            this.Text = Text;
            this.Rating = new Bounded<int> (Rating, minimum: Minimum, maximum: Maximum);
        }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        //[XmlText()]
        [XmlElement("Text")]
        public string Text { get; set; }  

        [XmlElement("Rating")]
        public Bounded<int> Rating { get; set; }




        public void Text_TextChanged(object sender, EventArgs e) {
            this.Text = ((TextBox)sender).Text;
        }
        public void boundControl_Update(object sender, NameTextRatingEventArgs e)
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
        public Bounded<int> TemporaryValue
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
            this.Rating = new Bounded<int>();
            this.TemporaryValue = new Bounded<int>();
        }
        public NamedRatingWithTempValue(Bounded<int> Rating, Bounded<int> Temporary, string Name="")
            : base()
        {
            this.Name = Name;
            this.Rating = Rating;
            this.TemporaryValue = Temporary;
        }

        public NamedRatingWithTempValue(string Name, int Rating, int Temporary, int Minimum, int Maximum) {
            // TODO: Complete member initialization
            this.Name = Name;
            this.Rating = new Bounded<int>(Rating, Minimum, Maximum);
            this.TemporaryValue = new Bounded<int>(Temporary, Minimum, Maximum);
        }
        public void boundControl_Update(object sender, NameTextRatingEventArgs e) {
            //Text = e.TraitText;
            Rating.Value = e.Value;
        }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlElement("Rating")]
        public Bounded<int> Rating
        {
            get;
            set;
        }

        [XmlElement("TemporaryValue")]
        public Bounded<int> TemporaryValue
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
                }
                woundPenalty = value;
            }
        }
        private int woundPenalty = 0;

        public void Wound_Update(object sender, WoundStateChangeEventArgs e) {
            this.WoundState = (WoundStates)e.WoundState;
        }


        [XmlElement("Wound")]
        public WoundStates WoundState {
            get;
            set;
        }
    }

    public enum WoundStates { Unwounded=0, Bashing, Lethal, Aggravated };

}
