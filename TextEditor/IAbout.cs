using System.ComponentModel;

namespace NotepadCSharp
{
    public class IAbout : AboutProgram
    {
        private IContainer components = null;
        private TemplateMethodDispose tMethod;

        public IAbout()
        {
            // This call is required by the Windows Form Designer.
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
            // 
            // IAbout
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(312, 182);
            this.Name = "IAbout";
        }

        #endregion
    }
}