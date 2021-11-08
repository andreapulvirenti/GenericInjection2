using System;
using System.Collections.Generic;
using System.Text;


namespace GenericInjection2.Factories
{
    internal class UnitSchemaFactory : ISchemaFactory<Unit, UnitSchemaParameter>
    {

        public UnitSchemaFactory()
        {
        }

        ///<inheritdoc/>
        public Unit CreateSchema(UnitSchemaParameter schemaParameter)
        {
            return new Unit();
        }

    }
}
