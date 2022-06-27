using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Storage
{
    public class AddMaterial
    {
        private string materialName;
        private string materialId;
        private string nhaCungCap;

        private float quanlity;
        private float price;
        private float amount;

        public AddMaterial(string materialName ,string materialId ,string nhaCungCap, float quanlity,float price,float amount)
        {
            this.materialName = materialName;
            this.materialId = materialId;        
            this.quanlity = quanlity;
            this.price = price;
            this.amount = amount;
            this.nhaCungCap=nhaCungCap;
        }
        public string MaterialName { get{ return materialName; } set { materialName = value; } }
        public string MaterialId { get { return materialId; } set { materialId = value; } }
        public string NhaCungCap { get { return nhaCungCap; } set { materialId = value; } }
        public float Quanlity { get { return quanlity; } set { quanlity = value; } }
        public float Price { get { return price; } set { price = value; } }
        public float Amount { get { return amount; } set { amount = value; } }
    }
}
