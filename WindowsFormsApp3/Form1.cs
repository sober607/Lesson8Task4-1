using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;
using System.Configuration;
using System.Collections.Specialized;
using Microsoft.Win32;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private ColorDialog chooseColorDialog = new ColorDialog();
        private ColorDialog chooseColorDialog1 = new ColorDialog();
        private FontDialog chooseFontStyleDialog = new FontDialog();
        public Form1()
        {
            InitializeComponent();
            buttonChooseColor.Click += new EventHandler(OnClickChooseColor);
            try
            {
                if (ReadSettings() == false)
                {
                    MessageBox.Show("В файле конфигурации нет информации...");
                }
                

                this.StartPosition = FormStartPosition.CenterScreen;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        void OnClickChooseColor(object Sender, EventArgs e)
        {
            if (chooseColorDialog.ShowDialog() == DialogResult.OK)
                this.BackColor = chooseColorDialog.Color;
        }


        bool ReadSettings()
        {
            // Загрузка настроек по парам [ключ]-[значение].
            NameValueCollection allAppSettings = ConfigurationManager.AppSettings;
            if (allAppSettings.Count < 1) { return (false); }

            // Восстановление состояния:
            //1. Цвет фона.
            int red = Convert.ToInt32(allAppSettings["BackGroundColor.R"]);
            int green = Convert.ToInt32(allAppSettings["BackGroundColor.G"]);
            int blue = Convert.ToInt32(allAppSettings["BackGroundColor.B"]);

            //2. Цвет текста
            int redText = Convert.ToInt32(allAppSettings["TextColor.R"]);
            int greedText = Convert.ToInt32(allAppSettings["TextColor.G"]);
            int blueText = Convert.ToInt32(allAppSettings["TextColor.B"]);

            string fontName = Convert.ToString(allAppSettings["TextStyleFont.Name"]);
            float textSize = Convert.ToSingle(allAppSettings["TextStyleFont.Size"]);
            FontStyle fontstyle = GetStyleType();
            // определение стиля
            FontStyle GetStyleType ()
            {
                if (allAppSettings["TextStyleFont.Style"] == "Bold")
                {
                    return FontStyle.Bold;
                }
                else if (allAppSettings["TextStyleFont.Style"] == "Italic")
                {
                    return FontStyle.Italic;
                }
                else if (allAppSettings["TextStyleFont.Style"] == "Regular")
                {
                    return FontStyle.Regular;
                }
                else if (allAppSettings["TextStyleFont.Style"] == "Strikeout")
                {
                    return FontStyle.Strikeout;
                }
                else
                {
                    return FontStyle.Regular;
                }
            
            }
                

            // установка
            this.BackColor = Color.FromArgb(red, green, blue);
            label1.ForeColor= Color.FromArgb(redText, greedText, blueText);
            label1.Font= new Font(fontName, textSize, fontstyle);

            

            //4. Состояние окна.
            string winState = allAppSettings["Window.State"];
            
            this.WindowState = (FormWindowState)FormWindowState.Parse(WindowState.GetType(), winState);
            return (true);
        }
        void SaveSettings()
        {
            
            // Сохранение происходит при помощи работы с XML.
            XmlDocument doc = loadConfigDocument();

            // Открываем узел appSettings, в котором содержится перечень настроек.
            XmlNode node = doc.SelectSingleNode("//appSettings");

            // Массив ключей (создан для упрощения обращения к файлу конфигурации).
            string[] keys = new string[] {"BackGroundColor.R",
                                          "BackGroundColor.G",
                                          "BackGroundColor.B",
                                          "TextColor.R",
                                          "TextColor.G",
                                          "TextColor.B",
                                          "TextStyleFont.Name",
                                          "TextStyleFont.Size",
                                          "TextStyleFont.Style",

                                          "Window.State"};

            // Массив значений (создан для упрощения обращения к файлу конфигурации).
            string[] values = new string[] { BackColor.R.ToString(),
                                             BackColor.G.ToString(),
                                             BackColor.B.ToString(),
                                             label1.ForeColor.R.ToString(),
                                             label1.ForeColor.G.ToString(),
                                             label1.ForeColor.B.ToString(),
                                             label1.Font.Name.ToString(),
                                             label1.Font.Size.ToString(),
                                             label1.Font.Style.ToString(),

                                             WindowState.ToString() };

            // Цикл модификации файла конфигурации.
            for (int i = 0; i < keys.Length; i++)
            {
                // Обращаемся к конкретной строке по ключу.
                XmlElement element = node.SelectSingleNode(string.Format("//add[@key='{0}']", keys[i])) as XmlElement;

                // Если строка с таким ключем существует - записываем значение.
                if (element != null) { element.SetAttribute("value", values[i]); }
                else
                {
                    // Иначе: создаем строку и формируем в ней пару [ключ]-[значение].
                    element = doc.CreateElement("add");
                    element.SetAttribute("key", keys[i]);
                    element.SetAttribute("value", values[i]);
                    node.AppendChild(element);
                }
            }

            // Сохраняем результат модификации.
            doc.Save(Assembly.GetExecutingAssembly().Location + ".config");
            
        }

        private static XmlDocument loadConfigDocument()
        {
            XmlDocument doc = null;
            try
            {
                doc = new XmlDocument();
                doc.Load(Assembly.GetExecutingAssembly().Location + ".config");
                return doc;
            }
            catch (System.IO.FileNotFoundException e)
            {
                throw new Exception("No configuration file found.", e);
            }
        }

        private void button2chooseTextColor_Click(object sender, EventArgs e)
        {
            if (chooseColorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            label1.ForeColor = chooseColorDialog1.Color;
        }

        private void buttonFontParams_Click(object sender, EventArgs e)
        {
           if (chooseFontStyleDialog.ShowDialog() == DialogResult.Cancel)
           return;
            // установка шрифта
            label1.Font = chooseFontStyleDialog.Font;

            
        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
