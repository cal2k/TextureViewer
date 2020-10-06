using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TextureViewer
{
    class Materials
    {
         
        string temp, TexturePath = "d:\\Documents\\Assits\\Textures\\cc0textures.com";
        string[] dirs;
        int i,ii;
        private static List<string> listMats = new List<string>();

        Form1 form = new Form1();
        public List<string> MaterialList
        {
            get { return listMats; }
        }
        //MATERIALS
        public void load()
        {
            ii = TexturePath.Count();
            dirs = Directory.GetDirectories(TexturePath);
            for (i = 0; i < dirs.Length; i++)
            {
                temp = dirs[i];
                temp = temp.Remove(0, ii + 1);
                listMats.Add(temp);
            }

            populate();
        }

        private void populate()
        {
            form.lbMaterials.Items.Clear();

            ii = MaterialList.Count();
            for (i = 0; i < ii; i++)
            {
                form.lbMaterials.Items.Add(MaterialList[i]);
            }
        }

    }
}
