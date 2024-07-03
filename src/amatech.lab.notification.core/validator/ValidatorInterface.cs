using amatech.lab.notification.core.entity;

namespace amatech.lab.notification.core.validator;

public interface ValidatorInterface<T> where T : ValidatableInterface
{
    Notification Validate(T source);
}