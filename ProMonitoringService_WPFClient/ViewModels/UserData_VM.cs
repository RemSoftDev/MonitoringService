using ProMonitoringService_WPFClient.CommunicationWithServer.UrlParameters;
using ProMonitoringService_WPFClient.Contracts.ServerResponseObjects;
using System;
using System.Collections.ObjectModel;

namespace ProMonitoringService_WPFClient.ViewModels
{
    public sealed class UserData_VM : ViewModel
    {
        public static UserData_VM FromLoginResponse(LoginResponse loginResponse, LoginParameters loginParams) =>
            new UserData_VM
            {
                UserID = int.Parse(loginResponse.UserID),
                Email = loginResponse.Email,
                Token = loginResponse.Token,
                PasswordHashCode = loginParams.Password.GetHashCode()
            };

        public int UserID { get; set; }
        public string Token { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public PhoneNumberData PhoneNumber { get; set; }
        public Uri ImageSrc { get; set; }
        public string Email { get; set; }
        public object PasswordHashCode { get; set; }
        public string RecoveryEmail { get; set; }
        public int Points { get; set; }
        public ObservableCollection<UserData_VM> Friends { get; set; } = new ObservableCollection<UserData_VM>();

        public sealed class PhoneNumberData
        {
            public string CountryCode { get; set; }
            public string OperatorCode { get; set; }
            public string Number { get; set; }
            public override string ToString() => $"{CountryCode} ({OperatorCode}) {Number}";


            public static PhoneNumberData Fake = new PhoneNumberData
            {
                CountryCode = "xx",
                OperatorCode = "xxx",
                Number = "xxxxxxx"
            };

            public static bool TryParse(string phoneNumberAsString, ref PhoneNumberData phoneNumber)
            {
                var mathcResult = InputValidationHelper.PhoneNumberValidator.Match(phoneNumberAsString);
                if (mathcResult.Success)
                {
                    phoneNumber = new PhoneNumberData
                    {
                        CountryCode = mathcResult.Groups[1].Value,
                        OperatorCode = mathcResult.Groups[2].Value.Replace("(", "").Replace(")", ""),
                        Number = mathcResult.Groups[3].Value
                    };

                    return true;
                }
                else return false;
            }
        }
    }

}
