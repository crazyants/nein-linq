using System.Collections.Generic;

namespace NeinLinq.Tests.InjectableQuery
{
    public static class DummyStore
    {
        public static IReadOnlyList<Dummy> Data { get; } = new[]
        {
            new Dummy { Id = 1, Name = "Asdf", Distance = 66, Time = .33 },
            new Dummy { Id = 2, Name = "Narf", Distance = 0, Time = 3.14 },
            new Dummy { Id = 3, Name = "Qwer", Distance = 8, Time = 64 }
        };
    }
}
