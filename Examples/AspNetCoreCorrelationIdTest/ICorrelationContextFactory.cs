using System;

namespace AspNetCoreCorrelationIdTest
{
    public interface ICorrelationContextFactory
    {
        CorrelationContext Create(Guid correlationId, String header);
        void Dispose();
    }
}
