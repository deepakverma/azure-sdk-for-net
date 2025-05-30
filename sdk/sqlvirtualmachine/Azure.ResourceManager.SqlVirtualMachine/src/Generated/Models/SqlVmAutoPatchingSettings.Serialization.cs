// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlVmAutoPatchingSettings : IUtf8JsonSerializable, IJsonModel<SqlVmAutoPatchingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlVmAutoPatchingSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SqlVmAutoPatchingSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmAutoPatchingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlVmAutoPatchingSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enable"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(DayOfWeek))
            {
                writer.WritePropertyName("dayOfWeek"u8);
                writer.WriteStringValue(DayOfWeek.Value.ToSerialString());
            }
            if (Optional.IsDefined(MaintenanceWindowStartingHour))
            {
                writer.WritePropertyName("maintenanceWindowStartingHour"u8);
                writer.WriteNumberValue(MaintenanceWindowStartingHour.Value);
            }
            if (Optional.IsDefined(MaintenanceWindowDurationInMinutes))
            {
                writer.WritePropertyName("maintenanceWindowDuration"u8);
                writer.WriteNumberValue(MaintenanceWindowDurationInMinutes.Value);
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

        SqlVmAutoPatchingSettings IJsonModel<SqlVmAutoPatchingSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmAutoPatchingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlVmAutoPatchingSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlVmAutoPatchingSettings(document.RootElement, options);
        }

        internal static SqlVmAutoPatchingSettings DeserializeSqlVmAutoPatchingSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enable = default;
            SqlVmAutoPatchingDayOfWeek? dayOfWeek = default;
            int? maintenanceWindowStartingHour = default;
            int? maintenanceWindowDuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dayOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dayOfWeek = property.Value.GetString().ToSqlVmAutoPatchingDayOfWeek();
                    continue;
                }
                if (property.NameEquals("maintenanceWindowStartingHour"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maintenanceWindowStartingHour = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maintenanceWindowDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maintenanceWindowDuration = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SqlVmAutoPatchingSettings(enable, dayOfWeek, maintenanceWindowStartingHour, maintenanceWindowDuration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlVmAutoPatchingSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmAutoPatchingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlVmAutoPatchingSettings)} does not support writing '{options.Format}' format.");
            }
        }

        SqlVmAutoPatchingSettings IPersistableModel<SqlVmAutoPatchingSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmAutoPatchingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSqlVmAutoPatchingSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlVmAutoPatchingSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlVmAutoPatchingSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
