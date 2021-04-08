using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fintech.Helper
{
    public class Constant
    {
        public static class Role
        {
            public static string Admin = "Admin";
            public static string Business = "Business";
            public static string Contributor = "Contributor";
        }
        public static class StripeIntervals
        {
            public static string Weekly = "Weekly";
            public static string Monthly = "Monthly";
            public static string Every3Months = "Every 3 Months";
            public static string Every6Months = "Every 6 Months";
            public static string Yearly = "Yearly";
        }
        public static class Notification
        {
            public static class Title
            {
                public static string MemberShipSubscribed = "{Name} Memebership Subscribed";
            }
            public static class Body
            {
                public static string MemberShipSubscribed = "You successfully subscribed {Name} from {From} to {To}.";

            }
        }
    }
}
