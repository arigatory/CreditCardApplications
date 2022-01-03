using System;

namespace CreditCardApplications
{

    public interface ILicenseeData
    {
        string LicenseKey { get; }
    }

    public interface IServiceInformation
    {
        ILicenseeData License { get; }
    }

    public interface IFrequentFlyerNumberValidator
    {
        bool IsValid(string frequentFlyerNumber);
        void IsValid(string frequentFlyerNumber, out bool isValid);
        //string LicenseKey { get; }
        IServiceInformation ServiceInformation { get; }

        ValidationMode ValidationMode { get; set; }

        event EventHandler ValidatorLookupPerformed;
    }
}