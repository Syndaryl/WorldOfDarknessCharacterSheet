using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Games.RPG.WoDCharacterData
{
    public interface INamedTrait
    {
        [XmlAttribute("Name")]
        string Name { get; set; }
    }
    public interface ITextTrait
    {
        string Text { get; set; }

        void Text_TextChanged(object sender, EventArgs e);
    }
    public interface ITemporaryValueTrait
    {
        Bounded<int> TemporaryValue { get; set; }
    }
    public interface IRatingTrait
    {
        Bounded<int> Rating { get; set; }
        void slider_Update(object sender, Games.RPG.WoDSheet.NameTextRatingEventArgs e);
    }
}
