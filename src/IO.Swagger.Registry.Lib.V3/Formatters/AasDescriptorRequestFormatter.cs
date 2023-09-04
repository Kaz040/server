﻿using IO.Swagger.Registry.Lib.V3.Models;
using IO.Swagger.Registry.Lib.V3.Serializers;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace IO.Swagger.Registry.Lib.V3.Formatters
{
    public class AasDescriptorRequestFormatter : InputFormatter
    {
        public AasDescriptorRequestFormatter()
        {
            this.SupportedMediaTypes.Clear();
            this.SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/json"));
        }

        public override bool CanRead(InputFormatterContext context)
        {
            if (typeof(AssetAdministrationShellDescriptor).IsAssignableFrom(context.ModelType))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
        {
            Type type = context.ModelType;
            var request = context.HttpContext.Request;
            object result = null;


            JsonNode node = System.Text.Json.JsonSerializer.DeserializeAsync<JsonNode>(request.Body).Result;
            if (type == typeof(AssetAdministrationShellDescriptor))
            {
                result = DescriptorDeserializer.AssetAdministrationShellDescriptorFrom(node);
            }
            else
            {
                throw new NotSupportedException();
            }

            return InputFormatterResult.SuccessAsync(result);
        }
    }
}
