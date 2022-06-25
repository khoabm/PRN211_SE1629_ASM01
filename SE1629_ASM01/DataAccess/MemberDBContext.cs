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
    }
}
