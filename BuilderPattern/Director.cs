namespace BuilderPattern
{
    public class Director
    {
        public void Build(IDatabaseBuilder builder)
        {
            //I don't call this because I didn't setup the app.config
            //builder.BuildConnection();
            builder.BuildCommand();
            builder.SetSettings();
        }
    }
}