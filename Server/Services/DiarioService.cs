using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace Server.Services
{
    public class DiarioService : Diario.DiarioBase
    {
        public override Task<RetornarDiario> RecuperarDiario(Recuperar request, ServerCallContext context)
        {
            return Task.FromResult(new RetornarDiario
                {
                    IdDiario = 1,
                    NomeProfessor = "Leandro Belge",
                    NomeTurma = "2º inf 02",
                    EhDiarioRegular = true,
                    DataRecuperacao = Timestamp.FromDateTime(DateTime.UtcNow)
                }
            );
        }       
    }
}