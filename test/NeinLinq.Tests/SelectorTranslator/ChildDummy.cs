﻿namespace NeinLinq.Tests.SelectorTranslator
{
    public class ChildDummy : IDummy
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ParentDummy Parent { get; set; }
    }
}
