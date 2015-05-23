using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOTPiSP_3
{
    [Serializable]
    public class Hybrid: Bicycle
    {
        public string NumberOfSpeeds { get; set; }
        public string Material { get; set; }

        public Hybrid()
        {
            this.Type = "Hybrid";
            AddGeneralFieldNames();
            FieldNames.Add("NumberOfSpeeds");
            FieldNames.Add("Material");
        }

        public override void InitialiseSpecialFields(List<TextBox> textBoxes)
        {
            NumberOfSpeeds = textBoxes[4].Text;
            Material = textBoxes[5].Text;
        }

        public override void KeepValuesFromObjects(List<TextBox> textBoxes)
        {
            textBoxes[0].Text = this.Name;
            textBoxes[1].Text = this.ReleaseYear;
            textBoxes[2].Text = this.Color;
            textBoxes[3].Text = this.WheelsDiameter;
            textBoxes[4].Text = this.NumberOfSpeeds;
            textBoxes[5].Text = this.Material;
        }
    }
}
