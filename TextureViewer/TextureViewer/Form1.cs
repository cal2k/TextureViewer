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
        string TexturePath, CurrentPath, CurrentMaterial, CurrentTexture, FileName, imagePath, temp;
        String[] dirs, tempArray;
        int i, ii;
        public Form1()
        {
            InitializeComponent();
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

                    loadMaterials();
                }
            }
        }
        
        private void btnCC0_Click(object sender, EventArgs e)
        {
            lbMaterials.Items.Clear();

            TexturePath = "d:\\Documents\\Assits\\Textures\\cc0textures.com";
            lblCurrentDir.Text = TexturePath;
            ii = TexturePath.Count();

            loadMaterials();
        }

        private void loadMaterials()
        {
            btnOpenImage.Enabled = false;
            btnTextureLocation.Enabled = false;

            dirs = Directory.GetDirectories(TexturePath);
            for (i = 0; i < dirs.Length; i++)
            {
                temp = dirs[i];
                temp = temp.Remove(0, ii + 1);
                lbMaterials.Items.Add(temp);
            }
        }
        private void lbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentMaterial = lbMaterials.SelectedItem.ToString();
            CurrentPath = TexturePath + "\\" + CurrentMaterial;
            pictureBox1.Image = null;
            loadOptions();
            
        }

        private void loadOptions()
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
                lbOptions.Items.Add(tempArray[1]);
            }
        }
        private void lbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentTexture = lbOptions.SelectedItem.ToString();
            tempArray = CurrentTexture.Split('-');
            FileName = tempArray[0];
            loadImage();
        }

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
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show(exx.ToString());
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
    }
}
