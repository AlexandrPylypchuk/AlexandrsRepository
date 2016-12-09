using System.ComponentModel;
using System.Windows.Forms;

namespace NotepadCSharp
{
    /// <summary>
    ///     Summary description for FindForm.
    /// </summary>
    public class FindForm : Form
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container components = null;

        private Button btnCancel;
        private Button btnOK;
        private CheckBox cbMatchCase;
        private CheckBox cbMatchWhole;
        private TemplateMethodDispose tMethod;
        private TextBox txtFind;

        public FindForm()
        {
            InitializeComponent();
            tMethod = new TemplateMethodDispose();
        }

        //������� �������� FindText, ������������ � �������� ���������� 
        //������ ��������� ����� � ��������� ���� ����� FindForm
        public string FindText
        {
            get { return txtFind.Text; }
            set { txtFind.Text = value; }
        }

        // ������� ������������, ������������ �������� FindCondition
        public RichTextBoxFinds FindCondition
        {
            get
            {
                //������� ��� ��������
                if (cbMatchCase.Checked && cbMatchWhole.Checked)
                {
                    // ���������� �������� MatchCase � WholeWord 
                    return RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord;
                }
                //������ ���� �������
                if (cbMatchCase.Checked)
                {
                    // ���������� �������� MatchCase
                    return RichTextBoxFinds.MatchCase;
                }
                //������ ������ �������
                if (cbMatchWhole.Checked)
                {
                    // ���������� �������� WholeWord
                    return RichTextBoxFinds.WholeWord;
                }
                //�� ������ �� ���� �������
                return RichTextBoxFinds.None;
            }
        }

        #region
        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFind = new System.Windows.Forms.TextBox();
            this.cbMatchWhole = new System.Windows.Forms.CheckBox();
            this.cbMatchCase = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(8, 16);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(192, 20);
            this.txtFind.TabIndex = 0;
            this.txtFind.Text = "";
            // 
            // cbMatchWhole
            // 
            this.cbMatchWhole.Location = new System.Drawing.Point(120, 48);
            this.cbMatchWhole.Name = "cbMatchWhole";
            this.cbMatchWhole.TabIndex = 3;
            this.cbMatchWhole.Text = "Match &whole word";
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.Location = new System.Drawing.Point(8, 48);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.TabIndex = 2;
            this.cbMatchCase.Text = "Match &Case";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(232, 48);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(232, 16);
            this.btnOK.Name = "btnOK";
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            // 
            // FindForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(322, 88);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbMatchWhole);
            this.Controls.Add(this.cbMatchCase);
            this.Controls.Add(this.txtFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindForm";
            this.Text = "Find";
            this.ResumeLayout(false);
        }

        #endregion
    }
}