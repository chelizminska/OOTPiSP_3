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


namespace OOTPiSP_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car { Name = "Audi A6", MaxSpeed = 240 };
            XmlSerializer formatter = new XmlSerializer(typeof(Car));

            using (FileStream fs = new FileStream("cars.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, car);
            }

      /*      using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                Person[] newPersons = (Person[])formatter.Deserialize(fs);

                foreach (Person p in newPersons)
                {
                    Console.WriteLine("Имя: {0} --- Возраст: {1}", p.Name, p.Age);
                }
            }
        */
        }
    }
}
