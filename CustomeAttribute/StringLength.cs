namespace CustomeAttribute;
 [AttributeUsage(System.AttributeTargets.Field | AttributeTargets.Parameter 
          | AttributeTargets.Property, AllowMultiple =false)]
public class StringLength : System.Attribute
{
          public int MinLength{get; set;}
          public string Message{get; set;}
          public int MaxLength{get; set;}
          public StringLength(int maxLength)
          {
                    SetProperties(maxLength);
          }
          public StringLength(int maxLength, string message)
          {
                    SetProperties(maxLength, message:message);
          }
          public StringLength(int maxLength, string message, int minLength)
          {
                    SetProperties(maxLength, minLength,  message);
          }
          public StringLength(int maxLength, int minLength)
          {
                    SetProperties(maxLength, minLength: minLength);
          }
          private void SetProperties( int maxLength, int? minLength=null, string message= "")
          {
                    if(message is "")
                    {
                              if(minLength is null)
                              {
                                        Message = "The minimum length for must be set";
                              }
                              else
                              {
                                        Message = "The minimum length will be 0 by default";
                              }
                    }
                    else
                    {
                              Message = message;
                    }
                    MaxLength = maxLength;
                    MinLength = minLength ?? 0;
          }
}
