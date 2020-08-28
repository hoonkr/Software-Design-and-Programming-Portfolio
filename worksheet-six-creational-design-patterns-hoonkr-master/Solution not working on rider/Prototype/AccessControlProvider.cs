using System;
using System.Collections;
using System.Collections.Generic;

namespace QuestionFour
{
    public static class AccessControlProvider
    {
        private static IDictionary<string, AccessControl> map = new Dictionary<string,AccessControl>();

        static AccessControlProvider()
        {
            Console.WriteLine("Fetiching data from external resources and creating access control objects...");
            map["USER"]= new AccessControl("USER","DO_WORK");
            map["ADMIN"] = new AccessControl("ADMIN","ADD/REMOVE USERS");
            map["MANAGER"] = new AccessControl("MANAGER","GENERATE/READ REPORTS");
            map["VP"] = new AccessControl("VP","MODIFY REPORTS");
        }
        public static AccessControl GetAccessControlObject(string controlLevel)
        {
            AccessControl ac = null;
            ac = map[controlLevel];
            if (ac != null)
            {
                return ac.Clone();
            }

            return null;
        }
    }
}