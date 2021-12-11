namespace ClassLibrary1
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Authenticate(string user, string pass)
        {
            if(user == Username && pass == Password)
                return true; 

            else return false;
        }
    }

    public class ProfileDetails
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; } 
        public string Gender { get; set; }
        public string CNIC { get; set; }
        public string LicenseNumber { get; set; }

    }
    public class Warden
    {
        Login wardenLogin;
        ProfileDetails wardenProfileDetails;


    }

    public class User
    {
        Login userLogin;
        ProfileDetails userProfileDetails;
    }

    public class Challan
    {
        public int ChallanId { get; set; }
        public string ChallanName { get; set; }
        public string DueDate { get; set; }



    }
}