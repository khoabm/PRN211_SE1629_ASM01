using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void Delete(int id) => MemberDBContext.Instance.Delete(id);

        public IEnumerable<Member> GetByName(string name) => MemberDBContext.Instance.GetByName(name);

        public IEnumerable<Member> GetMembers() => MemberDBContext.Instance.GetMembers();

        public Member MemberLogin(string username, string password) => MemberDBContext.Instance.MemberLogin(username, password);
        
    }
}
