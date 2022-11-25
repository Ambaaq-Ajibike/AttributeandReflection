using System.Reflection;
using CustomeAttribute;

namespace ValidationComponent;
public static class Validation
{
          public static bool PropertyIsValid(Type type, string value, string elementName, out string message)
          {
                    PropertyInfo p = type.GetProperty(elementName);
                    List<System.Attribute> attributes = p.GetCustomAttributes().ToList();
                    message = "";
                    foreach (var item in attributes)
                    {
                              switch (item)
                              {
                                        case RequiredAttribute ra:
                                                  if(!FieldRequiredIsValid(value))
                                                  {
                                                            message = string.Format(ra.Message, p.Name);
                                                            return false;
                                                  }
                                                  break;
                                        case StringLength sl:
                                                  if(!FieldRequiredStringLengthIsValid(sl, value))
                                                  {
                                                            message = string.Format(sl.Message, p.Name);
                                                            return false;
                                                  }
                                                  break;
                              }
                    }
                    return true;
          }
          private static bool FieldRequiredIsValid(string value)
          {
                    if(!string.IsNullOrEmpty(value)) return true;
                    return false;
          }
          private static bool FieldRequiredStringLengthIsValid(StringLength sl, string value)
          {
                    if(value.Length >= sl.MinLength  && value.Length <= sl.MaxLength) return true;
                    return false;
          }
}
