namespace AsterNET.Manager.Event
{
    public interface SuccessfulAuthEventInterface
    {
        SeverityEnum Severity { get; }

        string AccountId { get; }

        string RemoteAddress { get; }

        bool UsingPassword { get; }
    }
}
