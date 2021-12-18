using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Repository
{
    class Voluntarily : UnitOfWork
    {
        public Model.Voluntarily Find(int? Id)
        {
            if (Id == null)
                throw new Exception("شناسه نمی تواند خالی باشد");

            var output = new List<Model.Voluntarily>();
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = Id });
            var reader = db.ExecuteReader("SELECT * FROM Voluntarilies WHERE Id = @Id", parameters);
            if (reader.Read())
                return new Model.Voluntarily
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Title = reader["Title"].ToString(),
                    From = reader["From"].ToString(),
                    To = reader["To"].ToString(),
                    VolunteerCode = reader["VolunteerCode"].ToString(),
                    VolunteerName = reader["VolunteerName"].ToString(),
                    Activities = reader["Activities"].ToString()
                };
            else
                throw new Exception("یافت نشد");
        }

        public List<Model.Voluntarily> Select()
        {
            var output = new List<Model.Voluntarily>();
            var reader = db.ExecuteReader("SELECT * FROM Voluntarilies");
            while (reader.Read())
            {
                output.Add(new Model.Voluntarily
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Title = reader["Title"].ToString(),
                    From = reader["From"].ToString(),
                    To = reader["To"].ToString(),
                    VolunteerCode = reader["VolunteerCode"].ToString(),
                    VolunteerName = reader["VolunteerName"].ToString(),
                    Activities = reader["Activities"].ToString()
                });
            }
            return output;
        }

        public void Insert(Model.Voluntarily voluntarily)
        {
            // Insert activity
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Title", Value = voluntarily.Title });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Activities", Value = voluntarily.Activities });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "VolunteerCode", Value = voluntarily.VolunteerCode });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "VolunteerName", Value = voluntarily.VolunteerName });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "From", Value = voluntarily.From });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "To", Value = voluntarily.To });
            db.ExecuteNonQuery(@"INSERT INTO Voluntarilies (Title, [From], [To], VolunteerName, VolunteerCode, Activities)
                VALUES (@Title, @From, @To, @VolunteerName, @VolunteerCode, @Activities)", parameters);

            // Get activity id
            int activityId = GetLastId();
        }

        public void Update(Model.Voluntarily voluntarily)
        {
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = voluntarily.Id });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Title", Value = voluntarily.Title });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Activities", Value = voluntarily.Activities });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "VolunteerCode", Value = voluntarily.VolunteerCode });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "VolunteerName", Value = voluntarily.VolunteerName });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "From", Value = voluntarily.From });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "To", Value = voluntarily.To });
            db.ExecuteNonQuery(@"UPDATE Voluntarilies SET
                                Title = @Title
                                ,Activities = @Activities
                                ,VolunteerCode = @VolunteerCode
                                ,VolunteerName = @VolunteerName
                                ,[From] = @From
                                ,[To] = @To
            WHERE Id = @Id", parameters);
        }

        public void Delete(int? Id)
        {
            if (Id == null)
                throw new Exception("شناسه نمی تواند خالی باشد");

            var output = new List<Model.Course>();
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = Id });
            db.ExecuteNonQuery("DELETE FROM Voluntarilies WHERE Id = @Id", parameters);
        }
    }
}
