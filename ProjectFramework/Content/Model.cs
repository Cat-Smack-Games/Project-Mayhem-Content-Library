using ObjParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMayhemContentFramework.Content
{
    [Serializable]
    public class Model
    {
        public Obj model { get; set; }
        public ModelInfo Info;

        [Serializable]
        public class ModelInfo
        {
            public string model_id { get; set; }

            public string model_name { get; set; }
            public string texture_id { get; set; }

        }
    }
}
