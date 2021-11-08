using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInjection2.Factories
{
    internal class EquipmentModuleSchemaEventsFactory : ISchemaFactory<List<EquipmentModuleSchemaEvent>, EquipmentModuleSchemaEventParameter>
    {

        public EquipmentModuleSchemaEventsFactory()
        {
        }

        public List<EquipmentModuleSchemaEvent> CreateSchema(EquipmentModuleSchemaEventParameter sp)
        {
            return new List<EquipmentModuleSchemaEvent>()
            {
                new EquipmentModuleSchemaEvent()
                {
                    Date = DateTime.Now,
                    SchemaEventID = 152
                }
            };

        }
    }
}
