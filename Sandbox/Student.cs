using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    // A class i s a template
    public class Student
    {
        //instance field

        private string _name;
        private int _cpr;
        private int _grade1;
        private string _mblNr;
        private int _grade2;
        
        //property
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Cpr
        {
            get
            {
                return _cpr;

            }
            set
            {
                _cpr = value;

            }
        }

        public int Grade1
        {
            get
            {
                return _grade1;
            }
            set
            {
                _grade1 = value;
            }
        }

        public int Grade2
        {
            get
            {
                return _grade2;
            }
            set
            {
                _grade2 = value;
            }
        }

       

        public string Mobile
        {
            get
            {
                return _mblNr;
            }

            set
            {
                _mblNr = value;
            }
        }

        public Student(string name)
        {
            _name = name;
        }

        public Student(string name, string mobile, int cpr)
        {
            _name = name;
            _mblNr = mobile;
            _cpr = cpr; 
        }
        public Student()
        {

        }

        public double CalculateAverage()
        {
            double result = (_grade1 + _grade2) / 2.0;
            return result; 
        }
    }
}
