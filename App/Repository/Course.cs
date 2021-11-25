using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository
{
    class  Course:UnitOfWork
    {
        public Course()
        {

        }

        public Model.Course Find(int ? Id)
        {
            if (Id == null)
                throw new Exception("شناسه نمی تواند خالی باشد");

            var output = new List<Model.Course>();
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = Id });
            var reader = db.ExecuteReader("SELECT * FROM Courses WHERE Id = @Id", parameters);
            if (reader.Read())
                return new Model.Course
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Title = reader["Title"].ToString(),
                    Notes = reader["Notes"].ToString(),
                    Calendar = reader["Calendar"].ToString(),
                    TeacherCode = reader["TeacherCode"].ToString(),
                    TeacherName = reader["TeacherName"].ToString(),
                    Fee = reader["Fee"].ToString(),
                    From = reader["From"].ToString(),
                    Plan = reader["Plan"].ToString(),
                    To = reader["To"].ToString()
                };
            else
                throw new Exception("یافت نشد");
        }

        public List<Model.Course> Select()
        {
            var output = new List<Model.Course>();
            var reader = db.ExecuteReader("SELECT * FROM Courses");
            while (reader.Read())
            {
                output.Add(new Model.Course
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Title = reader["Title"].ToString(),
                    Notes = reader["Notes"].ToString(),
                    Calendar = reader["Calendar"].ToString(),
                    TeacherCode = reader["TeacherCode"].ToString(),
                    TeacherName = reader["TeacherName"].ToString(),
                    Fee = reader["Fee"].ToString(),
                    From = reader["From"].ToString(),
                    Plan = reader["Plan"].ToString(),
                    To = reader["To"].ToString()
                });
            }
            return output;
        }

        public void Insert(Model.Course course)
        {
            // Insert activity
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Title", Value = course.Title });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Notes", Value = course.Notes });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Calendar", Value = course.Calendar });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "TeacherCode", Value = course.TeacherCode });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "TeacherName", Value = course.TeacherName });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Fee", Value = course.Fee });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "From", Value = course.From });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Plan", Value = course.Plan });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "To", Value = course.To });
            db.ExecuteNonQuery(@"INSERT INTO Courses (Title, Notes, Calendar, TeacherCode, TeacherName, Fee, [From], [Plan], [To])
                VALUES (@Title, @Notes, @Calendar, @TeacherCode, @TeacherName, @Fee, @From, @Plan, @To)", parameters);

            // Get activity id
            int activityId = GetLastId();
        }

        public void Update(Model.Course course)
        {
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = course.Id });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Title", Value = course.Title });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Notes", Value = course.Notes });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Calendar", Value = course.Calendar });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "TeacherCode", Value = course.TeacherCode });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "TeacherName", Value = course.TeacherName });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Fee", Value = course.Fee });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "From", Value = course.From });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Plan", Value = course.Plan });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "To", Value = course.To });
            db.ExecuteNonQuery(@"UPDATE Courses SET
                                Title = @Title
                                ,Notes = @Notes
                                ,Calendar = @Calendar
                                ,TeacherCode = @TeacherCode
                                ,TeacherName = @TeacherName
                                ,Fee = @Fee
                                ,[From] = @From
                                ,[Plan] = @Plan
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
            db.ExecuteNonQuery("DELETE FROM Courses WHERE Id = @Id", parameters);
        }

    }
}
