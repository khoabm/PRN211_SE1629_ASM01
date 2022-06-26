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
<<<<<<< HEAD
        public Member getMemberByEmail(String email) => MemberDBContext.instance.GetByEmail(email);
=======

        public IEnumerable<string> GetCities() => MemberDBContext.Instance.GetCity();

        public IEnumerable<string> GetCountries() => MemberDBContext.Instance.GetCountry();
>>>>>>> c828bc3e5f683d4e184574a2232136bc88184c63
    }
}
