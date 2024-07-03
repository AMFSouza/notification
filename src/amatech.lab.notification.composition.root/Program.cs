// See https://aka.ms/new-console-template for more information
using amatech.lab.notification.core;
using amatech.lab.notification.core.entity;

var person = Person.Create("Antonio Marcos", 53);
        Notification notification = person.Validate();
        if ( notification.HasErrors()) 
        {
            notification.GetErrors().ForEach((error) => {
                Console.WriteLine($"class name:{nameof(person)} - field name:{error.field_name} - error:{error.error}");
            });
        } else {
            Console.WriteLine($"{nameof(person)} foi validado com sucesso");
        }

