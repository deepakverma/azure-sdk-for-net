// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureBlobStorageLinkedService : IUtf8JsonSerializable, IJsonModel<AzureBlobStorageLinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureBlobStorageLinkedService>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureBlobStorageLinkedService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlobStorageLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureBlobStorageLinkedService)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString"u8);
                JsonSerializer.Serialize(writer, ConnectionString);
            }
            if (Optional.IsDefined(AccountKey))
            {
                writer.WritePropertyName("accountKey"u8);
                JsonSerializer.Serialize(writer, AccountKey);
            }
            if (Optional.IsDefined(SasUri))
            {
                writer.WritePropertyName("sasUri"u8);
                JsonSerializer.Serialize(writer, SasUri);
            }
            if (Optional.IsDefined(SasToken))
            {
                writer.WritePropertyName("sasToken"u8);
                JsonSerializer.Serialize(writer, SasToken);
            }
            if (Optional.IsDefined(ServiceEndpoint))
            {
                writer.WritePropertyName("serviceEndpoint"u8);
                JsonSerializer.Serialize(writer, ServiceEndpoint);
            }
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalId);
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalKey);
            }
            if (Optional.IsDefined(Tenant))
            {
                writer.WritePropertyName("tenant"u8);
                JsonSerializer.Serialize(writer, Tenant);
            }
            if (Optional.IsDefined(AzureCloudType))
            {
                writer.WritePropertyName("azureCloudType"u8);
                JsonSerializer.Serialize(writer, AzureCloudType);
            }
            if (Optional.IsDefined(AccountKind))
            {
                writer.WritePropertyName("accountKind"u8);
                JsonSerializer.Serialize(writer, AccountKind);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteStringValue(EncryptedCredential);
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential, options);
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(ContainerUri))
            {
                writer.WritePropertyName("containerUri"u8);
                JsonSerializer.Serialize(writer, ContainerUri);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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

        AzureBlobStorageLinkedService IJsonModel<AzureBlobStorageLinkedService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlobStorageLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureBlobStorageLinkedService)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureBlobStorageLinkedService(document.RootElement, options);
        }

        internal static AzureBlobStorageLinkedService DeserializeAzureBlobStorageLinkedService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string version = default;
            IntegrationRuntimeReference connectVia = default;
            string description = default;
            IDictionary<string, EntityParameterSpecification> parameters = default;
            IList<BinaryData> annotations = default;
            DataFactoryElement<string> connectionString = default;
            DataFactoryKeyVaultSecret accountKey = default;
            DataFactoryElement<string> sasUri = default;
            DataFactoryKeyVaultSecret sasToken = default;
            DataFactoryElement<string> serviceEndpoint = default;
            DataFactoryElement<string> servicePrincipalId = default;
            DataFactorySecret servicePrincipalKey = default;
            DataFactoryElement<string> tenant = default;
            DataFactoryElement<string> azureCloudType = default;
            DataFactoryElement<string> accountKind = default;
            string encryptedCredential = default;
            DataFactoryCredentialReference credential = default;
            AzureStorageAuthenticationType? authenticationType = default;
            DataFactoryElement<string> containerUri = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("connectionString"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionString = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("accountKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accountKey = JsonSerializer.Deserialize<DataFactoryKeyVaultSecret>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sasUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sasUri = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sasToken"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sasToken = JsonSerializer.Deserialize<DataFactoryKeyVaultSecret>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("serviceEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceEndpoint = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalKey = JsonSerializer.Deserialize<DataFactorySecret>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("tenant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenant = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("azureCloudType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureCloudType = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("accountKind"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accountKind = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            encryptedCredential = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("credential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credential = DataFactoryCredentialReference.DeserializeDataFactoryCredentialReference(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationType = new AzureStorageAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("containerUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            containerUri = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureBlobStorageLinkedService(
                type,
                version,
                connectVia,
                description,
                parameters ?? new ChangeTrackingDictionary<string, EntityParameterSpecification>(),
                annotations ?? new ChangeTrackingList<BinaryData>(),
                additionalProperties,
                connectionString,
                accountKey,
                sasUri,
                sasToken,
                serviceEndpoint,
                servicePrincipalId,
                servicePrincipalKey,
                tenant,
                azureCloudType,
                accountKind,
                encryptedCredential,
                credential,
                authenticationType,
                containerUri);
        }

        BinaryData IPersistableModel<AzureBlobStorageLinkedService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlobStorageLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureBlobStorageLinkedService)} does not support writing '{options.Format}' format.");
            }
        }

        AzureBlobStorageLinkedService IPersistableModel<AzureBlobStorageLinkedService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureBlobStorageLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAzureBlobStorageLinkedService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureBlobStorageLinkedService)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureBlobStorageLinkedService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
