using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Storage
{
    public class Class1
    {
        private string materialName;
        private string materialId;

        private float quanlity;
        private float price;
        private float amount;

        public Class1(string materialName, string materialId, float quanlity, float price, float amount)
        {
            this.materialName = materialName;
            this.materialId = materialId;
            this.quanlity = quanlity;
            this.price = price;
            this.amount = amount;

        }
        public string MaterialName { get { return materialName; } set { materialName = value; } }
        public string MaterialId { get { return materialId; } set { materialId = value; } }
        public float Quanlity { get { return quanlity; } set { quanlity = value; } }
        public float Price { get { return price; } set { price = value; } }
        public float Amount { get { return amount; } set { amount = value; } }
    }
}
