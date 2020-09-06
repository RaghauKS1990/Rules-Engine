using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessRulesEngine.Interfaces;
using BusinessRulesEngine.Models;
using BusinessRulesEngine.Notification;

namespace BusinessRulesEngine
{  
    public  class StartUp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Business Rules Engine : Select below option for different payments");
            Console.WriteLine("\n");
            Console.WriteLine("01 - Physical Products");
            Console.WriteLine("02 - Books");
            Console.WriteLine("03 - Membership");
            Console.WriteLine("04 - Upgrade to Membership");
            Console.WriteLine("05 - Membership or Upgrade");
            Console.WriteLine("06 - LearningToSki");
            Console.WriteLine("07 - Physical Products or Books");

            string selectedOption = Console.ReadLine();

            switch (Convert.ToInt32(selectedOption))
            {
                case 1:

                    //PhysicalProducts PhysicalProducts = new PhysicalProducts();

                    PaymentNotification PhysicalProducts = new PaymentNotification(new PhysicalProducts());
                    //if (PhysicalProducts.PackingSlip() && PhysicalProducts.AgentCommission())
                    if (PhysicalProducts.DoPaymentNotify())
                    {
                        Console.WriteLine("Physical Products : Packing slip Generated for shiping");
                        //Console.WriteLine("Physical Products or Books : Generated a Commission payment for agent");
                    }
                    else
                    {
                        Console.WriteLine("Physical Products : Packing slip not Generated for shiping");
                        //Console.WriteLine("Physical Products or Books : Generated a Commission payment for agent");
                    }                  
                  
                    break;
                case 2:

                    //Books book = new Books();

                    PaymentNotification book = new PaymentNotification(new PhysicalProducts());
                    //if (book.PackingSlip() && book.AgentCommission())
                    if (book.DoPaymentNotify())
                    {
                        Console.WriteLine("Books : Duplicate packing slip Created for the royalty department");
                        //Console.WriteLine("Physical Products or Books : Generated a Commission payment for agent");
                    }
                    else
                    {
                        Console.WriteLine("Books : Duplicate packing slip not Created for the royalty department");
                        //Console.WriteLine("Physical Products or Books : Generated a Commission payment for agent");
                    }

                    break;
                case 3:

                    IActivate iActivate = new Membership();

                    if (iActivate.Activate())
                    {
                        Console.WriteLine("Membership : Membership Activated");
                    }
                    else
                    {
                        Console.WriteLine("Membership :  Membership not Activated");
                    }
                    break;
                case 4:
                    IUpgrade iUpgrade = new UpgradeMembership();

                    if (iUpgrade.Upgrade())
                    {
                        Console.WriteLine("Upgrade to Membership : Applied for upgrade");
                    }
                    else
                    {
                        Console.WriteLine("Upgrade to Membership : Not Applied for upgrade");
                    }
                    break;
                case 5:

                    //we can pass eiher new Membership() or new UpgradeMembership(), Both are inherited by IEmailService
                    EmailNotification emailNotification = new EmailNotification(new UpgradeMembership());

                    if (emailNotification.DoEmailNotify())
                    {
                        Console.WriteLine("Membership or Upgrade : Email Notification sent to owner about Activation/Upgrade ");
                    }
                    else
                    {
                        Console.WriteLine("Membership or Upgrade : Email Notification not sent to owner about Activation/Upgrade ");
                    }

                    break;
                case 6:

                    PaymentNotification learningToSki = new PaymentNotification(new LearningToSki());

                    if (learningToSki.DoPaymentNotify())
                    {
                        Console.WriteLine("LearningToSki : Free First Aid Vedio Added for packing slip");
                    }
                    else
                    {
                        Console.WriteLine("LearningToSki : Free First Aid Vedio not Added for packing slip");
                    }
                    
                    break;
                case 7:

                    //we can pass eiher new PhysicalProducts() or new Book(), Both are inherited by IAgentCommission
                    AgentCommissionNotification iAgentCommission = new AgentCommissionNotification(new PhysicalProducts());

                    if (iAgentCommission.DoAgentCommissionNotify())
                    {
                        Console.WriteLine("Physical Products or Books : Agent Commission payment Generated");
                    }
                    else
                    {
                        Console.WriteLine("Physical Products or Books : Agent Commission payment not Generated");
                    }
                  
                    break;
                default:
                    Console.WriteLine("Unexpected option selected");
                    break;
            }

            Console.ReadLine();

        }
    }
}
