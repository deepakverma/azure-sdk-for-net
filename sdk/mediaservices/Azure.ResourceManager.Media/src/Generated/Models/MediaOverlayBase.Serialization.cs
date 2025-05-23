// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    [PersistableModelProxy(typeof(UnknownOverlay))]
    public partial class MediaOverlayBase : IUtf8JsonSerializable, IJsonModel<MediaOverlayBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaOverlayBase>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MediaOverlayBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaOverlayBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaOverlayBase)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("inputLabel"u8);
            writer.WriteStringValue(InputLabel);
            if (Optional.IsDefined(Start))
            {
                writer.WritePropertyName("start"u8);
                writer.WriteStringValue(Start.Value, "P");
            }
            if (Optional.IsDefined(End))
            {
                writer.WritePropertyName("end"u8);
                writer.WriteStringValue(End.Value, "P");
            }
            if (Optional.IsDefined(FadeInDuration))
            {
                writer.WritePropertyName("fadeInDuration"u8);
                writer.WriteStringValue(FadeInDuration.Value, "P");
            }
            if (Optional.IsDefined(FadeOutDuration))
            {
                writer.WritePropertyName("fadeOutDuration"u8);
                writer.WriteStringValue(FadeOutDuration.Value, "P");
            }
            if (Optional.IsDefined(AudioGainLevel))
            {
                writer.WritePropertyName("audioGainLevel"u8);
                writer.WriteNumberValue(AudioGainLevel.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        MediaOverlayBase IJsonModel<MediaOverlayBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaOverlayBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaOverlayBase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaOverlayBase(document.RootElement, options);
        }

        internal static MediaOverlayBase DeserializeMediaOverlayBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.AudioOverlay": return AudioOverlay.DeserializeAudioOverlay(element, options);
                    case "#Microsoft.Media.VideoOverlay": return VideoOverlay.DeserializeVideoOverlay(element, options);
                }
            }
            return UnknownOverlay.DeserializeUnknownOverlay(element, options);
        }

        BinaryData IPersistableModel<MediaOverlayBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaOverlayBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaOverlayBase)} does not support writing '{options.Format}' format.");
            }
        }

        MediaOverlayBase IPersistableModel<MediaOverlayBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaOverlayBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMediaOverlayBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaOverlayBase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaOverlayBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
