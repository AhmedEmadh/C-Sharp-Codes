using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
namespace WindowsRegisteryTest
{
    internal class Program
    {
        static void SetRegisteryValue()
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\TestMyRegisteryOnWindows";
            string ValueName = "Test";
            string ValueData = "TestValue";

            try
            {
                Registry.SetValue(KeyPath, ValueName, ValueData, RegistryValueKind.String);
                Console.WriteLine($"Registery Value {ValueName} Set To {ValueData} Successfully");
            }
            catch
            {
                Console.WriteLine("An Error Occured");
            }
        }
        static void ReadRegistryValue()
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\TestMyRegisteryOnWindows";
            string ValueName = "Test";
            try
            {
                String Value = Registry.GetValue(KeyPath, ValueName, null) as string;
                if (Value != null)
                {
                    Console.WriteLine($"Registery Value {ValueName} Is {Value}");
                }
                else
                {
                    Console.WriteLine($"Registery Value {ValueName} Not Found");
                }
            }
            catch
            {
                Console.WriteLine("An Error Occured");
            }
        }
        static void DeleteRegistry()
        {
            // Specify the registry key path and value name
            string keyPath = @"SOFTWARE\TestMyRegisteryOnWindows";
            string valueName = "Test";


            try
            {
                // Open the registry key in read/write mode with explicit registry view
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                    {
                        if (key != null)
                        {
                            // Delete the specified value
                            key.DeleteValue(valueName);


                            Console.WriteLine($"Successfully deleted value '{valueName}' from registry key '{keyPath}'");
                        }
                        else
                        {
                            Console.WriteLine($"Registry key '{keyPath}' not found");
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("UnauthorizedAccessException: Run the program with administrative privileges.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        static void Main(string[] args)
        {
            //SetRegisteryValue();
            //ReadRegistryValue();
            //DeleteRegistry();

        }
    }
}
