using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace NotepadCSharp
{
    public class MainForm : Form
    {
        //��������� ��� ����������� ������
        private readonly List<string> accemblyList;
        private ColorDialog colorDialog1;
        private IContainer components;
        private FontDialog fontDialog1;
        private ImageList imageList1;
        private MainMenu mainMenu1;
        private MenuItem menuItem1;
        private MenuItem menuItem12;
        private MenuItem menuItem2;
        private MenuItem menuItem3;
        private MenuItem menuItem4;
        private MenuItem menuItem5;
        private MenuItem menuItem6;
        private MenuItem mnuAbout;
        private MenuItem mnuArrangeIcons;
        private MenuItem mnuCascade;
        private MenuItem mnuColor;
        private MenuItem mnuCopy;
        private MenuItem mnuCut;
        private MenuItem mnuDelete;
        private MenuItem mnuEdit;
        private MenuItem mnuExit;
        private MenuItem mnuFile;
        private MenuItem mnuFind;
        private MenuItem mnuFont;
        private MenuItem mnuFormat;
        private MenuItem mnuHelp;
        private MenuItem mnuNew;
        private MenuItem mnuOpen;
        private MenuItem mnuPaste;
        private MenuItem mnuSave;
        private MenuItem mnuSaveAs;
        private MenuItem mnuSelectAll;
        private MenuItem mnuTileHorizontal;
        private MenuItem mnuTileVertical;
        private MenuItem mnuWindow;
        private int openDocuments;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolBarButton tbCopy;
        private ToolBarButton tbCut;
        private ToolBarButton tbNew;
        private ToolBarButton tbOpen;
        private ToolBarButton tbPaste;
        private ToolBarButton tbSave;
        private TemplateMethodDispose tMethod;
        private ToolBar toolBarMain;

        public MainForm()
        {
            InitializeComponent();
            tMethod = new TemplateMethodDispose();
            mnuSave.Enabled = false;

            //�������������� ������ ������
            accemblyList = new List<string>();
        }

        #region
        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof (MainForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuNew = new System.Windows.Forms.MenuItem();
            this.mnuOpen = new System.Windows.Forms.MenuItem();
            this.mnuSave = new System.Windows.Forms.MenuItem();
            this.mnuSaveAs = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuEdit = new System.Windows.Forms.MenuItem();
            this.mnuCut = new System.Windows.Forms.MenuItem();
            this.mnuCopy = new System.Windows.Forms.MenuItem();
            this.mnuPaste = new System.Windows.Forms.MenuItem();
            this.mnuDelete = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.mnuSelectAll = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuFind = new System.Windows.Forms.MenuItem();
            this.mnuFormat = new System.Windows.Forms.MenuItem();
            this.mnuFont = new System.Windows.Forms.MenuItem();
            this.mnuColor = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuWindow = new System.Windows.Forms.MenuItem();
            this.mnuArrangeIcons = new System.Windows.Forms.MenuItem();
            this.mnuCascade = new System.Windows.Forms.MenuItem();
            this.mnuTileHorizontal = new System.Windows.Forms.MenuItem();
            this.mnuTileVertical = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolBarMain = new System.Windows.Forms.ToolBar();
            this.tbNew = new System.Windows.Forms.ToolBarButton();
            this.tbOpen = new System.Windows.Forms.ToolBarButton();
            this.tbSave = new System.Windows.Forms.ToolBarButton();
            this.tbCut = new System.Windows.Forms.ToolBarButton();
            this.tbCopy = new System.Windows.Forms.ToolBarButton();
            this.tbPaste = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.mnuFile,
                this.mnuEdit,
                this.mnuFormat,
                this.menuItem3,
                this.mnuWindow,
                this.mnuHelp
            });
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.mnuNew,
                this.mnuOpen,
                this.mnuSave,
                this.mnuSaveAs,
                this.menuItem5,
                this.mnuExit
            });
            this.mnuFile.Text = "&File";
            // 
            // mnuNew
            // 
            this.mnuNew.Index = 0;
            this.mnuNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.mnuNew.Text = "&New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Index = 1;
            this.mnuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.mnuOpen.Text = "&Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Index = 2;
            this.mnuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Index = 3;
            this.mnuSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.mnuSaveAs.Text = "Save &As";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 5;
            this.mnuExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Index = 1;
            this.mnuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.mnuCut,
                this.mnuCopy,
                this.mnuPaste,
                this.mnuDelete,
                this.menuItem12,
                this.mnuSelectAll,
                this.menuItem1,
                this.mnuFind
            });
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuCut
            // 
            this.mnuCut.Index = 0;
            this.mnuCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.mnuCut.Text = "Cu&t";
            this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Index = 1;
            this.mnuCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.mnuCopy.Text = "&Copy";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Index = 2;
            this.mnuPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.mnuPaste.Text = "&Paste";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Index = 3;
            this.mnuDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.mnuDelete.Text = "&Delete";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 4;
            this.menuItem12.Text = "-";
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Index = 5;
            this.mnuSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.mnuSelectAll.Text = "&Select All";
            this.mnuSelectAll.Click += new System.EventHandler(this.mnuSelectAll_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 6;
            this.menuItem1.Text = "-";
            // 
            // mnuFind
            // 
            this.mnuFind.Index = 7;
            this.mnuFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.mnuFind.Text = "&Find";
            this.mnuFind.Click += new System.EventHandler(this.mnuFind_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.Index = 2;
            this.mnuFormat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.mnuFont,
                this.mnuColor,
                this.menuItem2
            });
            this.mnuFormat.Text = "F&ormat";
            // 
            // mnuFont
            // 
            this.mnuFont.Index = 0;
            this.mnuFont.Text = "Font...";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // mnuColor
            // 
            this.mnuColor.Index = 1;
            this.mnuColor.Text = "Color...";
            this.mnuColor.Click += new System.EventHandler(this.mnuColor_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "Hightlight text";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.Index = 4;
            this.mnuWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.mnuArrangeIcons,
                this.mnuCascade,
                this.mnuTileHorizontal,
                this.mnuTileVertical
            });
            this.mnuWindow.Text = "&Window";
            // 
            // mnuArrangeIcons
            // 
            this.mnuArrangeIcons.Index = 0;
            this.mnuArrangeIcons.MdiList = true;
            this.mnuArrangeIcons.Text = "Arrange Icons";
            // 
            // mnuCascade
            // 
            this.mnuCascade.Index = 1;
            this.mnuCascade.Text = "Cascade";
            this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click);
            // 
            // mnuTileHorizontal
            // 
            this.mnuTileHorizontal.Index = 2;
            this.mnuTileHorizontal.Text = "Tile Horizontal";
            this.mnuTileHorizontal.Click += new System.EventHandler(this.mnuTileHorizontal_Click);
            // 
            // mnuTileVertical
            // 
            this.mnuTileVertical.Index = 3;
            this.mnuTileVertical.Text = "Tile Vertical";
            this.mnuTileVertical.Click += new System.EventHandler(this.mnuTileVertical_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 5;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.mnuAbout
            });
            this.mnuHelp.Text = "?";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 0;
            this.mnuAbout.Text = "About Programm...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "��������� �����";
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "��������� �����";
            this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            // 
            // toolBarMain
            // 
            this.toolBarMain.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[]
            {
                this.tbNew,
                this.tbOpen,
                this.tbSave,
                this.tbCut,
                this.tbCopy,
                this.tbPaste
            });
            this.toolBarMain.DropDownArrows = true;
            this.toolBarMain.ImageList = this.imageList1;
            this.toolBarMain.Location = new System.Drawing.Point(0, 0);
            this.toolBarMain.Name = "toolBarMain";
            this.toolBarMain.ShowToolTips = true;
            this.toolBarMain.Size = new System.Drawing.Size(292, 28);
            this.toolBarMain.TabIndex = 1;
            this.toolBarMain.ButtonClick +=
                new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarMain_ButtonClick);
            // 
            // tbNew
            // 
            this.tbNew.ImageIndex = 0;
            this.tbNew.Name = "tbNew";
            this.tbNew.ToolTipText = "Create New";
            // 
            // tbOpen
            // 
            this.tbOpen.ImageIndex = 1;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.ToolTipText = "Open";
            // 
            // tbSave
            // 
            this.tbSave.ImageIndex = 2;
            this.tbSave.Name = "tbSave";
            this.tbSave.ToolTipText = "Save";
            // 
            // tbCut
            // 
            this.tbCut.ImageIndex = 3;
            this.tbCut.Name = "tbCut";
            this.tbCut.ToolTipText = "Cut";
            // 
            // tbCopy
            // 
            this.tbCopy.ImageIndex = 4;
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.ToolTipText = "Copy";
            // 
            // tbPaste
            // 
            this.tbPaste.ImageIndex = 5;
            this.tbPaste.Name = "tbPaste";
            this.tbPaste.ToolTipText = "Paste";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream =
                ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem4,
                this.menuItem6
            });
            this.menuItem3.Text = "Macros";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Add accembly";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Run macro";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // frmmain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 205);
            this.Controls.Add(this.toolBarMain);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmmain";
            this.Text = "Notepad C#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        [STAThread]
        private static void Main()
        {
            Application.Run(new MainForm());
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            //������� ����� ��������� �����  frm
            var frm = new Blank();

            frm.DocName = "Untitled " + ++openDocuments;
            //���������, ��� ������������ ����������� 
            //������ ���������� ����� ���, ������� �����.
            frm.MdiParent = this;
            frm.Text = frm.DocName;
            //�������� �����
            frm.Show();
        }

        private void mnuArrangeIcons_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            var frm = (Blank) ActiveMdiChild;
            frm.Cut();
        }

        // ������������� �������� ��������
        private void mnuCopy_Click(object sender, EventArgs e)
        {
            //var frm = (blank) ActiveMdiChild;
            //frm.Copy();
            Comm();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            var frm = (Blank) ActiveMdiChild;
            frm.Paste();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            var frm = (Blank) ActiveMdiChild;
            frm.Delete();
        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            var frm = (Blank) ActiveMdiChild;
            frm.SelectAll();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            //����� ���������� �������� ��������� ��� ������ ���������� ������. 
            //openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";


            //���� ������ ������ �������� �����, ��������� �������
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //������� ����� ��������
                var frm = new Blank();
                //�������� ����� Open ����� blank
                frm.Open(openFileDialog1.FileName);
                //���������, ��� ������������ ������ �������� ����� frmmain
                frm.MdiParent = this;
                //����������� ���������� DocName ��� ������������ �����
                frm.DocName = openFileDialog1.FileName;
                //�������� Text ����� ����������� ���������� DocName
                frm.Text = frm.DocName;
                //�������� ����� frm
                frm.Show();
                mnuSave.Enabled = true;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            //����������� ����� �� ������ �����.
            var frm = (Blank) ActiveMdiChild;
            //�������� ����� Save ����� blank
            frm.Save(frm.DocName);
            frm.IsSaved = true;
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            mnuSave.Enabled = true;
            //����� ���������� �������� ��������� ��� ������ ���������� ������. 
            //openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";

            //���� ������ ������ �������� �����, ��������� �������
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //����������� ����� �� ������ �����.
                var frm = (Blank) ActiveMdiChild;
                //�������� ����� Save ����� blank
                frm.Save(saveFileDialog1.FileName);
                //���������, ��� ������������ ������ �������� ����� frmmain
                frm.MdiParent = this;
                //����������� ���������� FileName ��� ������������ �����
                frm.DocName = saveFileDialog1.FileName;
                //�������� Text ����� ����������� ���������� DocName
                frm.Text = frm.DocName;
                frm.IsSaved = true;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            //����������� ����� �� ������ �����.
            var frm = (Blank) ActiveMdiChild;
            //���������, ��� ������������ ������ �������� ����� frmmain	
            frm.MdiParent = this;
            //�������� ������
            fontDialog1.ShowColor = true;
            //��������� �������� SelectionFont � SelectionColor �������� RichTextBox 
            //� ���������������� ���������� �������
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;
            //���� ������ ������ �������� �����, ��������� �������
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            //���������� �����
            frm.Show();
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            var frm = (Blank) ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }

            frm.Show();
        }

        private void mnuFind_Click(object sender, EventArgs e)
        {
            //������� ����� ��������� ����� FindForm
            var frm = new FindForm();
            //���� ������ ��������� DialogResult.Cancel, ��������� ����� (�� ����� 
            //�� ������������ DialogResult.OK
            if (frm.ShowDialog(this) == DialogResult.Cancel) return;
            ////����������� ����� �� ������ �����.
            var form = (Blank) ActiveMdiChild;
            ////���������, ��� ������������ ������ �������� ����� frmmain	
            form.MdiParent = this;
            //������ ���������� ��� ������ � ������������ ����� ������ -
            //����� ����� ����� �������������� �� ������� ������� �������
            var start = form.richTextBox1.SelectionStart;
            //�������� ���������������� ����� Find �������� richTextBox1.
            form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            //������� ����� ��������� �����  About
            var frm = new AboutProgram();
            frm.Show();
        }

        private void toolBarMain_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            //New
            if (e.Button.Equals(tbNew))
            {
                mnuNew_Click(this, new EventArgs());
            }
            //Open
            if (e.Button.Equals(tbOpen))
            {
                mnuOpen_Click(this, new EventArgs());
            }
            //Save
            if (e.Button.Equals(tbSave))
            {
                mnuSave_Click(this, new EventArgs());
            }
            //Cut
            if (e.Button.Equals(tbCut))
            {
                mnuCut_Click(this, new EventArgs());
            }
            //Copy
            if (e.Button.Equals(tbCopy))
            {
                mnuCopy_Click(this, new EventArgs());
            }
            //Paste
            if (e.Button.Equals(tbPaste))
            {
                mnuPaste_Click(this, new EventArgs());
            }
        }

        // ������������� �������� ���������
        private void menuItem2_Click(object sender, EventArgs e)
        {
            var frm = (Blank) ActiveMdiChild;
            if (frm != null)
            {
                frm.Hightlight();
            }
        }

        //--------------------------------Patterns realization--------------------------------

        // ���������� �������� ���������
        public void Hightlight()
        {
            //var alg = new Algorithm();
            //alg.Hightlight();
            var frm = (Blank) ActiveMdiChild;
            frm.Hightlight();
        }

        // ���������� �������� �������
        public void Comm()
        {
            var controlComm = new ControlCommand();
            var blank = (Blank) ActiveMdiChild;
            controlComm.SetCommand(new ConcreteCommand(blank));
            controlComm.Exec();
        }

        //----------------------------------------------------------------------

        //--------------------------------Macros--------------------------------

        // ����� ���� Add Accembly - ��������� ������
        private void menuItem4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = openFileDialog1.FileName;
            //��������� � ������ ��� ������
            accemblyList.Add(filename.Remove(0, filename.LastIndexOf(@"\") + 1));
        }

        // ����� ���� Run Macro - ������ �������
        private void menuItem6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
            }
            else
            {
                var filename = openFileDialog1.FileName;
                if (filename != "")
                {
                    Run_Macro(filename);
                }
            }
        }

        // �������� ������ �� ������� �������
        private void Run_Macro(string filename)
        {
            var form = (Blank) ActiveMdiChild;

            if (!filename.EndsWith("cs"))
            {
                MessageBox.Show("������ ������ ���� ������� �� c# � ����� ���������� cs");
                return;
            }
            try
            {
                // ������ ��� ����� ��� �� �����
                var macroCode = new StreamReader(filename, Encoding.Default).ReadToEnd();
                //������� ��������� ����������� c#
                var csProv = new CSharpCodeProvider();
                //������� ����� ���������� ��� �������� �� �����������.
                var csParams = new CompilerParameters();

                //��������� ������ ������
                foreach (var accembly in accemblyList)
                {
                    csParams.ReferencedAssemblies.Add(accembly);
                }
                accemblyList.Clear();
                //��������� �� ��������� �������� ������������ ������
                csParams.ReferencedAssemblies.Add("mscorlib.dll");
                csParams.ReferencedAssemblies.Add("System.dll");
                csParams.ReferencedAssemblies.Add("System.Windows.Forms.dll");

                //�� ����� ��������� �� ���� ����������� ����
                csParams.GenerateExecutable = false;
                //��� ����� �������������� ������ � ������ ��� ������ �� ����
                csParams.GenerateInMemory = true;
                //����������� ��� � �������� ���������� ����������
                var compResults = csProv.CompileAssemblyFromSource(csParams, macroCode);

                //��������� �� ������� ������
                if (compResults.Errors.Count > 0)
                {
                    //���������� ��������� �� ������  
                    foreach (var er in compResults.Errors)
                    {
                        MessageBox.Show(er.ToString());
                    }
                }
                else
                {
                    //������� ��������� �������� ���������� ��� ���������� ������  
                    var obj = compResults.CompiledAssembly.CreateInstance("Program");
                    //� �������� ��������f ��������� ������� ���� ��������� ����, ��� ������� ����� ����������� �����������
                    object[] args = {form.richTextBox1};
                    //�������� ��� � �������� ��� � �������� ���������� ��� ������ - ����� Program � ������ ����������
                    var t = (Type) obj.GetType().InvokeMember("Main", BindingFlags.InvokeMethod, null, obj, args);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}