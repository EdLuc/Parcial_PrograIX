using Dapper;
using DapperExtensions;
using Parcial_Progra_IX.DML;
using Parcial_Progra_IX.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_Progra_IX.Services
{
    public class AlumnosServices
    {
        private SqlConnection _Conn = new SqlConnection();
        private static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=localhost; Initial Catalog=AlumnosUdeO; Integrated Security=True; Pooling=False");
        }

        public Alumnos GetAlumnoByID(int id)
        {
            _Conn = GetSqlConnection();
            _Conn.Open();
            //Select
            var alumno = _Conn.Query<Alumnos>("SELECT * FROM Alumno").Where(f => f.id == id).ToList();
            return alumno.Count != 0 ? alumno.First() : null;
        }

        public IEnumerable<Alumnos> GetAlumno()
        {
            _Conn = GetSqlConnection();
            _Conn.Open();
            //Select
            var alumno = _Conn.Query<Alumnos>("SELECT * FROM Alumno").ToList();
            return alumno;
        }
    }
}
