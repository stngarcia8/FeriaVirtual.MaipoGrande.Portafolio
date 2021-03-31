﻿namespace FeriaVirtual.Infrastructure.SeedWork.Events.RabbitMQ
{
    public static class RabbitMqQueueNameFormatter
    {
        public static string Format(DomainEventSubscriberInformation information) =>
            information.FormatRabbitMqQueueName();


        public static string FormatRetry(DomainEventSubscriberInformation information) =>
            $"retry.{Format(information)}";


        public static string FormatDeadLetter(DomainEventSubscriberInformation information) =>
            $"dead_letter.{Format(information)}";


    }
}
