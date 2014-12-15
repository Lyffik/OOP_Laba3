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
            var car = new Car();
            string str = car.GetType().ToString();
            Type type = Type.GetType(str);
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
            transport.Name = transport.GetType().ToString();
            string str = transport.Name;
            transport.Name = str.Remove(0, 10);
            transports.Add(transport);
            comboBoxTransports.Items.Clear();
            foreach (Transport transp in transports)
            {
                comboBoxTransports.Items.Add(transp.Name);
            }
            if (comboBoxTransports.Items.Count > 0)
            {
                comboBoxTransports.SelectedIndex = transports.Count - 1;
            }
        }

        private void comboBoxTransports_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = transports[comboBoxTransports.SelectedIndex];
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            saveFileDialog.RestoreDirectory = true;

            try
            {
                if (checkBoxSerializeList.Checked == false)
                {
                    Transport transport = transports[comboBoxTransports.SelectedIndex];
                    if (radioBtnBinary.Checked)
                    {
                        saveFileDialog.Filter = "Binary files (*.dat)|*.dat";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            Serialization.SaveAsBinaryFormat(transport,
                                saveFileDialog.FileName);
                        }
                    }
                    if (radioBtnSoap.Checked)
                    {
                        /*saveFileDialog.Filter = "All files (*.*)|*.*";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            Serialization.SaveAsIniFormat(transport,
                                saveFileDialog.FileName);
                        }*/
                    }
                    if (radioBtnXml.Checked)
                    {
                        saveFileDialog.Filter = "Xml files (*.xml)|*.xml";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            Serialization.SaveAsXmlFormat(transport,
                                saveFileDialog.FileName, dictionaryObjects);
                        }
                    }
                }
                else
                {
                    if (radioBtnBinary.Checked)
                    {
                        saveFileDialog.Filter = "Binary files (*.dat)|*.dat";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            Serialization.SaveListAsBinaryFormat(transports,
                                saveFileDialog.FileName);
                        }
                    }
                    if (radioBtnSoap.Checked)
                    {
                        saveFileDialog.Filter = "All files (*.*)|*.*";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            Serialization.SaveAsIniFormat(transports, saveFileDialog.FileName);
                        }
                    }
                    if (radioBtnXml.Checked)
                    {
                        saveFileDialog.Filter = "Xml files (*.xml)|*.xml";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            Serialization.SaveListAsXmlFormat(transports,
                                saveFileDialog.FileName, dictionaryObjects);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("Выберите сериализуемый объект");
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            openFileDialog.RestoreDirectory = true;
           // try
            {
                if (checkBoxSerializeList.Checked == false)
                {
                    Transport transport = null;
                    if (radioBtnBinaryDes.Checked)
                    {
                        openFileDialog.Filter = "Binary files (*.dat)|*.dat";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            transport = (Transport) Serialization.LoadFromBinaryFile(openFileDialog.FileName);
                        }
                    }
                    if (radioBtnSoapDes.Checked)
                    {
                        /*  openFileDialog.Filter = "All files (*.*)|*.*";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            /*transport = (Transport) Serialization.LoadFromSoapFile(openFileDialog.FileName);#1#
                        }*/
                    }
                    if (radioBtnXmlDes.Checked)
                    {
                        openFileDialog.Filter = "Xml files (*.xml)|*.xml";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            transport = Serialization.LoadFromXmlFile(openFileDialog.FileName, dictionaryObjects);
                        }
                    }
                    if (transport != null)
                    {
                        transports.Add(transport);
                        comboBoxTransports.Items.Add(transport.Name);
                        comboBoxTransports.SelectedIndex = comboBoxTransports.Items.Count - 1;
                    }
                }
                else
                {
                    List<Transport> deserializeTransports = null;
                    if (radioBtnBinaryDes.Checked)
                    {
                        openFileDialog.Filter = "Binary files (*.dat)|*.dat";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            deserializeTransports =
                                Serialization.LoadListFromBinaryFile(openFileDialog.FileName);
                        }
                    }
                    if (radioBtnSoapDes.Checked)
                    {
                        openFileDialog.Filter = "All files (*.*)|*.*";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            deserializeTransports =
                                Serialization.LoadFromIni(openFileDialog.FileName);
                        }
                    }
                    if (radioBtnXmlDes.Checked)
                    {
                        openFileDialog.Filter = "Xml files (*.xml)|*.xml";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            deserializeTransports = Serialization.LoadListFromXmlFile(openFileDialog.FileName,
                                dictionaryObjects);
                        }
                    }
                    if (deserializeTransports != null)
                    {
                        foreach (Transport transport in deserializeTransports)
                        {
                            transports.Add(transport);
                            comboBoxTransports.Items.Add(transport.Name);
                        }
                        comboBoxTransports.SelectedIndex = comboBoxTransports.Items.Count - 1;
                    }
                }
            }
           /* catch (Exception ex)
            {
                //MessageBox.Show("Десериализация не возможна!");
                MessageBox.Show(ex.ToString());
            }*/
        }


        private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            comboBoxTransports.Items[comboBoxTransports.SelectedIndex] =
                transports[comboBoxTransports.SelectedIndex].Name;
        }

        private void btnDeleteObject_Click(object sender, EventArgs e)
        {
            try
            {
                Transport transport = transports[comboBoxTransports.SelectedIndex];
                transports.Remove(transport);
                comboBoxTransports.Items.Clear();
                foreach (Transport transp in transports)
                {
                    comboBoxTransports.Items.Add(transp.Name);
                }
                comboBoxTransports.SelectedIndex = transports.Count - 1;
                if (transports.Count < 1)
                {
                    propertyGrid.SelectedObject = null;
                    comboBoxTransports.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите объект");
            }
        }
    }
}