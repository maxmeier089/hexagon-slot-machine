namespace SlotMachine
{

    public interface IGameOutcomePort
    {

        void NotifyGameOutcome(DateTime timestamp, GameOutcome outcome);

    }
}
