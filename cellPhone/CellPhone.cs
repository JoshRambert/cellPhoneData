using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cellPhone
{
    class CellPhone
    {
        //Create the fields that will be used to retrive and assign the data for the cellPhone
        private string _brand;
        private string _model;
        private decimal _price;

        //Create the constructor for the fields
        public CellPhone(){
            _brand = "";
            _model = "";
            _price = 0m;
        }

        //Create the properties
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
