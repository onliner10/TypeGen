﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApp.TestEntities;
using TypeGen.Core.TypeAnnotations;

namespace CoreWebApp.ErrorCase
{
    public class Bar
    {
        public int Id { get; set; }

        public int FooId { get; set; }
        public Foo Foo { get; set; }

        public int AId { get; set; }
        public TestInterface A { get; set; }

        public int B { get; set; }

        public List<C> MyCs { get; set; } = new List<C>();

        public List<D> MyDs { get; set; } = new List<D>();
    }
}
