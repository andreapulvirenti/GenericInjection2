using System;
using System.Collections.Generic;
using System.Text;

namespace GenericInjection2
{
    public interface ISchemaParameter
    {
        long FolderCode { get; set; }
    }

    public class UnitSchemaParameter : ISchemaParameter
    {
        public long FolderCode { get; set; }
        public string Name { get; set; } = default!;
    }

    public class EquipmentModuleSchemaParameter : ISchemaParameter
    {
        public long FolderCode { get; set; }
        public string UnitName { get; set; } = default!;
        public Guid UnitSchemaId { get; set; }

    }

    public class EquipmentModuleSchemaEventParameter : ISchemaParameter
    {
        public long FolderCode { get; set; }
        public IList<string> EventCodeStructures { get; set; } = new List<string>();

    }
}
