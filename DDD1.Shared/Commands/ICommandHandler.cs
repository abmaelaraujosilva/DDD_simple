namespace DDD1.Shared.Commands
{
    public interface ICommandHandler<Command> where Command : ICommand
    {
        ICommandResult Handler(Command command);
    }
}
