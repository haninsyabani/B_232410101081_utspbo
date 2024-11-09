using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1081_Hanin_Zahirah_Syabani_UTSPRPBO.Apps.Context
{
    internal class TugasContext
    {
        private static string table = "Tugas";

        public static DataTable All()
        {
            string query = @"
        SELECT 
            t.id,
            t.namatugas,
            t.deskripsi,
            t.deadline 
        FROM 
            tugas t
      

            DataTable dataTugas = queryExecutor(query);
            return dataTugas;
        }

        public static DataTable getMahasiswaById(int id)
        {
            string query = @"
                SELECT
                    t.id,
                    t.namatugas,
                    t.deskripsi,
                    t.deadline
                   
           

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataTugas = queryExecutor(query, parameters);
            return dataTugas;
        }


        public static void AddTugas(M_TUGAS tugasBaru)
        {
            string query = $"INSERT INTO {table} (namatugas, deskripsi, deadline) VALUES(@namatugas, @deskripsi, @deadline)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namatugas", tugasBaru.namatugas),
                new NpgsqlParameter("@deskripsi", tugasBaru.deskripsi),
                new NpgsqlParameter("@deadline", tugasBaru.deadlibe)
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateMahasiswa(M_Tugas tugas)
        {
            string query = $"UPDATE {table} SET namatugas = @namatugas, deskripsi = @deskripsi, deadline = @deadline ;

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namatugas", tugas.namatugas),
                new NpgsqlParameter("@deskripsi", tugas.deskripsi),
                new NpgsqlParameter("@deadline", tugas.deadline)
            };

            commandExecutor(query, parameters);
        }

        public static void DeleteTugas(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", id)
            };

            commandExecutor(query, parameters);
        }
    }
}
