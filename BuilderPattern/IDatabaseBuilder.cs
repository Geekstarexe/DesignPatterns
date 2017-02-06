namespace BuilderPattern
{
    public interface IDatabaseBuilder
    {
        Database Database { get; }

        void BuildCommand();
        void BuildConnection();
        void SetSettings();
    }
}