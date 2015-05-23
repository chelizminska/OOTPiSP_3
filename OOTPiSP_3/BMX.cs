using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOTPiSP_3
{
    [Serializable]
    public class BMX: Bicycle
    {
        public string Material { get; set; }
        public string Weight { get; set; }

        public BMX()
        {
            this.Type = "BMX";
            AddGeneralFieldNames();
            FieldNames.Add("Material");
            FieldNames.Add("Weight");
        }

        public override void InitialiseSpecialFields(List<TextBox> textBoxes)
        {
            Material = textBoxes[4].Text;
            Weight = textBoxes[5].Text;
        }

        public override void KeepValuesFromObjects(List<TextBox> textBoxes)
        {
            textBoxes[0].Text = this.Name;
            textBoxes[1].Text = this.ReleaseYear;
            textBoxes[2].Text = this.Color;
            textBoxes[3].Text = this.WheelsDiameter;
            textBoxes[4].Text = this.Material;
            textBoxes[5].Text = this.Weight;
        }
    }
}
