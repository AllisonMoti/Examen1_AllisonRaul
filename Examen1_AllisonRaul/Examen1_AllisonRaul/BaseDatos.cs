using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;


namespace Examen1_AllisonRaul
{
    public class BaseDatos
    {
        readonly SQLiteAsyncConnection db;

        public BaseDatos(string dbpath)
        {
            db = new SQLiteAsyncConnection(dbpath);


        }
        #region Locations

        public Task<List<locations>> GetLocations()
        {
            return db.Table<locations>().ToListAsync();
        }
        public Task<int> InsertarLocations(locations locations)
        {
            if (locations.latitud != 0)
            {
                return db.UpdateAsync(locations);
            }
            else
            {
                return db.InsertAsync(locations);
            }
        }
        public Task<locations> GetAlumnos(int Platitud)
        {
            return db.Table<locations>()
                .Where(i => i.latitud == Platitud)
                .FirstOrdefaultAsync();
        }
        public Task<int> DeleteAlumno(locations alumno)
        {
            return db.DeleteAsync(alumno);
        }
        #endregion
        #region locations
        public Task<locations> GetListLocations()
        {
            return db.Table<locations>().ToListAsync();

        }

        public Task<int>NUEVA_UBICACION(locations locations)
        {
            if(locations.latitud !=0)
            {
                return db.UpdateAsync(locations);

            }
            else
            {
                return db.InsertAsync(locations);
            }
        }


    }

}
}

