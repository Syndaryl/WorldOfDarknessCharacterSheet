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
    }
    public interface ITemporaryValueTrait
    {
        BoundedInt TemporaryValue { get; set; }
    }
    public interface IRatingTrait
    {
        BoundedInt Rating { get; set; }
    }
}
