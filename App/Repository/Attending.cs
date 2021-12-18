using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Repository
{
    class Attending : UnitOfWork
    {
        public Model.Attending Find(int? Id)
        {
            if (Id == null)
                throw new Exception("شناسه نمی تواند خالی باشد");

            var output = new List<Model.Attending>();
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = Id });
            var reader = db.ExecuteReader("SELECT * FROM Attendings WHERE Id = @Id", parameters);
            if (reader.Read())
                return new Model.Attending
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    CourseId = Convert.ToInt32(reader["CourseId"].ToString()),
                    FinalMark = Convert.ToInt32(reader["FinalMark"].ToString()),
                    FinalStatus = reader["FinalStatus"].ToString(),
                    ParticipantCode = reader["ParticipantCode"].ToString(),
                    ParticipantName = reader["ParticipantName"].ToString(),
                    Submit = reader["Submit"].ToString()
                };
            else
                throw new Exception("یافت نشد");
        }

        public List<Model.Attending> Select()
        {
            var output = new List<Model.Attending>();
            var reader = db.ExecuteReader("SELECT * FROM Attendings");
            while (reader.Read())
            {
                output.Add(new Model.Attending
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    CourseId = Convert.ToInt32(reader["CourseId"].ToString()),
                    FinalMark = Convert.ToInt32(reader["FinalMark"].ToString()),
                    FinalStatus = reader["FinalStatus"].ToString(),
                    ParticipantCode = reader["ParticipantCode"].ToString(),
                    ParticipantName = reader["ParticipantName"].ToString(),
                    Submit = reader["Submit"].ToString()
                });
            }
            return output;
        }

        public void Insert(Model.Attending attending)
        {
            // Insert activity
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "CourseId", Value = attending.CourseId });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Submit", Value = attending.Submit });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "ParticipantCode", Value = attending.ParticipantCode });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "ParticipantName", Value = attending.ParticipantName });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "FinalMark", Value = attending.FinalMark });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "FinalStatus", Value = attending.FinalStatus });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "CourseId", Value = attending.CourseId });
            db.ExecuteNonQuery(@"INSERT INTO Courses (CourseId, [Submit], ParticipantCode, ParticipantName, FinalMark, FinalStatus)
                VALUES (@CourseId, @Submit, @ParticipantCode, @ParticipantName, @FinalMark, @FinalStatus)", parameters);

            // Get activity id
            int activityId = GetLastId();
        }

        public void Update(Model.Attending attending)
        {
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = attending.Id });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "CourseId", Value = attending.CourseId });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "ParticipantCode", Value = attending.ParticipantCode });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "ParticipantName", Value = attending.ParticipantName });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "FinalMark", Value = attending.FinalMark });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "FinalStatus", Value = attending.FinalStatus });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "CourseId", Value = attending.CourseId });
            db.ExecuteNonQuery(@"UPDATE Attendings SET
                                CourseId = @CourseId
                                ,ParticipantCode = @ParticipantCode
                                ,ParticipantName = @ParticipantName
                                ,FinalMark = @FinalMark
                                ,FinalStatus = @FinalStatus
            WHERE Id = @Id", parameters);
        }

        public void Delete(int? Id)
        {
            if (Id == null)
                throw new Exception("شناسه نمی تواند خالی باشد");

            var output = new List<Model.Course>();
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = Id });
            db.ExecuteNonQuery("DELETE FROM Attendings WHERE Id = @Id", parameters);
        }
    }
}