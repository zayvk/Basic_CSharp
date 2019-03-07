using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsUtliity;

namespace Day3.inheritance
{
    //default for memebrs: private:accesible within that class itself
    //public:accesible everywhere
   
    //protected:available within inheritance 


    class Account
    {
        public Account()
        {
            Console.WriteLine("Parent contr is called");
        }
        internal int AccountNo { get; set; }

        public string BranchName { get; set; }

          void getPassBookDetails()
        {
            Console.WriteLine("Passbook details is called");
        }
    }


    class SavingAccount : Account
    {
        public SavingAccount()
        {
            
            //Console.WriteLine(AccountNo + BranchName);
            //getPassBookDetails();
            //getPassBookDetails();
            Console.WriteLine("Child contr is called");
        }
    }

    class A: MathsUtility
    {
        A()
        {
            //add()
            //mul()  protected
           //div  not accesible as its internal

            //square()  protected +internal
        }
    }
    class inheritancedemo
    {
        static void Main(string[] args)
        {
            SavingAccount account = new SavingAccount();
            //account.
            //  account.getPassBookDetails();
            //account.AccountNo
            MathsUtliity.MathsUtility obj = new MathsUtility();

           // obj.
            Console.ReadLine();
        }

    }
}
