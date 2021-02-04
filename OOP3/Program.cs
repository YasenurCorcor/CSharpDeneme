using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personelFinanceCreditManager = new PersonelFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLogggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            ApplicationManager applitacionManager = new ApplicationManager();
            applitacionManager.MakeAnApplication(new TradesmanCreditManager(), loggers);


            List<ICreditManager> credits = new List<ICreditManager>() { personelFinanceCreditManager, vehicleCreditManager };
            //applitacionManager.MakeCreditPrenotification(credits);
        }
    }
}
