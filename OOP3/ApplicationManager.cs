using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void MakeAnApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //injection
            //
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            // HousingCreditManager housingCreditManager = new HousingCreditManager();
            // housingCreditManager.Calculate();
            //all application are housing credit.we dont want that

        }

        // MakeCreditPrenotification--KrediOnBilgilendirmesiYap
        public void MakeCreditPrenotification(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();

            }
        }
    }
}
