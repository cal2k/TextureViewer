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
        private List<string> listMats = new List<string>();

        public List<string> MaterialList
        {
            get { return listMats; }
        }

        //MATERIALS
        public void load()
        {
            string temp;
            string[] dirs;
            int textureCount = Forms.TexturePath.Count();

            dirs = Directory.GetDirectories(TexturePath);
            for (int i = 0; i < dirs.Length; i++, textureCount++)
            {
                temp = dirs[i];
                temp = temp.Remove(0, textureCount);
                listMats.Add(temp);
            }
        }
    }
}
