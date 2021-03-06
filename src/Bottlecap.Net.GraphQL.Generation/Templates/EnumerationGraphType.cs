﻿namespace Bottlecap.Net.GraphQL.Generation.Templates
{
    public class EnumerationGraphType : BaseTemplate
    {
        private readonly TypeDefinition _typeDefinition;

        public string Name
        {
            get
            {
                return _typeDefinition.Type.Name;
            }
        }

        public string Namespace
        {
            get
            {
                return _typeDefinition.Type.Namespace;
            }
        }

        public EnumerationGraphType(Generator generator, TypeDefinition type)
            : base(generator)
        {
            _typeDefinition = type;
        }
    }
}
