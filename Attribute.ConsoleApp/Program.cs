#define LOG_Info
using System.Reflection;
using Attribute.ConsoleApp.Models;
using LoggingComponent;
using ValidationComponent;

// [assembly: AssemblyDescription("Ambaaq Assembly")]
namespace Attribute.ConsoleApp
{
          public class Program
          {
                    public static void Main(string[] args)
                    {
                              Student st = new Student();
                              string Id = null;
                              string firstname = null;
                              string lastname = null;
                              Type stType = typeof(Student);
                              if(GetInput(stType, "Please enter a valid id ", "Id", out Id));
                              {
                                        System.Console.WriteLine(Id);
                                        st.Id = Convert.ToInt32(Id);
                              }
                              if(GetInput(stType, "Please enter a valid Name ", "FirstName", out firstname));
                              {
                                        st.FirstName = firstname;
                              }
                              if(GetInput(stType, "Please enter a valid Last name ", "LastName", out lastname));
                              {
                                        st.LastName = lastname;
                              }
                               Console.BackgroundColor= ConsoleColor.Red;
                              Console.ForegroundColor= ConsoleColor.White;
                              Console.WriteLine("Student registration successfull");
                              Console.ResetColor();
                              DisplayAssemblyInformation();
                    }
                    public static bool GetInput(Type type, string promptText,string fieldName,  out string fieldValue)
                    {
                              fieldValue = "";
                              string message = "";
                              do
                              {
                                        System.Console.WriteLine(promptText);
                                       string enteredvalue = enteredvalue = Console.ReadLine();
                                        if(!Validation.PropertyIsValid(type, enteredvalue, fieldName, out message))
                                        {
                                                  fieldValue = null;
                                                  Console.BackgroundColor= ConsoleColor.Red;
                                                  Console.ForegroundColor= ConsoleColor.Blue;
                                                  Console.WriteLine();
                                                  Console.ResetColor();
                                        }
                                        else
                                        {
                                                  fieldValue = enteredvalue;
                                                  break;
                                        }
                              } while (true);
                              return true;
                    }
                    private static void DisplayAssemblyInformation()
                    {
                              Assembly assembly = typeof(Program).Assembly;
                              AssemblyName assemblyName = assembly.GetName();
                              Version assemblyVersion = assemblyName.Version;
                              object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                             
                              System.Console.WriteLine($"AssemblyName = {assemblyName}");
                              System.Console.WriteLine($"AssemblyVersion = {assemblyVersion}");
                              
                              if(attributes.Length > 0)
                              {
                                        var assembleDescription =  attributes[0] as AssemblyDescriptionAttribute;
                                        System.Console.WriteLine($"AssemblyDescription = {assembleDescription.Description}");
                              }
                    }
          }
}