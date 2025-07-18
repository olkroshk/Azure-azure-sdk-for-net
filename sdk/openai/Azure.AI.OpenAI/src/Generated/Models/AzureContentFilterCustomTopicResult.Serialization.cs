// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.OpenAI
{
    /// <summary> A collection of true/false filtering results for configured custom topics. </summary>
    public partial class AzureContentFilterCustomTopicResult : IJsonModel<AzureContentFilterCustomTopicResult>
    {
        /// <summary> Initializes a new instance of <see cref="AzureContentFilterCustomTopicResult"/> for deserialization. </summary>
        internal AzureContentFilterCustomTopicResult() : this(default, null, null)
        {
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        void IJsonModel<AzureContentFilterCustomTopicResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AzureContentFilterCustomTopicResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureContentFilterCustomTopicResult)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("filtered") != true)
            {
                writer.WritePropertyName("filtered"u8);
                writer.WriteBooleanValue(Filtered);
            }
            if (Optional.IsCollectionDefined(Details) && _additionalBinaryDataProperties?.ContainsKey("details") != true)
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStartArray();
                foreach (AzureContentFilterCustomTopicResultDetail item in Details)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        AzureContentFilterCustomTopicResult IJsonModel<AzureContentFilterCustomTopicResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual AzureContentFilterCustomTopicResult JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AzureContentFilterCustomTopicResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureContentFilterCustomTopicResult)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureContentFilterCustomTopicResult(document.RootElement, options);
        }

        /// <param name="element"> The JSON element to deserialize. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        internal static AzureContentFilterCustomTopicResult DeserializeAzureContentFilterCustomTopicResult(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool filtered = default;
            IList<AzureContentFilterCustomTopicResultDetail> details = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("filtered"u8))
                {
                    filtered = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("details"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureContentFilterCustomTopicResultDetail> array = new List<AzureContentFilterCustomTopicResultDetail>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(AzureContentFilterCustomTopicResultDetail.DeserializeAzureContentFilterCustomTopicResultDetail(item, options));
                    }
                    details = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new AzureContentFilterCustomTopicResult(filtered, details ?? new ChangeTrackingList<AzureContentFilterCustomTopicResultDetail>(), additionalBinaryDataProperties);
        }

        /// <param name="options"> The client options for reading and writing models. </param>
        BinaryData IPersistableModel<AzureContentFilterCustomTopicResult>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AzureContentFilterCustomTopicResult>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIOpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AzureContentFilterCustomTopicResult)} does not support writing '{options.Format}' format.");
            }
        }

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        AzureContentFilterCustomTopicResult IPersistableModel<AzureContentFilterCustomTopicResult>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual AzureContentFilterCustomTopicResult PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AzureContentFilterCustomTopicResult>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeAzureContentFilterCustomTopicResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureContentFilterCustomTopicResult)} does not support reading '{options.Format}' format.");
            }
        }

        /// <param name="options"> The client options for reading and writing models. </param>
        string IPersistableModel<AzureContentFilterCustomTopicResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
