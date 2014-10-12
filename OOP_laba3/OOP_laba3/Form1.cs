using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using OOP_Laba3;

namespace OOP_laba3
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, Type> dictionaryObjects;
        private readonly List<Transport> transports = new List<Transport>();

        public Form1()
        {
            InitializeComponent();

            dictionaryObjects = new Dictionary<string, Type>();
            string pluginsPath = Directory.GetCurrentDirectory() + "\\Objects";
            string[] libraryFiles = Directory.GetFiles(pluginsPath, "*.dll", SearchOption.AllDirectories);
            foreach (string lib in libraryFiles)
            {
                Assembly asm = Assembly.LoadFile(lib);
                Type obj = asm.GetTypes().FirstOrDefault(x => x.IsSubclassOf(typeof (Transport)));
                if (obj != null)
                {
                    dictionaryObjects.Add(obj.Name, obj);
                    comboBoxObjects.Items.Add(obj.Name);
                }
            }
            if (comboBoxObjects.Items.Count > 0)
            {
                comboBoxObjects.SelectedIndex = 0;
            }

            propertyGrid.CommandsVisibleIfAvailable = true;
            propertyGrid.Text = "Property Grid";

            Controls.Add(propertyGrid);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        { 
            var transport =
                (Transport) Activator.CreateInstance(dictionaryObjects[comboBoxObjects.SelectedItem.ToString()]);
            transports.Add(transport);
            comboBoxTransports.Items.Clear();
            foreach (Transport transp in transports)
            {
                comboBoxTransports.Items.Add(transp.Name);
            }
        }

        private void comboBoxTransports_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = transports[comboBoxTransports.SelectedIndex - 1];
        }
    }
}