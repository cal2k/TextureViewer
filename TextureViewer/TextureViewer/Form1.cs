using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextureViewer
{
    public partial class Form1 : Form
    {
        Materials Mats = new Materials();
        public static string TexturePath = "d:\\Documents\\Assits\\Textures\\cc0textures.com"
        
        string CurrentPath, CurrentMaterial, CurrentTexture, FileName, imagePath, temp, filterword;
        String[] dirs, tempArray;
        List<string> Textures = new List<string>();
        int i, ii, count;

        public Form1()
        {
            InitializeComponent();
            ii = TexturePath.Count();
            lblCurrentDir.Text = TexturePath;

            btnOpenImage.Enabled = false;
            btnTextureLocation.Enabled = false;
            
            populateMaterials();
        }
        
        private void btnSelectLibarary_Click(object sender, EventArgs e)
        {
            lbMaterials.Items.Clear();

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    TexturePath = fbd.SelectedPath.ToString();
                    lblCurrentDir.Text = TexturePath;
                    ii = TexturePath.Count();

                    Mats.load();
                }
            }
        }

        private void populateMaterials()
        {
            lbMaterials.Items.Clear();

            foreach (string material in Mats.MaterialList)
            {
                lbMaterials.Items.Add(material);
            }
        }

        private void lbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            Textures.Clear();
            CurrentMaterial = lbMaterials.SelectedItem.ToString();
            CurrentPath = TexturePath + "\\" + CurrentMaterial;
            pictureBox1.Image = null;
            loadTextures();

        }
        //Filtering Materials
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            filterword = tbFilter.Text;
            count = filterword.Length;

            if (count > 1)
            {
                filterword = char.ToUpper(filterword[0]) + filterword.Substring(1);
            }


            count = Mats.MaterialList.IndexOf(filterword);
            switch (count)
            {
                case -1:
                    pictureBox1.Image = null;
                    lbOptions.Items.Clear();
                    populateMaterials();
                    break;
                default:
                    lbMaterials.Items.Clear();
                    lbMaterials.Items.Add(Mats.MaterialList[count]);

                    Textures.Clear();
                    CurrentMaterial = Mats.MaterialList[count];
                    CurrentPath = TexturePath + "\\" + CurrentMaterial;
                    pictureBox1.Image = null;
                    loadTextures();
                    break;
            }
        }



        //TEXTURES
        private void loadTextures()
        {
            dirs = System.IO.Directory.GetDirectories(CurrentPath);

            lbOptions.Items.Clear();
            btnOpenImage.Enabled = false;
            btnTextureLocation.Enabled = false;

            for (i = 0; i < dirs.Length; i++)
            {
                temp = dirs[i];
                temp = temp.Remove(0, ii + 1);
                tempArray = temp.Split('\\');
                Textures.Add(tempArray[1]);
            }
            populateTextures();
        }
        private void populateTextures()
        {
            count = Textures.Count();
            for(i = 0; i < count; i++)
            {
                lbOptions.Items.Add(Textures[i]);
            }
        }
        private void lbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentTexture = lbOptions.SelectedItem.ToString();
            tempArray = CurrentTexture.Split('-');
            FileName = tempArray[0];
            loadImage();
        }

        //IMAGES
        private void loadImage()
        {
            try
            {
                imagePath = (CurrentPath + "\\" + CurrentTexture + "\\" + FileName + "_Color.jpg");
                pictureBox1.Load(imagePath);
                btnOpenImage.Enabled = true;
                btnTextureLocation.Enabled = true;
            }
            catch (Exception ex)
            {
                try
                {
                    imagePath = (CurrentPath + "\\" + CurrentTexture + "\\" + FileName + "_Color.png");
                    pictureBox1.Load(imagePath);
                    btnOpenImage.Enabled = true;
                    btnTextureLocation.Enabled = true;
                }
                catch (Exception exx)
                {
                    pictureBox1.Image = pictureBox1.ErrorImage;
                    btnTextureLocation.Enabled = true;
                }
            }
        }
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(imagePath);
        }
        private void btnTextureLocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(CurrentPath + "\\" + CurrentTexture);
        }
        private void btnCopyTexturePath_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(CurrentPath + "\\" + CurrentTexture);
        }

        //DELETE
        private void btnDeleteTexture_Click(object sender, EventArgs e)
        {

        }

    }
}
