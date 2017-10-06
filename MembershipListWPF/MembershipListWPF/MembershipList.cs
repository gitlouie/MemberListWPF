using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipListWPF
{
    class MembershipList
    {
        private List<Member> memList;
        
        public MembershipList ()
        {
            memList = new List<Member>();
        }

        //Adds a membership to the list
        public void Add(Member m)
        {
            memList.Add(m);

        }

        public void Remove(Member m)
        {
            memList.Remove(m);
        }


        public void Write()
        {
            MembershipData d = new MembershipData();

            memList = d.GetMemberships();
            //MainWindow.MemTextBox = "";     

        }

        public void Save(Member m)
        {
            MembershipData d = new MembershipData();
            d.SaveMemberships(m);

        }




    }
}
