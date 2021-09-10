using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI
{
    class CarCreationClass
    {
        //make private fields
        private string _make, _model, _year;
        private int _speed;
        
        //make constructor for the car
        public CarCreationClass() {

            _make = "";
            _model = "";
            _year = "";
            _speed = 0;

        
        }

        //make the properties 
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int Speed {
            get { return _speed; }
        }

        //increase speed method
        public void Increase() {
            _speed += 5;
        
        }

        //decrease speed method
        public void Decrease() {
            _speed -= 5;

        
        }


    }


}
