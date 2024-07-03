using amatech.lab.notification.core.validator;

namespace amatech.lab.notification.core.entity.validator;
public class PersonValidator : ValidatorInterface<Person>
{
    public Notification Validate(Person source)
    {
        Notification notification = new Notification();
        if ( String.IsNullOrEmpty(source.Name)) notification.AddError(new MessageError(source.Name, nameof(source.Name), "Name should not be empty"));
        if ( source.Age.ToString() is null || source.Age < 18) notification.AddError(new MessageError(source.Age.ToString(), nameof(source.Age), "Age should be greater than 18"));
        return notification;
    }
}