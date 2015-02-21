using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Games.RPG.WoDCharacterData
{
    enum TraitType
    {
        String,
        Score,
        ScoreTally,
        Tally
    }
    public class TraitGroup
    {

        public TraitGroup()
        {
            this.Children = new List<Trait>();
            this.ChildGroups = new List<TraitGroup>();
            this.ColumnLabels = new List<string>();
            this.SpanColumns = 3;
            this.Orientation = "LeftToRight";
            this.Name = string.Empty;
        }
        public TraitGroup(string Name=null)
        {
            this.Name = Name;
            this.SpanColumns = 3;
            this.ColumnLabels = new List<string>();
            this.Children = new List<Trait>();
            this.ChildGroups = new List<TraitGroup>();
            this.Orientation = "LeftToRight";
        }
        public TraitGroup(string Name=null, int SpanColumns=3)
        {
            this.Name = Name;
            this.SpanColumns = SpanColumns;
            this.ColumnLabels = new List<string>();
            this.Children = new List<Trait>();
            this.ChildGroups = new List<TraitGroup>();
            this.Orientation = "LeftToRight";
        }

        public TraitGroup(List<string> ColumnLabels, string Name=null, int SpanColumns = 3)
        {
            // TODO: Complete member initialization
            this.Name = Name;
            this.SpanColumns = SpanColumns;
            this.ColumnLabels = ColumnLabels;
            this.ChildGroups = ChildGroups;
            this.Children = new List<Trait>();
            this.Orientation = "LeftToRight";
        }

        public TraitGroup(List<string> ColumnLabels, List<TraitGroup> ChildGroups, List<Trait> Children, string Name="", int SpanColumns = 3, string Orientation = "LeftToRight" )
        {
            // TODO: Complete member initialization
            this.Name = Name;
            this.SpanColumns = SpanColumns;
            this.ColumnLabels = ColumnLabels;
            this.ChildGroups = ChildGroups;
            this.Children = Children;
            this.Orientation = Orientation;
        }

        #region Public Properties

        [XmlAttribute]
        public string Orientation { get; set; }

        [XmlArray("DisplayColumnLabels")]
        public List<string> ColumnLabels;

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlElement("DisplayColumns")]
        public int SpanColumns { get; set; }

        //[XmlElement("ChildGroups")]

        [XmlArray("ChildGroups")]
        [XmlArrayItem("TraitGroup")]
        public List<TraitGroup> ChildGroups { get; set; }
           
        [XmlArrayItem(ElementName = "Trait",
           IsNullable = true,
           Type = typeof(Trait)),
        XmlArrayItem(ElementName = "Text",
           IsNullable = true,
           Type = typeof(TextTrait)),
        XmlArrayItem(ElementName = "NamedText",
           IsNullable = true,
           Type = typeof(NamedText)),
        XmlArrayItem(ElementName = "NameTextRating",
           IsNullable = true,
           Type = typeof(NameTextRating)),
        XmlArrayItem(ElementName = "TextRating",
           IsNullable = true,
           Type = typeof(TextRating)),
        XmlArrayItem(ElementName = "RatingWithTempValue",
           IsNullable = true,
           Type = typeof(RatingWithTempValue))
        ]

        [XmlArray("Traits")]
        //[XmlArray("Children")]
        //[XmlArrayItem("Trait")]
        public List<Trait> Children { get; set; }

        #endregion


    }
}
