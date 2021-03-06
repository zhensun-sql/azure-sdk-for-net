// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Search.EntitySearch
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Search;
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// The Entity Search API lets you send a search query to Bing and get back
    /// search results that include entities and places. Place results include
    /// restaurants, hotel, or other local businesses. For places, the query
    /// can specify the name of the local business or it can ask for a list
    /// (for example, restaurants near me). Entity results include persons,
    /// places, or things. Place in this context is tourist attractions,
    /// states, countries, etc.
    /// </summary>
    public partial interface IEntitySearchAPI : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Supported Azure regions for Entity Search endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus'
        /// </summary>
        string AzureRegion1 { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IEntitiesOperations.
        /// </summary>
        IEntitiesOperations Entities { get; }

    }
}
