using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;


namespace GenericInjection2.Factories
{
    internal class EquipmentModuleSchemaFactory : ISchemaFactoryAsync<List<EquipmentModuleSchema>, EquipmentModuleSchemaParameter>
    {

        public EquipmentModuleSchemaFactory()
        {

        }

        public async Task<List<EquipmentModuleSchema>> CreateSchemaAsync(EquipmentModuleSchemaParameter schemaParameter)
        {
            return await Task.FromResult(new List<EquipmentModuleSchema>());
        }

    }
}
