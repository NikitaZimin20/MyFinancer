using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SqlCrud
    {
        private readonly string _connectionString;
        private DataAccess db = new DataAccess();
        private  BasicModels _models = new BasicModels();

        public SqlCrud(string connectionstring)
        {
            _connectionString = connectionstring;
        }
        public void AddUserInfo(string name,string surname)
        {
            string sql= "INSERT INTO(UserInformation)  Values(@name,@surname)";
            db.SaveData(sql, new { name, surname }, _connectionString);
        }
        public void AddAutorizationInfo(string username,string password)
        {

            string sql = "INSERT INTO(AutorizationData)  Values(@username,@password,@userid)";
            db.SaveData(sql, new { username,password }, _connectionString);
        }
        public void AddBalance(decimal sum,string reason,DateTime date)
        {
            int user_id = _models.CurrentID;
            string sql = "Insert into IncomeBalance Values(@sum,@reason,@date,@user_id)  ";
            db.SaveData(sql, new {sum,reason,date,user_id}, _connectionString);
        }
        public List<BasicModels> GetAllContacts(string username)
        {
            string sql = "select ID AS Currentid FROM WHERE Username=@username ";

            return db.LoadData<BasicModels, dynamic>(sql, new {username }, _connectionString);
        }
    }
}
