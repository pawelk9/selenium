﻿namespace POM
{
    public abstract class BasePageValidator<M> where M : BasePageElementMap, new()
    {
        protected M Map
        {
            get
            {
                return new M();
            }
        }
    }
}
