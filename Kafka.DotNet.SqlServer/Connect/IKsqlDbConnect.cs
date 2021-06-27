﻿using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Kafka.DotNet.SqlServer.Cdc.Connectors;

namespace Kafka.DotNet.SqlServer.Connect
{
  public interface IKsqlDbConnect
  {
    Task<HttpResponseMessage> CreateConnectorAsync(string connectorName, SqlServerConnectorMetadata connectorMetadata, CancellationToken cancellationToken = default);
  }
}