namespace amatech.lab.notification.core;

public class Notification
{
   public List<MessageError> errors = [];

   public void AddError(MessageError message)
   {
    errors.Add(message);
   }

   public bool HasErrors()
   {
        return errors.Count > 0;
   }

   public List<MessageError> GetErrors()
   {
     return errors;
   }
    


}
