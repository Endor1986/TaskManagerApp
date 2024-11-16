using System;
using TaskManagerApp.Interfaces;

namespace TaskManagerApp.Services
{
    public class LicenseManager : ILicenseManager
    {
        private readonly DateTime _expirationDate;

        // Konstruktor, der ein Ablaufdatum akzeptiert
        public LicenseManager(DateTime expirationDate)
        {
            _expirationDate = expirationDate;
        }

        public bool IsLicenseValid()
        {
            return DateTime.Now <= _expirationDate;
        }
    }
}
