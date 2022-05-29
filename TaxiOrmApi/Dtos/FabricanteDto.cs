namespace TaxiOrmApi.Dtos
{
    public class FabricanteDto : EntityDto
    {
        public string Nome { get; set; }
        public List<ModeloDto> Modelos { get; set; }
    }
}
