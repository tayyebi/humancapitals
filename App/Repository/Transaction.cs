using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Repository
{
    class Transaction : UnitOfWork
    {
        public Model.Transaction Find(int? Id)
        {
            if (Id == null)
                throw new Exception("شناسه نمی تواند خالی باشد");

            var output = new List<Model.Course>();
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = Id });
            var reader = db.ExecuteReader("SELECT * FROM [Transactions] WHERE Id = @Id", parameters);
            if (reader.Read())
                return new Model.Transaction
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Amount = reader["Amount"].ToString(),
                    BankAccount = reader["BankAccount"].ToString(),
                    BankName = reader["BankName"].ToString(),
                    OwnerCode = reader["OwnerCode"].ToString(),
                    OwnerName = reader["OwnerName"].ToString(),
                    BankRefferalCode = reader["BankRefferalCode"].ToString(),
                    Date = reader["Date"].ToString(),
                    Notes = reader["Notes"].ToString()
                };
            else
                throw new Exception("یافت نشد");
        }

        public List<Model.Transaction> Select()
        {
            var output = new List<Model.Transaction>();
            var reader = db.ExecuteReader("SELECT * FROM [Transactions]");
            while (reader.Read())
            {
                output.Add(new Model.Transaction
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Amount = reader["Amount"].ToString(),
                    BankAccount = reader["BankAccount"].ToString(),
                    BankName = reader["BankName"].ToString(),
                    OwnerCode = reader["OwnerCode"].ToString(),
                    OwnerName = reader["OwnerName"].ToString(),
                    BankRefferalCode = reader["BankRefferalCode"].ToString(),
                    Date = reader["Date"].ToString(),
                    Notes = reader["Notes"].ToString()
                });
            }
            return output;
        }

        public void Insert(Model.Transaction transaction)
        {
            // Insert activity
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Amount", Value = transaction.Amount});
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "BankAccount", Value = transaction.BankAccount });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "BankName", Value = transaction.BankName });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "BankRefferalCode", Value = transaction.BankRefferalCode });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Date", Value = transaction.Date });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Notes", Value = transaction.Notes });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "OwnerName", Value = transaction.OwnerName });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "OwnerCode", Value = transaction.OwnerCode });
            db.ExecuteNonQuery(@"INSERT INTO [Transactions] (Amount, BankAccount, BankName, BankRefferalCode, [Date], Notes, [OwnerName], [OwnerCode])
                VALUES (@Amount, @BankAccount, @BankName, @BankRefferalCode, @Date, @Notes, @OwnerName, @OwnerCode)", parameters);

            // Get activity id
            int activityId = GetLastId();
        }

        public void Update(Model.Transaction transaction)
        {
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = transaction.Id });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Amount", Value = transaction.Amount });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "BankAccount", Value = transaction.BankAccount });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "BankName", Value = transaction.BankName });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "BankRefferalCode", Value = transaction.BankRefferalCode });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Date", Value = transaction.Date });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Notes", Value = transaction.Notes });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "OwnerName", Value = transaction.OwnerName });
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "OwnerCode", Value = transaction.OwnerCode });
            db.ExecuteNonQuery(@"UPDATE [Transactions] SET
                                Amount = @Amount
                                ,BankAccount = @BankAccount
                                ,BankName = @BankName
                                ,BankRefferalCode = @BankRefferalCode
                                ,Date = @Date
                                ,Notes = @Notes
                                ,OwnerName = @OwnerName
                                ,OwnerCode = @OwnerCode
            WHERE Id = @Id", parameters);
        }

        public void Delete(int? Id)
        {
            if (Id == null)
                throw new Exception("شناسه نمی تواند خالی باشد");

            var output = new List<Model.Course>();
            var parameters = new List<System.Data.SQLite.SQLiteParameter>();
            parameters.Add(new System.Data.SQLite.SQLiteParameter { ParameterName = "Id", Value = Id });
            db.ExecuteNonQuery("DELETE FROM [Transactions] WHERE Id = @Id", parameters);
        }
    }
}
