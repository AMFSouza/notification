using FluentAssertions;

namespace amatech.lab.notification.core.unit.test;

public class NotificationTest
{
    [Fact(DisplayName=nameof(notification_should_have_a_list_of_errors))]
    [Trait("unit.test", "notification.core")]
    public void notification_should_have_a_list_of_errors()
    {
    
        var notification = new Notification();
        notification.AddError(new MessageError("class_error_c1", "error_message_m1", "error_01"));
        notification.AddError(new MessageError("class_error_c1", "error_message_m2", "error_02"));
        notification.AddError(new MessageError("class_error_c1", "error_message_m3", "error_03"));
        
        notification.Should().NotBeNull();
        notification.HasErrors().Should().BeTrue();
        (notification.errors.Count > 0).Should().BeTrue();
        notification.errors[0].class_name.Should().Be("class_error_c1");
        notification.errors[0].field_name.Should().Be("error_message_m1");
        notification.errors[0].error.Should().Be("error_01");
        notification.errors[1].class_name.Should().Be("class_error_c1");
        notification.errors[1].field_name.Should().Be("error_message_m2");
        notification.errors[1].error.Should().Be("error_02");
        notification.errors[2].class_name.Should().Be("class_error_c1");
        notification.errors[2].field_name.Should().Be("error_message_m3");
        notification.errors[2].error.Should().Be("error_03");

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