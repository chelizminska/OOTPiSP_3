using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOTPiSP_3
{
    [Serializable]
    public class KidsBike: Bicycle
    {
        public string Weight { get; set; }

        public KidsBike()
        {
            this.Type = "KidsBike";
            AddGeneralFieldNames();
            FieldNames.Add("Weight");
        }

        public override void InitialiseSpecialFields(List<TextBox> textBoxes)
        {
            Weight = textBoxes[4].Text;
        }

        public override void KeepValuesFromObjects(List<TextBox> textBoxes)
        {
            textBoxes[0].Text = this.Name;
            textBoxes[1].Text = this.ReleaseYear;
            textBoxes[2].Text = this.Color;
            textBoxes[3].Text = this.WheelsDiameter;
            textBoxes[4].Text = this.Weight;
        }
    }
}
