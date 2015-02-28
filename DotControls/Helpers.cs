using System;
using System.IO;
using System.Web.Script.Serialization; // Add reference: System.Web.Extensions
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Syndaryl.Games.CharacterGeneration.WorldOfDarkness.Helpers
{
    public static class ParseHelpers
    {
        private static JavaScriptSerializer json;
        private static JavaScriptSerializer JSON { get { return json ?? (json = new JavaScriptSerializer()); } }

        public static Stream ToStream(this string @this)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(@this);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }


        public static T ParseXML<T>(this string @this) where T : class
        {
            var reader = XmlReader.Create(@this.Trim().ToStream(), new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Document });
            return new XmlSerializer(typeof(T)).Deserialize(reader) as T;
        }

        public static T ParseJSON<T>(this string @this) where T : class
        {
            return JSON.Deserialize<T>(@this.Trim());
        }

        public static void FillRowStyles(this TableLayoutPanel @this, SizeType type, float rowHeight)
        {
            for (int i = 0; i < @this.RowCount; i++)
            {
                if (@this.RowStyles.Count <= i)
                {
                    @this.RowStyles.Add(new RowStyle(type, rowHeight));
                }
                else
                {
                    @this.RowStyles[i].SizeType = type;
                    @this.RowStyles[i].Height = rowHeight;
                }
            }
        }

        public static void FillColumnStyles(this TableLayoutPanel @this, SizeType type, float colWidth)
        {
            for (int i = 0; i < @this.ColumnCount; i++)
            {
                if (@this.ColumnStyles.Count <= i)
                {
                    @this.ColumnStyles.Add(new ColumnStyle(type, colWidth));
                }
                else
                {
                    @this.ColumnStyles[i].SizeType = type;
                    @this.ColumnStyles[i].Width = colWidth;
                }
            }
        }
    }
}
