using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository
{
    class Person:UnitOfWork
    {
        public Person():base()
        {

        }

        public Model.Person Find(int ? Id)
        {
            if (Id == null)
                throw new Exception("شناسه نمی تواند خالی باشد");

            var output = new List<Model.Person>();
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = Id });
            var reader = db.ExecuteReader("SELECT * FROM People WHERE Id = @Id", parameters);
            if (reader.Read())
                return new Model.Person
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Firstname = reader["Firstname"].ToString(),
                    Lastname = reader["Lastname"].ToString(),
                    BirthDate = reader["BirthDate"].ToString(),
                    Education = reader["Education"].ToString(),
                    Email = reader["Email"].ToString(),
                    Organization = reader["Organization"].ToString(),
                    Phone = reader["PhoneNumber"].ToString(),
                    Title = reader["Title"].ToString(),
                    Address = reader["Address"].ToString(),
                    Joined = reader["Joined"].ToString(),
                    Group = reader["Group"].ToString(),
                    ReferralCode = reader["ReferralCode"].ToString(),
                    ReferralMethod = reader["ReferralMethod"].ToString(),
                    ReferralName = reader["ReferralName"].ToString(),
                    Notes = reader["Notes"].ToString()
                };
            else
                throw new Exception("یافت نشد");
        }

        public List<Model.Person> Select()
        {
            var output = new List<Model.Person>();
            var reader = db.ExecuteReader("SELECT * FROM People");
            while (reader.Read())
            {
                output.Add(new Model.Person
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Firstname = reader["Firstname"].ToString(),
                    Lastname = reader["Lastname"].ToString(),
                    BirthDate = reader["BirthDate"].ToString(),
                    Education = reader["Education"].ToString(),
                    Email = reader["Email"].ToString(),
                    Organization = reader["Organization"].ToString(),
                    Phone = reader["PhoneNumber"].ToString(),
                    Title = reader["Title"].ToString(),
                    Address = reader["Address"].ToString(),
                    ReferralCode = reader["ReferralCode"].ToString(),
                    ReferralMethod = reader["ReferralMethod"].ToString(),
                    ReferralName = reader["ReferralName"].ToString(),
                    Notes = reader["Notes"].ToString()
                });
            }
            return output;
        }

        public void Insert(Model.Person person)
        {
            // Insert activity
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Firstname", Value = person.Firstname });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Lastname", Value = person.Lastname });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "BirthDate", Value = person.BirthDate });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "PhoneNumber", Value = person.Phone });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Email", Value = person.Email });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Joined", Value = person.Joined });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Education", Value = person.Education });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Organization", Value = person.Organization });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Group", Value = person.Group });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Address", Value = person.Address });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Title", Value = person.Title });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "ReferralMethod", Value = person.ReferralMethod });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "ReferralName", Value = person.ReferralName });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "ReferralCode", Value = person.ReferralCode });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Notes", Value = person.Notes });
            db.ExecuteNonQuery(@"INSERT INTO People (Firstname, Lastname, BirthDate, PhoneNumber, Email, Joined, Education, Organization, [Group], Address, Title, ReferralMethod, ReferralCode, ReferralName, Notes)
                VALUES (@Firstname, @Lastname, @BirthDate, @PhoneNumber, @Email, @Joined, @Education, @Organization, @Group, @Address, @Title, @ReferralMethod, @ReferralCode, @ReferralName, @Notes)", parameters);

            // Get activity id
            int activityId = GetLastId();
        }

        public void Update(Model.Person person)
        {
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = person.Id });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Firstname", Value = person.Firstname });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Lastname", Value = person.Lastname });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "BirthDate", Value = person.BirthDate });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "PhoneNumber", Value = person.Phone });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Email", Value = person.Email });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Joined", Value = person.Joined });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Education", Value = person.Education });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Organization", Value = person.Organization });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Group", Value = person.Group });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Address", Value = person.Address });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Title", Value = person.Title });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "ReferralMethod", Value = person.ReferralMethod });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "ReferralName", Value = person.ReferralName });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "ReferralCode", Value = person.ReferralCode });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Notes", Value = person.Notes });
            db.ExecuteNonQuery(@"UPDATE People SET
                                Firstname = @Firstname
                                ,Lastname = @Lastname
                                ,BirthDate = @BirthDate
                                ,PhoneNumber = @PhoneNumber
                                ,Email = @Email
                                ,Joined = @Joined
                                ,Education = @Education
                                ,Organization = @Organization
                                ,[Group] = @Group
                                ,Address = @Address
                                ,Title = @Title
                                ,ReferralMethod = @ReferralMethod
                                ,ReferralCode = @ReferralCode
                                ,ReferralName = @ReferralName
                                ,Notes = @Notes
            WHERE Id = @Id", parameters);
        }

        public void Delete(int? Id)
        {
            if (Id == null)
                throw new Exception("شناسه نمی تواند خالی باشد");

            var output = new List<Model.Person>();
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = Id });
            db.ExecuteNonQuery("DELETE FROM People WHERE Id = @Id", parameters);
        }

    }
}
