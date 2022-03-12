using Ahoy_Hotel_API.Models;
using Elasticsearch.Net;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Nest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ahoy_Hotel_API.Elasticsearch;

public class ElasticsearchClient
{
    //private readonly ILogger<ElasticsearchClient> logger;
    //private readonly IElasticClient client;
    //private readonly string indexName;

    //public ElasticsearchClient(ILogger<ElasticsearchClient> logger, IOptions<ElasticsearchOptions> options)
    //    : this(logger, CreateClient(options.Value.Uri), options.Value.IndexName)
    //{

    //}

    //public ElasticsearchClient(ILogger<ElasticsearchClient> logger, IElasticClient client, string indexName)
    //{
    //    this.logger = logger;
    //    this.indexName = indexName;
    //    this.client = client;
    //}

    //public async Task<CreateIndexResponse> CreateIndexAsync(CancellationToken cancellationToken)
    //{
    //    var createIndexResponse = await client.Indices.CreateAsync(indexName, descriptor =>
    //    {
    //        return descriptor.Map<ElasticsearchHotel>(mapping => mapping
    //            .Properties(properties => properties
    //                .Text(textField => textField.Name(document => document.Id))
    //                .Text(textField => textField.Name(document => document.Name))
    //                .Text(textField => textField.Name(document => document.Address))
    //                .Text(textField => textField.Name(document => document.Location))
    //                .Text(textField => textField.Name(document => document.Description))
    //                .Text(textField => textField.Name(document => document.Email))
    //                .Text(textField => textField.Name(document => document.PhoneNumber))
    //    }), cancellationToken);

    //    if (logger.IsDebugEnabled())
    //    {
    //        logger.LogDebug($"CreateIndexResponse DebugInformation: {createIndexResponse.DebugInformation}");
    //    }

    //    return createIndexResponse;
    //}
}
