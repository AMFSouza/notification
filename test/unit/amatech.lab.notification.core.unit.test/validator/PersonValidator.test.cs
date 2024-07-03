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

    [Fact(DisplayName=nameof(notification_should_not_have_a_list_of_errors))]
    [Trait("unit.test", "notification.core")]
    public void notification_should_not_have_a_list_of_errors()
    {
    
        var notification = new Notification();
        var message_01 = new MessageError(string.Empty, string.Empty, string.Empty);
        if ( !String.IsNullOrEmpty(message_01.class_name) &&
             !String.IsNullOrEmpty(message_01.field_name) && 
             !String.IsNullOrEmpty(message_01.error)) notification.AddError(message_01);

        notification.Should().NotBeNull();
        notification.HasErrors().Should().BeFalse();
        (notification.errors.Count == 0).Should().BeTrue();
    }

}