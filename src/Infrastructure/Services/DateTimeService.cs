using NLP.Application.Common.Interfaces;
using System;

namespace NLP.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
