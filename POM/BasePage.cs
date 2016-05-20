namespace POM
{
    public abstract class BasePage<TMap> where TMap : BasePageElementMap, new()
    {
        public TMap Map
        {
            get
            {
                return new TMap();
            }
        }
    }
}
