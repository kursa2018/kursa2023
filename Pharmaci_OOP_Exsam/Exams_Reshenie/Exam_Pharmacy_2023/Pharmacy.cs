using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_Pharmacy_2023
{
    public class Pharmacy
    {
        private string name;
        private List<Medicine> ListOfMedicine;
        public void Order(Medicine medicine)
        {
            ListOfMedicine.Add(medicine);
        }
        public bool Sell(Medicine medicine)
        {
            Medicine searchMedicine = ListOfMedicine.FirstOrDefault(x=>x==medicine);
            return ListOfMedicine.Remove(searchMedicine);
        }
        public double CalculateTotalPrice()
        {
            return ListOfMedicine.Sum(x => x.Price);
        }
        public Medicine GetMedicineWithHighestPrice()
        {
            Medicine medicine = ListOfMedicine.OrderByDescending(x => x.Price).FirstOrDefault();
            return medicine;
        }
        public Medicine GetMedicineWithLowestPrice()
        {
            Medicine medicine = ListOfMedicine.OrderBy(x => x.Price).FirstOrDefault();
            return medicine;
        }
        public void RenamePharmacy(string newName)
        {
            this.Name = newName;
        }
        public void SellAllMedicines()
        {
            ListOfMedicine.Clear();
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            if (ListOfMedicine.Count==0)
            {
                return $"Pharmacy {this.Name} has 0 medicines and they are:N/A";
            }
            string str1 = $"Pharmacy {this.Name} has {ListOfMedicine.Count} medicines and they are:";
            builder.AppendLine(str1);
            foreach (var item in ListOfMedicine)
            {
                builder.AppendLine(item.ToString());
            }
            return builder.ToString();
        }

        public Pharmacy(string name)
        {
            this.Name = name;
            this.ListOfMedicine = new List<Medicine>();
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("Invalid name");
                }
                name = value;
            
            }
        }

    }
}
