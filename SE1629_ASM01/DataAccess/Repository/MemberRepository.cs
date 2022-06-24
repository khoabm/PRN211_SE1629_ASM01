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
        public IEnumerable<Member> GetMembers() => MemberDBContext.Instance.GetMembers();

        public Member MemberLogin(string username, string password) => MemberDBContext.Instance.MemberLogin(username, password);
    }
}
