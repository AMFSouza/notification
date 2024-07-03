using amatech.lab.notification.core.entity.validator;
using amatech.lab.notification.core.validator;

namespace amatech.lab.notification.core.entity;
public class Person : Entity
{
    public string Name {get; private set;}
    public int Age {get; private set;}
    public bool IsActive {get; private set;}

    public Person(Guid id, string name, int age, bool is_active = true) 
    {
    
        this.Name = name;
        this.Age = age;
        this.IsActive = is_active;
    }

    public static Person Create(string name, int age)
    {
        var id = Guid.NewGuid();
        var is_active = true; 
        return new Person(id, name, age, is_active);
    }

    public Notification Validate()
    {
        ValidatorInterface<Person> validator = new PersonValidator();
        return validator.Validate(this);
    }

    public void ChangeName(string name)
    {
        this.Name = name;
    }

    public void ChangeAge(int age)
    {
        this.Age = age;    
    }

    public void Activate()
    {
        this.IsActive = true;
    }

    public void Deactivate() 
    {
        this.IsActive = false;
    }

    public override string ToString()
    {
        return $"{this.Name}, {this.Age}";
    }


}