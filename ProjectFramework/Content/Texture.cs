using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMayhemContentFramework.Content
{
    [Serializable]
    public class Texture
    {
        public System.Drawing.Image texture { get; set; }

        public TextureInfo Info { get; set; }
        [Serializable]
        public class TextureInfo
        {
            public string texture_id { get; set; }
            public string texture_name { get; set; }
        }
    }
}
