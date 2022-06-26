using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member MemberLogin(string username, string password);
        IEnumerable<Member> GetByName(string name);
        void Delete(int id);
        public int getNewID();
        public void insertMember(int id, String email,String password, String name,String city,String country);
        public void updateMember(Member member);
        public Member getMemberByID(int id);
        public IEnumerable<string> GetCities();
        public IEnumerable<string> GetCountries();
    }
}
