using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace OOTPiSP_3
{
    [Serializable]
    [XmlInclude(typeof(MTB)), XmlInclude(typeof(Hybrid)), XmlInclude(typeof(CityBike))]
    [XmlInclude(typeof(BMX)), XmlInclude(typeof(RoadBike)), XmlInclude(typeof(KidsBike))]
    public abstract class Bicycle
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string ReleaseYear { get; set; }
        public string Color { get; set; }
        public string WheelsDiameter { get; set; }
        [NonSerialized]
        public List<string> FieldNames;

        protected void AddGeneralFieldNames()
        {
            FieldNames = new List<string>();
            FieldNames.Add("Name");
            FieldNames.Add("ReleaseYear");
            FieldNames.Add("Color");
            FieldNames.Add("WheelsDiameter");
        }

        public void InitialiseGeneralFields(List<TextBox> textBoxes)
        {
            Name = textBoxes[0].Text;
            ReleaseYear = textBoxes[1].Text;
            Color = textBoxes[2].Text;
            WheelsDiameter = textBoxes[3].Text;
        }

        public abstract void InitialiseSpecialFields(List<TextBox> textBoxes);
        public abstract void KeepValuesFromObjects(List<TextBox> textBoxes);
    }
}
