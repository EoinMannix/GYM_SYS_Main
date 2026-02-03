using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_SYS
{
    internal class Member
    {

        public int MemberID { get; set; }
        public string MemberForename { get; set; }
        public string MemberSurename { get; set; }
        public DateTime MemberDOB { get; set; }
        public int MemberPhone { get; set; }
        public String MemberEmail { get; set; }
        public string MemberGender { get; set; }


        public Member (int MemberID, string MemberForename, string MemberSurename,
            DateTime MemberDOB, int MemberPhone, string MemberEmail, string MemberGender )
        {
            MemberID = MemberID;
            MemberForename = MemberForename;
            MemberSurename = MemberSurename;
            MemberDOB = MemberDOB;
            MemberPhone = MemberPhone;
            MemberEmail = MemberEmail;
            MemberGender = MemberGender;

        }

    }
}
