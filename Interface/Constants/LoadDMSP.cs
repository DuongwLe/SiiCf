using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Constants
{
     public class LoadDMSP
    {
        private string maDMSP;
        private string tenDMSP;

        public LoadDMSP(string maDMSP,string tenDMSP)
        {
            this.maDMSP = maDMSP;
            this.tenDMSP = tenDMSP;
        }
        public string MaDMSP
        {
            get { return maDMSP; }
            set { maDMSP = value; }
        }

        public string TenDMSP
        {
            get { return tenDMSP; }
            set { tenDMSP = value; }
        }
    }
}
