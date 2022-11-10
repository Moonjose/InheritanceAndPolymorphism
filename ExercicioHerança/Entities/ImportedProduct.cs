using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerança.Entities {
    internal class ImportedProduct : Product {
        public double CustomsFee { get; set; }
        public ImportedProduct(string name, double price, double customsFee) : base(name, price) {
            CustomsFee = customsFee;
        }
        public override string priceTag() {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + $" (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
