﻿namespace CoreWebApp.TestEntities
{
    public abstract class BaseClass2<T>
    {
        public T BaseProperty { get; set; }

        public abstract string StringProperty { get; set; }
    }
}
