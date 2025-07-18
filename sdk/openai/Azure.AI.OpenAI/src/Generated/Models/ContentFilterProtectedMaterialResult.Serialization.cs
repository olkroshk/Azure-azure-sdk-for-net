// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.OpenAI
{
    /// <summary> The ContentFilterProtectedMaterialResult. </summary>
    public partial class ContentFilterProtectedMaterialResult : IJsonModel<ContentFilterProtectedMaterialResult>
    {
        /// <summary> Initializes a new instance of <see cref="ContentFilterProtectedMaterialResult"/> for deserialization. </summary>
        internal ContentFilterProtectedMaterialResult()
        {
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        void IJsonModel<ContentFilterProtectedMaterialResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ContentFilterProtectedMaterialResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentFilterProtectedMaterialResult)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("filtered") != true)
            {
                writer.WritePropertyName("filtered"u8);
                writer.WriteBooleanValue(Filtered);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("detected") != true)
            {
                writer.WritePropertyName("detected"u8);
                writer.WriteBooleanValue(Detected);
            }
            if (Optional.IsDefined(Citation) && _additionalBinaryDataProperties?.ContainsKey("citation") != true)
            {
                writer.WritePropertyName("citation"u8);
                writer.WriteObjectValue(Citation, options);
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
        ContentFilterProtectedMaterialResult IJsonModel<ContentFilterProtectedMaterialResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ContentFilterProtectedMaterialResult JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ContentFilterProtectedMaterialResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentFilterProtectedMaterialResult)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentFilterProtectedMaterialResult(document.RootElement, options);
        }

        /// <param name="element"> The JSON element to deserialize. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        internal static ContentFilterProtectedMaterialResult DeserializeContentFilterProtectedMaterialResult(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool filtered = default;
            bool detected = default;
            ContentFilterProtectedMaterialCitationResult citation = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("filtered"u8))
                {
                    filtered = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("detected"u8))
                {
                    detected = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("citation"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    citation = ContentFilterProtectedMaterialCitationResult.DeserializeContentFilterProtectedMaterialCitationResult(prop.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ContentFilterProtectedMaterialResult(filtered, detected, citation, additionalBinaryDataProperties);
        }

        /// <param name="options"> The client options for reading and writing models. </param>
        BinaryData IPersistableModel<ContentFilterProtectedMaterialResult>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ContentFilterProtectedMaterialResult>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIOpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ContentFilterProtectedMaterialResult)} does not support writing '{options.Format}' format.");
            }
        }

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        ContentFilterProtectedMaterialResult IPersistableModel<ContentFilterProtectedMaterialResult>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ContentFilterProtectedMaterialResult PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ContentFilterProtectedMaterialResult>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeContentFilterProtectedMaterialResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentFilterProtectedMaterialResult)} does not support reading '{options.Format}' format.");
            }
        }

        /// <param name="options"> The client options for reading and writing models. </param>
        string IPersistableModel<ContentFilterProtectedMaterialResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
