using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cycling.Web.Common
{
    public static class Constants
    {
        public static int MAX_STRING_LENGTH { get { return 40; } }
        public static string INVALID_INT_MSG { get { return "Can not be NULL"; } }
        public static string INVALID_FIRST_NAME_MSG { get { return "Invalid First Name"; } }
        public static string INVALID_LAST_NAME_MSG { get { return "Invalid Last Name"; } }
        public static string INVALID_TEAM_MSG { get { return "Invalid Team"; } }

    }
}