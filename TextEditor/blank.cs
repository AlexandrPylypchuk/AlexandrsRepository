using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NotepadCSharp
{
    /// <summary>
    ///     Summary description for blank.
    /// </summary>
    public class Blank : Form, IHightlight
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container components = null;

        private string BufferText = "";
        private MenuItem cmnuCopy;
        private MenuItem cmnuCut;
        private MenuItem cmnuDelete;
        private MenuItem cmnuPaste;
        private MenuItem cmnuSelectAll;
        private ContextMenu contextMenu1;
        public string DocName = "";
        public bool IsSaved = false;
        private MainMenu mainMenu1;
        private MenuItem menuItem6;
        public RichTextBox richTextBox1;
        private StatusBarPanel sbAmount;
        private StatusBarPanel sbTime;
        private StatusBar statusBar1;
        private TemplateMethodDispose tMethod;

        public Blank()
        {
            InitializeComponent();
            tMethod = new TemplateMethodDispose();
            //Свойству Text панели sbTime устанавливаем системное время, 
            // конвертировав его в тип String
            sbTime.Text = Convert.ToString(DateTime.Now.ToLongTimeString());
            //В тексте всплывающей подсказки  выводим текущую дату
            sbTime.ToolTipText = Convert.ToString(DateTime.Today.ToLongDateString());
        }

        // Реализация паттерна стратегия
        public void Hightlight()
        {
            string[] str = {"int", "new", "bool", "for"};
            foreach (var s in str)
            {
                var i = 0;
                while (i <= richTextBox1.Text.Length - str.Length)
                {
                    //выделение цветом
                    i = richTextBox1.Text.IndexOf(s, i);
                    if (i < 0) break;
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = str.Length;
                    richTextBox1.SelectionColor = Color.CornflowerBlue;
                    i += str.Length;
                }
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.cmnuCut = new System.Windows.Forms.MenuItem();
            this.cmnuCopy = new System.Windows.Forms.MenuItem();
            this.cmnuPaste = new System.Windows.Forms.MenuItem();
            this.cmnuDelete = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.cmnuSelectAll = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.sbAmount = new System.Windows.Forms.StatusBarPanel();
            this.sbTime = new System.Windows.Forms.StatusBarPanel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            ((System.ComponentModel.ISupportInitialize) (this.sbAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.sbTime)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AllowDrop = true;
            this.richTextBox1.ContextMenu = this.contextMenu1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(292, 244);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);

            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.cmnuCut,
                this.cmnuCopy,
                this.cmnuPaste,
                this.cmnuDelete,
                this.menuItem6,
                this.cmnuSelectAll
            });
            // 
            // cmnuCut
            // 
            this.cmnuCut.Index = 0;
            this.cmnuCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.cmnuCut.Text = "Cu&t";
            this.cmnuCut.Click += new System.EventHandler(this.cmnuCut_Click);
            // 
            // cmnuCopy
            // 
            this.cmnuCopy.Index = 1;
            this.cmnuCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.cmnuCopy.Text = "&Copy";
            this.cmnuCopy.Click += new System.EventHandler(this.cmnuCopy_Click);
            // 
            // cmnuPaste
            // 
            this.cmnuPaste.Index = 2;
            this.cmnuPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.cmnuPaste.Text = "&Paste";
            this.cmnuPaste.Click += new System.EventHandler(this.cmnuPaste_Click);
            // 
            // cmnuDelete
            // 
            this.cmnuDelete.Index = 3;
            this.cmnuDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.cmnuDelete.Text = "&Delete";
            this.cmnuDelete.Click += new System.EventHandler(this.cmnuDelete_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.Text = "-";
            // 
            // cmnuSelectAll
            // 
            this.cmnuSelectAll.Index = 5;
            this.cmnuSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.cmnuSelectAll.Text = "Select &All";
            this.cmnuSelectAll.Click += new System.EventHandler(this.cmnuSelectAll_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 244);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[]
            {
                this.sbAmount,
                this.sbTime
            });
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(292, 22);
            this.statusBar1.TabIndex = 1;
            // 
            // sbAmount
            // 
            this.sbAmount.Text = "Amount of symbols";
            this.sbAmount.Width = 140;
            // 
            // sbTime
            // 
            this.sbTime.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sbTime.Text = "Time";
            this.sbTime.Width = 80;
            // 
            // blank
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusBar1);
            this.Menu = this.mainMenu1;
            this.Name = "blank";
            this.Text = "blank";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.blank_Closing);
            ((System.ComponentModel.ISupportInitialize) (this.sbAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.sbTime)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Вырезание текста
        public void Cut()
        {
            BufferText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }

        // Копирование текста
        public void Copy()
        {
            BufferText = richTextBox1.SelectedText;
        }

        // Вставка
        public void Paste()
        {
            richTextBox1.SelectedText = BufferText;
        }

        // Выделение всего текста - используем свойство SelectAll элемента управления RichTextBox 
        public void SelectAll()
        {
            richTextBox1.SelectAll();
        }

        // Удаление.
        public void Delete()
        {
            richTextBox1.SelectedText = "";
            BufferText = "";
        }

        //Создаем метод Open, в качестве параметра объявляем строку адреса  файла.
        public void Open(string OpenFileName)
        {
            //Если файл не выбран, возвращаемся назад (появится встроенное предупреждение)
            if (OpenFileName == "")
            {
            }
            //Создаем новый объект StreamReader и передаем ему переменную OpenFileName
            var sr = new StreamReader(OpenFileName);
            //Читаем весь файл и записываем его в richTextBox1
            richTextBox1.Text = sr.ReadToEnd();
            // Закрываем поток
            sr.Close();
            //Переменной DocName присваиваем адресную строку.
            DocName = OpenFileName;
        }

        private void cmnuCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void cmnuCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void cmnuPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void cmnuDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void cmnuSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        //Создаем метод Save, в качестве параметра объявляем строку адреса  файла.
        public void Save(string SaveFileName)
        {
            //Если файл не выбран, возвращаемся назад (появится встроенное предупреждение)
            if (SaveFileName == "")
            {
            }
            else
            {
                //Создаем новый объект StreamWriter и передаем ему переменную OpenFileName
                var sw = new StreamWriter(SaveFileName);
                //Содержимое richTextBox1 записываем в файл
                sw.WriteLine(richTextBox1.Text);
                //Закрываем поток
                sw.Close();
                //Устанавливаем в качестве имени документа название сохраненного файла
                DocName = SaveFileName;
            }
        }

        private void blank_Closing(object sender, CancelEventArgs e)
        {
            //Если переменная IsSaved имеет значение true, т. е документ новый документ 
            //был сохранен (Save As) или в открытом документе были сохранены изменения (Save) то выполняется условие
            if (IsSaved)
                //Появляется диалоговое окно, предлагающее сохранить документ.
                if (MessageBox.Show("Do you want save changes in " + DocName + "?",
                    "Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    //Если была нажата  кнопка Yes, вызываем метод Save
                {
                    Save(DocName);
                }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Свойству Text панели sbAmount устанавливаем надпись "Аmount of symbols " 
            //и длину  текста в RichTextBox.
            sbAmount.Text = "Аmount of symbols " + richTextBox1.Text.Length;
        }
    }
}