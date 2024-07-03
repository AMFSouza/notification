using amatech.lab.notification.core.validator;

namespace amatech.lab.notification.core.entity;
public abstract class Entity : ValidatableInterface
{
    public Guid Id {get;}

    public Guid GetId()
    {
        return this.Id;
    }
}