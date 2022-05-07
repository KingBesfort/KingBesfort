using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PostOfficeManagement.BLL
{
    public class Kompania
    {
        private Kompania _Kompania;

        public Kompania()
        {
            _Kompania = new Kompania();
        }

        public DataSet GetAll()
        {
            return _Kompania.GetAll();
        }
    }
}
