// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Groups.Item.Sites.Remove
{
    [Obsolete("This class is obsolete. Use RemovePostResponse instead.")]
    #pragma warning disable CS1591
    public class RemoveResponse : Microsoft.Graph.Groups.Item.Sites.Remove.RemovePostResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Groups.Item.Sites.Remove.RemoveResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Groups.Item.Sites.Remove.RemoveResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Groups.Item.Sites.Remove.RemoveResponse();
        }
    }
}
