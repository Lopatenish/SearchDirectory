using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml.Linq;
using System.Threading;

namespace SearchDirectory
{
    public partial class Form1 : Form
    {
        //путь для файла сохранения
        private readonly string saveFileDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SearchDirectory/settings");
        private XDocument xdoc; //переменная для данных с файла сохранения
        private string pathSearch; //переменная для пути до репозитория поиска
        private DateTime date; //переменная для количества времени, потраченных на поиск
        private bool isPause = false;
        public Form1()
        {
            InitializeComponent();
            SavedDataInit();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void SavedDataInit() //метод для считывания данных из файла сохранений
        {
            if (!File.Exists(saveFileDir)) //если файла нет, создаем его
            {
                pathSearch = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
                Directory.CreateDirectory(Path.GetDirectoryName(saveFileDir));
                xdoc = new XDocument(new XElement("save", new XElement("path", pathSearch), new XElement("regex", "")));
                xdoc.Save(saveFileDir);
            }
            else
            {
                xdoc = XDocument.Load(saveFileDir);
                pathSearch = xdoc.Element("save").Element("path").Value;
            }
            folderBrowserDialog1.SelectedPath = pathSearch;
            textBoxDirectory.Text = pathSearch;
            textBoxRegex.Text = xdoc.Element("save").Element("regex").Value;
        }

        private void buttonBrowse_Click(object sender, EventArgs e) //метод для выбора репозитория по нажатию на кнопку
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathSearch = folderBrowserDialog1.SelectedPath;
                textBoxDirectory.Text = pathSearch;

                //сохранение данных в файл
                xdoc.Element("save").Element("path").SetValue(pathSearch);
                xdoc.Save(saveFileDir);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e) //событие по нажатию на кнопки "Поиск" и "Отмена"
        {
            Button button = (Button)sender;
            switch (button.Tag)
            {
                case "search": //Если нажата кнопка "Поиск", начинается поиск
                    isPause = false;
                    Search();
                    break; 
                case "cancel": //Если нажата кнопка "Отмена", поиск приостанавливается
                    if(timer.Enabled)
                    {
                        isPause = true;
                        buttonCancel.Tag = "continue";
                        buttonCancel.Text = "Продолжить";
                    }
                    break;
                case "continue":
                    isPause = false;
                    buttonCancel.Tag = "cancel";
                    buttonCancel.Text = "Отмена";
                    break;
            }
        }

        private void Search() //метод для поиска файлов в репозитории
        {
            labelTime.Text = "0";
            timer.Start();
            try
            {
                date = new DateTime(0, 0);
                Regex regex = new Regex(textBoxRegex.Text);

                //запись в массив всех файлов из репозитория
                string[] files = Directory.GetFiles(pathSearch, "*", SearchOption.AllDirectories);
                treeViewFolder.Nodes.Clear();
                labelCountFound.Text = "0";
                labelCountAll.Text = "0";
                for(int i = 0; i < files.Length; i++)
                {
                    if (isPause)
                        i--;
                    else
                    {
                        int count;
                        int buf = pathSearch.Length;
                        string rootPath = files[i].Remove(0, buf + 1);
                        labelFolderChecked.Text = files[i];

                        //проверка, продходит ли файл под регулярное выражение
                        if (regex.IsMatch(Path.GetFileName(rootPath)))
                        {
                            //Добавление подходящего файла в treeView
                            treeViewFolder.Invoke(new Action<TreeNodeCollection>((nodes) => BuildTree(nodes, rootPath)), treeViewFolder.Nodes);
                            count = int.Parse(labelCountFound.Text) + 1;
                            labelCountFound.Text = count.ToString();
                        }
                        count = int.Parse(labelCountAll.Text) + 1;
                        labelCountAll.Text = count.ToString();
                    }
                }
                foreach (var file in files)
                {
                    
                }
                if (labelCountFound.Text == "0")
                {
                    treeViewFolder.Invoke(new Action<string>((none) => treeViewFolder.Nodes.Add(none)), "Нет элементов");
                }
                timer.Stop();

                //сохранение данных в файл
                xdoc.Element("save").Element("regex").SetValue(textBoxRegex.Text);
                xdoc.Save(saveFileDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                timer.Stop();
                MessageBox.Show("Данные заданы неверно. Попробуйте еще раз", "Ошибка!");
            }
        }

        private void BuildTree(TreeNodeCollection nodes, string path) //метод для добавления файла в treeview
        {
            var childs = nodes;
            foreach(var part in path.Split('\\'))
            {
                var found = childs.Find(part.ToLower(), false);
                childs = (found.Length > 0) ? found[0].Nodes : childs.Add(part.ToLower(), part).Nodes;
            }
        }

        private void timer_Tick(object sender, EventArgs e) //обновление времени поиска
        {
            date = date.AddMilliseconds(1);
            labelTime.Text = date.ToString("mm:ss:fff");
        }
    }
}
