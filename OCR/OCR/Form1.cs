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

namespace OCR
{
    public partial class Form1 : Form
    {
        private List<Algorithm> algorithms;
        private Dictionary<string, Label> labels;

        private Bitmap inputImage;

        public Form1()
        {
            InitializeComponent();
            l0.Text = l1.Text = l2.Text = l3.Text = l4.Text = l5.Text = l6.Text = l7.Text = l8.Text = l9.Text = "";
            lA.Text = lB.Text = lC.Text = lD.Text = lE.Text = lF.Text = lG.Text = lH.Text = lI.Text = lJ.Text = lK.Text = "";
            lL.Text = lM.Text = lN.Text = lO.Text = lP.Text = lQ.Text = lR.Text = lS.Text = lT.Text = lU.Text = lV.Text = "";
            lW.Text = lX.Text = lY.Text = lZ.Text = lMLC.Text = "";

            labels = new Dictionary<string, Label>();
            labels.Add("0", l0);
            labels.Add("1", l1);
            labels.Add("2", l2);
            labels.Add("3", l3);
            labels.Add("4", l4);
            labels.Add("5", l5);
            labels.Add("6", l6);
            labels.Add("7", l7);
            labels.Add("8", l8);
            labels.Add("9", l9);

            labels.Add("A", lA);
            labels.Add("B", lB);
            labels.Add("C", lC);
            labels.Add("D", lD);
            labels.Add("E", lE);
            labels.Add("F", lF);
            labels.Add("G", lG);
            labels.Add("H", lH);
            labels.Add("I", lI);
            labels.Add("J", lJ);
            labels.Add("K", lK);
            labels.Add("L", lL);
            labels.Add("M", lM);
            labels.Add("N", lN);
            labels.Add("O", lO);
            labels.Add("P", lP);
            labels.Add("Q", lQ);
            labels.Add("R", lR);
            labels.Add("S", lS);
            labels.Add("T", lT);
            labels.Add("U", lU);
            labels.Add("V", lV);
            labels.Add("W", lW);
            labels.Add("X", lX);
            labels.Add("Y", lY);
            labels.Add("Z", lZ);


            algorithms = new List<Algorithm>();
            algorithms.Add(new OCRAlgo("OCR Algorithm Erwin"));
            //Add algo here!

            cbAlgo.Items.Clear();
            for (int i = 0; i < algorithms.Count; i++)
                cbAlgo.Items.Add(algorithms[i].Name);
            cbAlgo.SelectedIndex = 0;
        }

        private void OpenPic(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            oFD.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG;)|*.BMP;*.JPG;*.JPEG;*.PNG;";
            oFD.FilterIndex = 1;
            oFD.RestoreDirectory = true;
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                String CurrentFileName = Path.GetFullPath(oFD.FileName);
                inputImage = new Bitmap(CurrentFileName);
                pictureBox1.Image = inputImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> result = algorithms[cbAlgo.SelectedIndex].DoAlgorithm(inputImage);
            KeyValuePair<string, int> highest = new KeyValuePair<string,int>("-", 0);
            foreach (KeyValuePair<string, int> r in result)
            {
                if (r.Value > highest.Value)
                    highest = r;//new KeyValuePair<string, int>(r.Key, r.Value);
                labels[r.Key].Text = r.Value + "%";
            }
            lMLC.Text = highest.Key;
        }
    }
}
