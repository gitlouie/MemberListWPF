using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MembershipListWPF
{
    class MembershipData
    {

        public List<Member> GetMemberships()
        {
            List<Member> members = new List<Member>();

            string[] MembersText = System.IO.File.ReadAllLines(@"D:\Libraries\Desktop\c#\Members.txt");

            foreach(string line in MembersText)
            {
                string[] tokens = line.Split('|');

                if (tokens.Length > 2)
                {
                    Member newMem = new Member(tokens[0], tokens[1], tokens[2]);
                    members.Add(newMem);
                }

            }




            return members;
            
        }

    }
}
