using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOTPiSP_3
{
    class InputComponentsDrawer
    {
        List<Label> FieldLabels { get; set; }
        public List<TextBox> Fields { get; set; }
        int StartLabelPositionX { get; set; }
        int StartTextBoxPositionX { get; set; }
        int StartComponentPositionY { get; set; }
        int LabelSize { get; set; }
        int TextBoxSize { get; set; }

        public InputComponentsDrawer()
        {
            StartLabelPositionX = 20;
            StartTextBoxPositionX = 120;
            StartComponentPositionY = 100;
            LabelSize = 100;
            TextBoxSize = 100;
            FieldLabels = new List<Label>();
            Fields = new List<TextBox>();
        }

        private void DrawFieldLabels(List<string> fieldNames)
        {
            int ComponentPositionY = StartComponentPositionY;
            foreach (var name in fieldNames)
            {
                var item = new Label { Top = ComponentPositionY+=25, Left = StartLabelPositionX, Width = LabelSize, Text = name };
                FieldLabels.Add(item);
                Form.ActiveForm.Controls.Add(item);
            }
        }

        private void DrawFields(int fieldCount)
        {
            int ComponentPositionY = StartComponentPositionY;
            for (int i = 0; i < fieldCount; i++)
            {
                var item = new TextBox { Top = ComponentPositionY+=25, Left = StartTextBoxPositionX, Width = TextBoxSize };
                Fields.Add(item);
                Form.ActiveForm.Controls.Add(item);
            }
        }

        public void DrawComponents(List<string> fieldNames)
        {
            DrawFieldLabels(fieldNames);
            DrawFields(fieldNames.Count);
        }

        public void ClearComponents()
        {
            foreach (var control in FieldLabels)
                Form.ActiveForm.Controls.Remove(control);
            FieldLabels.Clear();
            foreach (var control in Fields)
                Form.ActiveForm.Controls.Remove(control);
            Fields.Clear();
        }
    }
}
