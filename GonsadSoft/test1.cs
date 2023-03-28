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
using System.Xml.Linq;

namespace GonsadSoft
{
    public partial class test1 : Form
    {
        public test1()
        {
            InitializeComponent();
        }

        private void btnCargarCarpeta_Click(object sender, EventArgs e)
        {
            LoadFolder(treeView1.Nodes, new DirectoryInfo(@"C:\Gonsad"));
        }

        private void LoadFolder(TreeNodeCollection nodes, DirectoryInfo folder) 
        {
            var newNode = nodes.Add(folder.Name);
            foreach (var childFolder in folder.EnumerateDirectories())
            {
                LoadFolder(newNode.Nodes, childFolder);
            }
            foreach (FileInfo file in folder.EnumerateFiles())
            {
                newNode.Nodes.Add(file.Name);
            }
        }

    }   
}
