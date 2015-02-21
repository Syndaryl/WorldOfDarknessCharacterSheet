using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using StackOverflow.IO;

namespace Games.RPG.WoDCharacterData
{
    [XmlRoot("WoDCharacter",
              Namespace = "http://www.white-wolf.com"
              )]
    public class WoDCharacter
    {
        [XmlElement("TraitGroups")]
        public List<TraitGroup> TraitGroups { get; set; }
        private string SourceFile { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Graphic")]
        public string Graphic { get; set; }

        public WoDCharacter()
        {
            TraitGroups = new List<TraitGroup>();
        }

        public WoDCharacter(string FromFile)
        {
            this.SourceFile = FromFile;
            Load(SourceFile);
        }

        public void Save(string ToFile)
        {
            System.IO.File.WriteAllText(ToFile, Save());
        }

        public string Save()
        {
            if (this == null)
            {
                return string.Empty;
            }
            try
            {
                var xmlserializer = new System.Xml.Serialization.XmlSerializer(typeof(WoDCharacter));
                var stringWriter  = new StringWriterWithEncoding(Encoding.UTF8);

                var settings = new XmlWriterSettings
                {
                    Encoding = new UTF8Encoding(true),
                    Indent = true,
                    OmitXmlDeclaration = false,
                    NewLineHandling = NewLineHandling.Replace
                };
                using (var writer = System.Xml.XmlWriter.Create(stringWriter, settings))
                {
                    try
                    {
                        xmlserializer.Serialize(writer, this);
                        return stringWriter.ToString();
                    }
                    catch(Exception e)
                    {
                        return string.Empty;
                    }
                }
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }
        public static WoDCharacter Load(string FileName)
        {
            using (var stream = System.IO.File.OpenRead(FileName))
            {
                try
                {
                var serializer = new XmlSerializer(typeof(WoDCharacter));
                return serializer.Deserialize(stream) as WoDCharacter;
                }
                catch (Exception e)
                {
                    return new WoDCharacter();
                }
            }
        }
    }
}
