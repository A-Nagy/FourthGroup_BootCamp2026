using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Room_17
{
     class Rooms
    {

        /*
         * **Room**
             - Properties : `Length`, `Width`, `Height`
             - Function   : `GetVolume()` → calculates room volume
             * 
         */
        //class
        //class is a blueprint of an object.
        //It is a user-defined data type that contains variables, methods, and properties.
        //It is used to create objects.

        //Fields ==> Private Properties
        //Fields are variables that are declared in a class.
        //They are used to store data.
        //They are declared at the class level and can be accessed by all methods in the class.
        //Fields Can Be Deaclared as Any Type of Data Type Like int, double, string, etc.
        //Fields Can Be Deaclared as Public, Private.
         double _length;
         double _width;
         double _height;

        //Properties ==> Public Properties
        //Properties spicial Methods used to Get And Set Data To The Fields 
        public double Length 
        {
            get {return _length;}
            set {_length = value <0 ? 0: value;}
        }
        public double Width 
        {
            get {return _width;}
            set { _width = value < 0 ? 0 : value; }
        }
        public double Height 
        {
            get {return _height;}
            set {_height = value < 0 ? 0 : value; }
        }


        //Function
        //Function is a block of code that performs a specific task.
        public double GetVolume()
        {
            return Length * Width ;
        }

        //Constractor
        //Constractor Is A Spicial Method
        //used To Initializes the Object
        //Dont Have Any Data Type 
        // Constractor Name IS The Same Name Of The Class Name 
        public Rooms(double l , double w , double h )
        {
          Height = h;
          Width  = w;
          Length = l;

        }

    }
}
