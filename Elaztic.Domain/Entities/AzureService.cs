using System;
using System.Collections.Generic;

namespace Elaztic.Domain.Entities
{
    [Serializable]
    public class AzureService
    {
        public AzureService() { }

        public Guid Id { get; set; }

        public string Tag { get; set; }

        public string PublicName { get; set; }
    }
}