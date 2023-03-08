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
using ToolBox.Forms.HelperDialogs;

namespace ToolBox.Forms
{
    public partial class Decompiler_Page : Form
    {
        public Decompiler_Page()
        {
            InitializeComponent();
        }

        private void unityDecompilerButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog exeFile = new OpenFileDialog();
            exeFile.Filter = "exe|*.exe";
            exeFile.Multiselect= false;

            if(exeFile.ShowDialog() == DialogResult.OK)
            {
                FolderBrowserDialog outputFolder = new FolderBrowserDialog();
                if(outputFolder.ShowDialog() == DialogResult.OK)
                {
                    decompileUnityTo(exeFile.FileName, outputFolder.SelectedPath);
                }
                else
                {
                    ErrorPopup hp = new ErrorPopup();
                    hp.SetError("Folder not found or action canceled");
                    hp.ShowDialog();
                }
            }
            else
            {
                ErrorPopup hp = new ErrorPopup();
                hp.SetError("File not found or action canceled");
                hp.ShowDialog();
            }
        }


        private void decompileUnityTo(string exeFile, string outputFolder)
        {

        }
    }
}
