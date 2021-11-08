using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericInjection2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnitController : ControllerBase
    {

        private readonly ILogger<UnitController> _logger;
        private readonly ISchemaFactory<Unit, UnitSchemaParameter> _unitSchemaFactory;
        private readonly ISchemaFactoryAsync<List<EquipmentModuleSchema>, EquipmentModuleSchemaParameter> _equipmentModuleSchema;
        private readonly ISchemaFactory<List<EquipmentModuleSchemaEvent>, EquipmentModuleSchemaEventParameter> _equipmentModuleSchemaEvent;


        public UnitController(ILogger<UnitController> logger,
                    ISchemaFactory<Unit, UnitSchemaParameter> usFactory,
                    ISchemaFactoryAsync<List<EquipmentModuleSchema>, EquipmentModuleSchemaParameter> equipmentModuleSchema,
                    ISchemaFactory<List<EquipmentModuleSchemaEvent>, EquipmentModuleSchemaEventParameter> equipmentModuleSchemaEvent)
        {
            _logger = logger;
            _unitSchemaFactory = usFactory;
            _equipmentModuleSchema = equipmentModuleSchema;
            _equipmentModuleSchemaEvent = equipmentModuleSchemaEvent;
        }

        [HttpGet]
        public async Task<Unit> Get()
        {
            var rng = new Random();
            var a = _unitSchemaFactory.CreateSchema(new UnitSchemaParameter()
            {
                FolderCode = rng.Next(),
                Name = String.Empty
            });

            var b = await _equipmentModuleSchema.CreateSchemaAsync(new EquipmentModuleSchemaParameter()
            {
                FolderCode = rng.Next(),
                UnitName = String.Empty,
                UnitSchemaId = Guid.NewGuid()
            });

            var c = _equipmentModuleSchemaEvent.CreateSchema(new EquipmentModuleSchemaEventParameter()
            {
                FolderCode = rng.Next(),
                EventCodeStructures = new List<string> { "ciao", "pippo" }
            });

            return a;



        }
    }
}
