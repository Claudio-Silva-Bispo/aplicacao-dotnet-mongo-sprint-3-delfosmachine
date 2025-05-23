

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Project.Models;

    public class Consulta
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? IdUsuario { get; set; }
        public string? NomeCliente { get; set; }
        public string? CPFCliente { get; set; }
        public DateOnly Data { get; set; }
        public string? Turno { get; set; }
        public string? Horario { get; set; }
        public string? IdClinica { get; set; }
        public string? NomeClinica { get; set; }
        public string? CNPJClinica { get; set; }
        public string? NomeMedico { get; set; }
        public string? Especialidade { get; set; }
        public string? CEPClinica { get; set; }
        public string? EstadoClinica { get; set; }
        public string? CidadeClinica { get; set; }
        public string? BairroClinica { get; set; }
        public string? RuaClinica { get; set; }
        public string? StatusConsulta { get; set; } = "Encerrado";
        public string? RespostaFeedback { get; set; } = "Sem resposta";

    }