using BusinessObject;
using System.Data;

namespace DataAccess
{
    public class MemberDBContext : BaseDAL
    {
        public static MemberDBContext instance = null;
        public static readonly object _instanceLock = new object();
        private MemberDBContext() { }
        public static MemberDBContext Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (instance == null)
                        instance = new MemberDBContext();
                }
                return instance;
            }
        }

        


        //GET ALL LIST OF MEMBERS
        public IEnumerable<Member> GetMembers()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select id, email, password, member_name, city, country FROM Member";
            var members = new List<Member>();
            try
            {
                dataReader = StockDataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    members.Add(new Member
                    {
                        Id = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        Password = dataReader.GetString(2),
                        Name = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    });
                }
                return members;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
        }

        // GET NEWEST ID NUMBER
        public int GetID()
        {
            int Id = -1;
            IDataReader dataReader = null;
            string SQLSelect = "select top 1 id from Member order by id desc";
            try
            {
                dataReader = StockDataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                if (dataReader.Read()) Id = dataReader.GetInt32(0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                
                dataReader.Close();
                CloseConnection();
                
            }
            return Id+1;
        }

        //CHECK LOGIN MEMBER IF EXIST
        public Member MemberLogin(string email, string password)
        {
            Member member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select id, email, password, member_name, city, country FROM Member Where email=@email AND password=@password";
            try
            {
                var param = StockDataProvider.CreateParameter("@email", 50, email, DbType.String);
                var param2 = StockDataProvider.CreateParameter("@password", 30, password, DbType.String);
                dataReader = StockDataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param, param2);
                if (dataReader.Read())
                {
                    member = new Member
                    {
                        Id = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        Password = dataReader.GetString(2),
                        Name = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)

                    };
                }
                return member;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        //SEARCH
        public IEnumerable<Member> GetByName(string name)
        {
            var members = new List<Member>();
            IDataReader dataReader = null ;
            string SQLSelect = "Select * FROM Member WHERE member_name LIKE '%' + @name + '%'";
            try
            {
                var param = StockDataProvider.CreateParameter("@name", 30, name, DbType.String);
                dataReader = StockDataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection,param);
                while (dataReader.Read())
                {
                    members.Add(new Member
                    {
                        Id = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        Password = dataReader.GetString(2),
                        Name = dataReader.GetString(3),    
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members ;
        }
        public Member GetById(int id)
        {
            Member member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select * FROM Member WHERE id=@id";
            try
            {
                var param = StockDataProvider.CreateParameter("@id", 4, id, DbType.Int32);
                dataReader = StockDataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new Member
                    {
                        Id = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        Password = dataReader.GetString(2),
                        Name = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }
        //DELETE
        public void Delete(int id)
        {
            try
            {
                Member member = GetById(id);
                if (member != null)
                {
                    string SQLDelete = "Delete Member WHERE id=@id";
                    var param = StockDataProvider.CreateParameter("@id", 4, id, DbType.Int32);
                    StockDataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("Member does not exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { CloseConnection(); }
        }
        //UPDATE MEMBER
        public void UpdateMember(Member member)
        {
            IDataReader dataReader = null;
            Boolean check = false;
            string SQLUpdate = "update Member " +
                "set id = @id1, email = @email, password = @password, member_name = @name, city = @city, country = @country where id = @id2";
            try
            {
                var param1 = StockDataProvider.CreateParameter("@id1", 50, member.Id, DbType.Int32);
                var param2 = StockDataProvider.CreateParameter("@email", 50, member.Email, DbType.String);
                var param3 = StockDataProvider.CreateParameter("@password", 30, member.Password, DbType.String);
                var param4 = StockDataProvider.CreateParameter("@name", 30, member.Name, DbType.String);
                var param5 = StockDataProvider.CreateParameter("@city", 30, member.City, DbType.String);
                var param6 = StockDataProvider.CreateParameter("@country", 30, member.Country, DbType.String);
                var param7 = StockDataProvider.CreateParameter("@id2", 50, member.Id, DbType.Int32);
                StockDataProvider.Update(SQLUpdate, CommandType.Text, param1, param2, param3, param4, param5, param6, param7);
                check = true;
            }
            catch (Exception ex)
            {
                check = false;
                throw new Exception(ex.Message);
            }
        }
        // INSERT A MEMBER TO LIST
        public void InsertMember(int id, string email, string password, string name, string city, string country)
        {
            Member member = null;
            IDataReader dataReader = null;
            Boolean check = false;
            string SQLInsert = "insert into Member values(@id, @email, @password, @name, @city, @country)";
            try
            {
                var param1 = StockDataProvider.CreateParameter("@id", 50, id, DbType.Int32);
                var param2 = StockDataProvider.CreateParameter("@email", 50, email, DbType.String);
                var param3 = StockDataProvider.CreateParameter("@password", 30, password, DbType.String);
                var param4 = StockDataProvider.CreateParameter("@name", 30, name, DbType.String);
                var param5 = StockDataProvider.CreateParameter("@city", 30, city, DbType.String);
                var param6 = StockDataProvider.CreateParameter("@country", 30, country, DbType.String);
                StockDataProvider.Insert(SQLInsert, CommandType.Text, param1, param2, param3, param4, param5, param6);
                check = true;
            }
            catch (Exception ex)
            {
                check = false;
                throw new Exception(ex.Message);
            }
           // return check;
        }
    }
}
