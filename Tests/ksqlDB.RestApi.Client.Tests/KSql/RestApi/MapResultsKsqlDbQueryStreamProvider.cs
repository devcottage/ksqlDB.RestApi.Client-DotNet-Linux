using IHttpClientFactory = ksqlDB.RestApi.Client.KSql.RestApi.Http.IHttpClientFactory;

namespace ksqlDB.Api.Client.Tests.KSql.RestApi;

internal class MapResultsKsqlDbQueryStreamProvider : TestableKSqlDbQueryStreamProvider
{
  public MapResultsKsqlDbQueryStreamProvider(IHttpClientFactory httpClientFactory)
    : base(httpClientFactory)
  {
    QueryResponse =
      "{\"queryId\":\"713207d7-8772-4f03-a3a6-b8f506f784db\",\"columnNames\":[\"KSQL_COL_0\"],\"columnTypes\":[\"MAP<STRING, INTEGER>\"]}\n[{\"a\":1,\"b\":2}]\n[{\"d\":4,\"c\":2}]";
  }
}