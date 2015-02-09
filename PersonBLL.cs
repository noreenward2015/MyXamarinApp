using System;
using System.Collections.Generic;
using System.Data;
using $safeprojectname$.DAL;

namespace $safeprojectname$.BLL
{
    public class PersonBLL
    {
        public DataTable GetPersons()
        {
            try
            {
                PersonDAL objdal = new PersonDAL();
                return objdal.Read();
            }
            catch
            {
                throw;
            }
        }
        public DataTable GetPersons(Int16 ID)
        {
            try
            {
                PersonDAL objdal = new PersonDAL();
                return objdal.Read(ID);
            }
            catch
            {
                throw;
            }
        }

    }
}