using System;

namespace GenericInjection2
{
    public class Domains
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class Unit
    {
        public int UnitID { get; set; }
        public DateTime Date { get; set; }
    }
    public class EquipmentModuleSchema
    {
        public int SchemaID { get; set; }
        public DateTime Date { get; set; }
    }

    public class EquipmentModuleSchemaEvent
    {
        public int SchemaEventID { get; set; }
        public DateTime Date { get; set; }
    }
}
