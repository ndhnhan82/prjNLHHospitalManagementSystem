namespace NLHospitalLibrary
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    public class CurrentUser
    {
        private string user;
        private string position;


        public string UserName
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }

        public CurrentUser()
        {
            //
            // TODO: Add constructor logic here
            //
            UserName = string.Empty;
            Position = string.Empty;
        }

        public CurrentUser(string userID)
        {
            UserName = userID;
        }
    }
}
