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
        
        public int getNewID() => MemberDBContext.instance.GetID();
        public void insertMember(int id, string email, string passsword, string name, string city, string country) => MemberDBContext.instance.InsertMember(id, email, passsword, name, city, country);
        public void updateMember(Member member) => MemberDBContext.Instance.UpdateMember(member);

        public Member getMemberByID(int id) => MemberDBContext.instance.GetById(id);
    }
}
