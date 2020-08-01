namespace Sprint2
{
   public interface ICommand
    {
        string Description { get; }

        void Execute();
    }
}
