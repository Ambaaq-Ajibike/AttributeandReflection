namespace CustomeAttribute;
          [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter 
          | AttributeTargets.Property, AllowMultiple =false)]
public class RequiredAttribute : System.Attribute
{
          public string Message{get; set;}
          public RequiredAttribute() 
          {
                    Message = "Field {0} mut not be null";
          
          }
          public RequiredAttribute(string message) 
          {
                    Message = message;
          
          }
}
