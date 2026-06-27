using BuildingBlocks.Abstractions.Messages;


namespace BuildingBlocks.Core.Messages;

public abstract record IntegrationEvent : Message, IIntegrationEvent;
