// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class SynchronizationTemplate : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Identifier of the application this template belongs to.</summary>
        public Guid? ApplicationId
        {
            get { return BackingStore?.Get<Guid?>("applicationId"); }
            set { BackingStore?.Set("applicationId", value); }
        }
        /// <summary>true if this template is recommended to be the default for the application.</summary>
        public bool? Default
        {
            get { return BackingStore?.Get<bool?>("default"); }
            set { BackingStore?.Set("default", value); }
        }
        /// <summary>Description of the template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>true if this template should appear in the collection of templates available for the application instance (service principal).</summary>
        public bool? Discoverable
        {
            get { return BackingStore?.Get<bool?>("discoverable"); }
            set { BackingStore?.Set("discoverable", value); }
        }
        /// <summary>One of the well-known factory tags supported by the synchronization engine. The factoryTag tells the synchronization engine which implementation to use when processing jobs based on this template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FactoryTag
        {
            get { return BackingStore?.Get<string?>("factoryTag"); }
            set { BackingStore?.Set("factoryTag", value); }
        }
#nullable restore
#else
        public string FactoryTag
        {
            get { return BackingStore?.Get<string>("factoryTag"); }
            set { BackingStore?.Set("factoryTag", value); }
        }
#endif
        /// <summary>Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.SynchronizationMetadataEntry>? Metadata
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.SynchronizationMetadataEntry>?>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.SynchronizationMetadataEntry> Metadata
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.SynchronizationMetadataEntry>>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#endif
        /// <summary>Default synchronization schema for the jobs based on this template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.SynchronizationSchema? Schema
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SynchronizationSchema?>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.SynchronizationSchema Schema
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SynchronizationSchema>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.SynchronizationTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.SynchronizationTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.SynchronizationTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "applicationId", n => { ApplicationId = n.GetGuidValue(); } },
                { "default", n => { Default = n.GetBoolValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "discoverable", n => { Discoverable = n.GetBoolValue(); } },
                { "factoryTag", n => { FactoryTag = n.GetStringValue(); } },
                { "metadata", n => { Metadata = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.SynchronizationMetadataEntry>(Microsoft.Graph.Models.SynchronizationMetadataEntry.CreateFromDiscriminatorValue)?.ToList(); } },
                { "schema", n => { Schema = n.GetObjectValue<Microsoft.Graph.Models.SynchronizationSchema>(Microsoft.Graph.Models.SynchronizationSchema.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteGuidValue("applicationId", ApplicationId);
            writer.WriteBoolValue("default", Default);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("discoverable", Discoverable);
            writer.WriteStringValue("factoryTag", FactoryTag);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.SynchronizationMetadataEntry>("metadata", Metadata);
            writer.WriteObjectValue<Microsoft.Graph.Models.SynchronizationSchema>("schema", Schema);
        }
    }
}
