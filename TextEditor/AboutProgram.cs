using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace NotepadCSharp
{
    /// <summary>
    ///     Summary description for About.
    /// </summary>
    public class AboutProgram : Form
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container components = null;

        private Button button1;
        private Label label1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private TemplateMethodDispose tMethod;

        public AboutProgram()
        {
            InitializeComponent();
            tMethod = new TemplateMethodDispose();
        }

        #region
        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof (AboutProgram));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notepad C# 2016 All rights reserved";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(144, 120);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(152, 23);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.notepadcsharp.com";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // About
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(312, 182);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About Notepad C#";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            //Добавляем блок для обработки исключений - по разным причинам 
            //пользователь может не получить доступа к ресурсу.
            try
            {
                //Вызываем метод VisitLink, определенный ниже
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Unable to open link that was clicked.");
            }
        }

        //Создаем метод VisitLink
        private void VisitLink()
        {
            // Изменяем цвет посещенной ссылки, программно 
            //обращаясь к свойству LinkVisited элемента LinkLabel 
            linkLabel1.LinkVisited = true;
            //Вызываем метод Process.Start method  для запуска браузера, 
            //установленного по умолчанию и открытия ссылки
            Process.Start("http://www.notepadcsharp.com");
        }
    }
}