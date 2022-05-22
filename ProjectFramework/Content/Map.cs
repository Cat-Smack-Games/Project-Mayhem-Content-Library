using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMayhemContentFramework.Content
{
    [Serializable]
    public class Map
    {
        public string id { get; }
        public Map(string path)
        {
            string mapdata = null;
            if (File.Exists(path))
            {
                mapdata = File.ReadAllText(path);
                ReadMapData(mapdata);
            }
        }

        private void ReadMapData(string data)
        {
            char[] inputBuffer = data.ToCharArray();

            foreach (char c in inputBuffer)
            {

            }
        }
    }
}
