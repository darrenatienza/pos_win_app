using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
        public static DateTime LastDayOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }
        public static DateTime FirstDayOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }
    }
    public static class Utils
    {
        

        public static double ConvertToDouble(string value)
        {
            double outValue = 0.0;
            return !double.TryParse(value, out outValue) ? 0.0 : outValue;
        }

        public static int ConvertToInteger(string value)
        {
            int outValue = 0;
            return !int.TryParse(value, out outValue) ? 0 : outValue;
        }

        public static int CalculateAge(DateTime dateOfBirth)
        {
            // present date
            var today = DateTime.UtcNow;
            // calculate age
            var age = today.Year - dateOfBirth.Year;
            // go back to the year in case was born on leap year
            if (dateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        public static string GetAliasName(string firstName, string lastName)
        {
            return string.Format("{0} {1}", firstName.Substring(0, 1), lastName);
        }
        public static string ToValidFullNameFormat(string firstName, string middleName, string lastName)
        {
            if (middleName != "")
            {
                return string.Format("{0} {1}. {2}", firstName, middleName.Substring(0, 1), lastName);
            }
            return string.Format("{0} {1}", firstName, lastName);
        }
        public static string RandomNumbers(int length)
        {
            const string chars = "0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string GetAppSettingValue(string key)
        {
            return ConfigurationManager.AppSettings[key].ToString();
        }
        public static void EncryptConnectionString(bool encrypt, string fileName)
        {
            Configuration configuration = null;

            // Open the configuration file and retrieve the connectionStrings section.
            configuration = ConfigurationManager.OpenExeConfiguration(fileName);
            ConnectionStringsSection configSection = configuration.GetSection("connectionStrings") as ConnectionStringsSection;
            if ((!(configSection.ElementInformation.IsLocked)) && (!(configSection.SectionInformation.IsLocked)))
            {
                if (encrypt && !configSection.SectionInformation.IsProtected)
                {
                    //this line will encrypt the file
                    configSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }

                if (!encrypt && configSection.SectionInformation.IsProtected)//encrypt is true so encrypt
                {
                    //this line will decrypt the file. 
                    configSection.SectionInformation.UnprotectSection();
                }
                //re-save the configuration file section
                configSection.SectionInformation.ForceSave = true;
                // Save the current configuration

                configuration.Save();
                //configFile.FilePath 

            }

        }
       
        internal class ProcessConnection
        {
            public static ConnectionOptions ProcessConnectionOptions()
            {
                ConnectionOptions options = new ConnectionOptions();
                options.Impersonation = ImpersonationLevel.Impersonate;
                options.Authentication = AuthenticationLevel.Default;
                options.EnablePrivileges = true;
                return options;
            }
            public static ManagementScope ConnectionScope(string machineName, ConnectionOptions options, string path)
            {
                ManagementScope connectScope = new ManagementScope();
                connectScope.Path = new ManagementPath(@"\\" + machineName + path);
                connectScope.Options = options;
                connectScope.Connect();
                return connectScope;
            }
        }
        public class COMPortInfo
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public COMPortInfo()
            {

            }
            public static List<COMPortInfo> GetCOMPortsInfo()
            {
                List<COMPortInfo> comPortInfoList = new List<COMPortInfo>();
                ConnectionOptions options = ProcessConnection.ProcessConnectionOptions();
                ManagementScope connectionScope = ProcessConnection.ConnectionScope(Environment.MachineName, options, @"\root\CIMV2");
                ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_PnPEntity WHERE ConfigManagerErrorCode = 0");
                ManagementObjectSearcher comPortSearcher = new ManagementObjectSearcher(connectionScope, objectQuery);
                using (comPortSearcher)
                {
                    string caption = null;
                    foreach (ManagementObject obj in comPortSearcher.Get())
                    {
                        if (obj != null)
                        {
                            object captionObj = obj["Caption"];
                            if (captionObj != null)
                            {
                                caption = captionObj.ToString();
                                if (caption.Contains("(COM"))
                                {
                                    COMPortInfo comPortInfo = new COMPortInfo();
                                    comPortInfo.Name = caption.Substring(caption.LastIndexOf("(COM")).Replace("(", string.Empty).Replace(")", string.Empty);
                                    comPortInfo.Description = caption;
                                    comPortInfoList.Add(comPortInfo);
                                }
                            }
                        }
                    }
                    return comPortInfoList;
                }

            }
        }
        public enum ReservationStatus
        {
            None,
            Borrowed,
            Returned
        }

        public static DateTime ConvertToDateTime(string value)
        {
            DateTime outValue = DateTime.Now;
            return !DateTime.TryParse(value, out outValue) ? DateTime.Now : outValue;
        }
    }

    public static class CurrentUser
    {
        public static int UserID { get; set; }
        public static string Name { get; set; }
        public static List<string> Permissions { private get; set; }
        public static List<string> Roles { private get; set; }
        public static bool HasPermission(string permissionName)
        {
            if (UserID == 1)
            {
                return true;
            }

            var permission = Permissions.Where(p => p.ToUpper() == permissionName.ToUpper()).FirstOrDefault();
            if (permission != null)
            {
                return true;
            }

            return false;
        }
        public static bool HasRoles(string uRole)
        {
            if (UserID == 1)
            {
                return true;
            }

            var role = Roles.Where(p => p.ToUpper() == uRole.ToUpper()).FirstOrDefault();
            if (role != null)
            {
                return true;
            }

            return false;
        }
    }
   
}

