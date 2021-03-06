using System;
using System.Collections.Generic;

namespace NeinLinq.Tests.NullsafeQuery
{
    public static class DummyStore
    {
        public static IReadOnlyList<Dummy> Data { get; } = new[]
        {
            new Dummy
            {
                SomeNumeric = 7,
                SomeText = "Narf",
                OneDay = new DateTime(1977, 05, 25),
                SomeOther = new Dummy { SomeNumeric = 42 }
            },
            new Dummy
            {
                SomeNumeric = 1138,
                SomeText = "What is thy bidding?",
                OneDay = new DateTime(1980, 05, 21),
                SomeOthers = new[]
                {
                    new Dummy { OneDay = new DateTime(2000, 3, 1) },
                    new Dummy { OneDay = new DateTime(2000, 6, 1) }
                }
            },
            new Dummy
            {
                SomeNumeric = 123456,
                SomeText = null,
                OneDay = new DateTime(1983, 05, 25),
                MoreOthers = new[]
                {
                    new Dummy { SomeOther = new Dummy { OneDay = new DateTime(2000, 1, 5) } },
                    new Dummy { SomeOther = new Dummy { OneDay = new DateTime(2000, 1, 8) } }
                }
            },
            new Dummy
            {
                SomeNumeric = 654321,
                SomeText = "",
                OneDay = new DateTime(2015, 12, 18),
                EvenLotMoreOthers = new HashSet<Dummy>
                {
                    new Dummy { SomeOther = new Dummy { OneDay = new DateTime(2000, 1, 4) } },
                    new Dummy { SomeOther = new Dummy { OneDay = new DateTime(2000, 1, 7) } }
                }
            },
            null
        };
    }
}
