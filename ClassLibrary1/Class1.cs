namespace ClassLibrary1
{
    //Identification?

    public class System
    {
        
    }
    public class Login
    {
        public string CNIC { get; set; }
        public string Password { get; set; }
        public Login(string user, string pass)
        {
            CNIC = user;
            Password = pass;
        }

        public bool Authenticate(string user, string pass)
        {
            if (user == CNIC && pass == Password)
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
        public string LicenseNumber { get; set; }

    }
    public class Warden
    {
        public Login wardenLogin;

        private ProfileDetails wardenProfileDetails;

        public void IssueChallan(User user)
        {
            Challan challan = new Challan();
            challan.ChallanId = 1;
            challan.ChallanName = "No License";
            challan.DueDate = "10/10/2021";
            user.challansList.Add(challan);
        }
        public void ViewWardenDetails()
        {
            Console.WriteLine(wardenProfileDetails);
        }
        public void ViewUserDetails(User user)
        {
            user.ViewAllDetails();
        }

    }

    public class User
    {
        public Login userLogin;
        public ProfileDetails userProfileDetails;
        public List<Challan> challansList; //ordered by not paid
        public List<Warning> warningsList; //ordered by no of warnings
        public List<Vehicle> registeredVehiclesList;
        public Wallet myWallet;

        public void Login()
        {
            userLogin.Authenticate("anns","1234");
        }

        public void Logout()
        {
            //logout
        }
        public void ViewProfileDetails()
        {
            //print cnic,name,phone,challans,warning, etc
        }

        public void EditProfile() { 
            //userProfileDetails.Name = new name; etc etc
        }
        public void ViewChallan()
        {
            //print challan name,id,etc
        }
        public void PayChallan(Challan challan)
        {
            //Payment d = new Payment();
            //depending on the choice of payment
            CashPayment cashPayment = new CashPayment();
            cashPayment.PayChallan();
            //print receipt after cash payment

            CreditPayment creditPayment = new CreditPayment();
            creditPayment.PayChallan();

            BankPayment bankPayment = new BankPayment();
            bankPayment.PayChallan();

            myWallet.walletPayment.PayChallan();
            //challansList.Find(challan).isPaid = true;
        }
        public void ViewWarnings()
        {

        }

        public void ViewVehicles()
        {

        }

        public void ManageWallet()
        {
            myWallet.ViewWallet();
            myWallet.AddMoneyInWallet();
        }


        public void ViewAllDetails()
        {

        }
    }

    public class Challan
    {
        public int ChallanId { get; set; }
        public string ChallanName { get; set; }
        public string DueDate { get; set; }
        public bool isPaid { get; set; }

        public int ChallanAmount { get; set; }
    }

    public class Vehicle
    {
        public int VehiclePlateNumber { get; set; }
        public string VehicleName { get; set; }
        public string VehicleModel { get; set; }

        //...

    }

    abstract public class Payment
    {
        public int Amount { get; set; }
        public int MoneyIn { get; set; }
        public int MoneyOut { get; set; }
        abstract public void PayChallan();
    }

    public class CashPayment : Payment {
        public override void PayChallan()
        {
            throw new NotImplementedException();
        }
    }

    public class Wallet
    {
        public int TotalAmount { get; set; }
        public WalletPayment walletPayment;
        public void AddMoneyInWallet()
        {

        }

        public void ViewWallet()
        {

        }

    }
    public class WalletPayment : Payment
    {
        string totalWalletAmount;
        public override void PayChallan()
        {
            throw new NotImplementedException();
        }
    }

    public class CreditPayment : Payment {
        public override void PayChallan()
        {
            throw new NotImplementedException();
        }

    }

    public class BankPayment : Payment {
        public override void PayChallan()
        {
            throw new NotImplementedException();
        }

    }

    public class ChallanReceipt
    {
        public string ChallanId { get; set;}
        public string ChallanName { get; set; }
        public string PayTimeAndDate{ get; set; }

        public void PrintReceipt()
        {

        }
    }
    public class Warning
    {
        public string Id { get; set; }
        public string WarningName { get; set; }
        public string WarningDate { get; set; }

    }
}