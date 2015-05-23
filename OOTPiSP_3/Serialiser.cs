using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace OOTPiSP_3
{
    public partial class Serialiser : Form
    {

        List<Bicycle> BicycleList = new List<Bicycle>();
        List<Bicycle> AccessoryBicycleList = new List<Bicycle>();
        InputComponentsDrawer Drawer = new InputComponentsDrawer();

        public Serialiser()
        {
            InitializeComponent();
        }

        private void buttonSerialise_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Bicycle>));
            using (FileStream fs = new FileStream("bicycle.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, BicycleList);
            }
        }

        private void buttonDeserialise_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("bicycle.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Bicycle>));
                BicycleList.Clear();
                listBox_Objects.Items.Clear();
                BicycleList = (List<Bicycle>)formatter.Deserialize(fs);    
                foreach(var bicycleObject in BicycleList)
                {
                    listBox_Objects.Items.Add(bicycleObject);
                }
            }
        }

        private Bicycle GetTypeOfBicycle(string type)
        {
            Bicycle item = new BMX();
            if (type == "BMX")
            {
                item = new BMX();
            }
            if (type == "CityBike")
            {
                item = new CityBike();
            }
            if (type == "Hybrid")
            {
                item = new Hybrid();
            }
            if (type == "KidsBike")
            {
                item = new KidsBike();
            }
            if (type == "MTB")
            {
                item = new MTB();
            }
            if (type == "RoadBike")
            {
                item = new RoadBike();
            }
            return item;
        }

        private void button_AddObject_Click(object sender, EventArgs e)
        {
            RadioButton checkedButton =  Serialiser.ActiveForm.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            Bicycle item = GetTypeOfBicycle(checkedButton.Text);
            item.InitialiseGeneralFields(Drawer.Fields);
            item.InitialiseSpecialFields(Drawer.Fields);
            BicycleList.Add(item);
            listBox_Objects.Items.Add(item);
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            button_Save.Visible = false;
            Drawer.ClearComponents();
            RadioButton checkedButton = Serialiser.ActiveForm.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            Bicycle item = GetTypeOfBicycle(checkedButton.Text);
            Drawer.DrawComponents(item.FieldNames);
        }

        private void listBox_Objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Drawer.ClearComponents();
            Bicycle item = (Bicycle)listBox_Objects.SelectedItem;
            Bicycle buf = GetTypeOfBicycle(item.Type);
            Drawer.DrawComponents(buf.FieldNames);
            item.KeepValuesFromObjects(Drawer.Fields);
            button_Save.Visible = true;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Bicycle buf = (Bicycle)listBox_Objects.SelectedItem;
            buf.InitialiseGeneralFields(Drawer.Fields);
            buf.InitialiseSpecialFields(Drawer.Fields);
        }

    }
}
