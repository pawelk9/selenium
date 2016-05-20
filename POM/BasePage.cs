namespace POM
{
    public abstract class BasePage<M> where M : BasePageElementMap, new()
    {
        protected M Map
        {
            get
            {
                return new M();
            }
        }
    }

    public abstract class BasePage<M, V> : BasePage<M> where M : BasePageElementMap, new() where V : BasePageValidator<M>, new()
    {
        public V Validate()
        {
            return new V();
        }
    }
}
