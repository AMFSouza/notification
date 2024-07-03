namespace amatech.lab.notification.core;
public class MessageError
{
   public string class_name {get; set;}
   public string field_name {get; set;} 
   public string error {get; set;}

   public MessageError(string class_name, string field_name, string error)
   {
      this.class_name = class_name;
      this.field_name = field_name;
      this.error = error;
   }
}