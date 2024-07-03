using amatech.lab.notification.core;
using amatech.lab.notification.core.entity;
using FluentAssertions;

namespace amatech.lab.notification.core.unit.test;
public class PersonValidatorTest
{
    [Fact(DisplayName=nameof(person_validator_should_validate_entity_person))]
    [Trait("unit.test", "PersonValidator")]
    public void person_validator_should_validate_entity_person()
    {
        var person = Person.Create(string.Empty, 0);
        Notification notification = person.Validate();
        
        notification.Should().NotBeNull();
        notification.HasErrors().Should().BeTrue();
        (notification.errors.Count > 0).Should().BeTrue();
    }


}