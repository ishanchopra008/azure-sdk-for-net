// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    public partial class DataFactoryPipelineData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Activities))
            {
                writer.WritePropertyName("activities");
                writer.WriteStartArray();
                foreach (var item in Activities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Variables))
            {
                writer.WritePropertyName("variables");
                writer.WriteStartObject();
                foreach (var item in Variables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Concurrency))
            {
                writer.WritePropertyName("concurrency");
                writer.WriteNumberValue(Concurrency.Value);
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RunDimensions))
            {
                writer.WritePropertyName("runDimensions");
                writer.WriteStartObject();
                foreach (var item in RunDimensions)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder");
                writer.WriteObjectValue(Folder);
            }
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy");
                writer.WriteObjectValue(Policy);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static DataFactoryPipelineData DeserializeDataFactoryPipelineData(JsonElement element)
        {
            Optional<ETag> eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<IList<DataFactoryPipelineActivity>> activities = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IDictionary<string, VariableSpecification>> variables = default;
            Optional<int> concurrency = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<IDictionary<string, BinaryData>> runDimensions = default;
            Optional<PipelineFolder> folder = default;
            Optional<PipelinePolicy> policy = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("activities"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DataFactoryPipelineActivity> array = new List<DataFactoryPipelineActivity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataFactoryPipelineActivity.DeserializeDataFactoryPipelineActivity(item));
                            }
                            activities = array;
                            continue;
                        }
                        if (property0.NameEquals("parameters"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ParameterSpecification.DeserializeParameterSpecification(property1.Value));
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("variables"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, VariableSpecification> dictionary = new Dictionary<string, VariableSpecification>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, VariableSpecification.DeserializeVariableSpecification(property1.Value));
                            }
                            variables = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("concurrency"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            concurrency = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("annotations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<BinaryData> array = new List<BinaryData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BinaryData.FromString(item.GetRawText()));
                            }
                            annotations = array;
                            continue;
                        }
                        if (property0.NameEquals("runDimensions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                            }
                            runDimensions = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("folder"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            folder = PipelineFolder.DeserializePipelineFolder(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("policy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            policy = PipelinePolicy.DeserializePipelinePolicy(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryPipelineData(id, name, type, systemData.Value, description.Value, Optional.ToList(activities), Optional.ToDictionary(parameters), Optional.ToDictionary(variables), Optional.ToNullable(concurrency), Optional.ToList(annotations), Optional.ToDictionary(runDimensions), folder.Value, policy.Value, Optional.ToNullable(eTag), additionalProperties);
        }
    }
}
