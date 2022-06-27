using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Storage
{
    public class Kiemke
    {
        private string materialName;
        private string materialId;
        private float expect;
        private float real;
        private float diff;

        public Kiemke(string materialName, string materialId, float expect, float real, float diff)
        {
            this.materialName = materialName;
            this.materialId = materialId;
            this.expect = expect;
            this.real = real;
            this.diff = diff;
        }
        public string MaterialName { get { return materialName; } set { materialName = value; } }
        public string MaterialId { get { return materialId; } set { materialId = value; } }
        public float Expect { get { return expect; } set { expect = value; } }
        public float Real { get { return real; } set { real = value; } }
        public float Diff { get { return diff; } set { diff = value; } }
    }
}
