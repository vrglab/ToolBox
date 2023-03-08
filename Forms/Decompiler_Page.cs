using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ToolBox.Forms.HelperDialogs;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.TypeSystem;
using ICSharpCode.Decompiler.Metadata;
using ICSharpCode.Decompiler.Disassembler;
using System.Threading;
using ICSharpCode.Decompiler.CSharp.Syntax;

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
            }
        }

        private void decompileUnityTo(string exeFile, string outputFolder)
        {
            FileInfo fi = new FileInfo(exeFile);
            DirectoryInfo DataFolder = null;

            foreach (var item in Directory.GetDirectories(fi.Directory.FullName))
            {
                if (item.Contains("_Data")) 
                {
                    DataFolder = new DirectoryInfo(item);
                }
            }

            if(DataFolder != null)
            {
                string dllFile = DataFolder.FullName + "/Managed/Assembly-CSharp.dll";

                CSharpDecompiler cd = new CSharpDecompiler(dllFile, new DecompilerSettings());

               SyntaxTree st = cd.DecompileWholeModuleAsSingleFile();

               List<EntityDeclaration> ed = st.GetTypes().ToList();

                foreach (var item in ed)
                {
                    var sd = new FileStream(outputFolder + "/"+ item.StartLocation + item.NameToken.Name+".cs", FileMode.Create) ;
                    byte[] data = stringToBytearray(item.ToString());

                    sd.Write(data, 0, data.Length);
                    sd.Close();
                }
            }
            else
            {
                ErrorPopup ep = new ErrorPopup();
                ep.SetError("Not a Unity game");
                ep.ShowDialog();
                return;
            }    
        }
    
        private byte[] stringToBytearray(string data)
        {
            return Encoding.Default.GetBytes(data);
        }
    }
}
