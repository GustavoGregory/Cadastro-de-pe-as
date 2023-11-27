namespace Cadastro_de_peças.Modelos
{
    public class Peca : Form1
    {
        public Guid Id { get;private set; }
        public string Nome { get; private set; }
        public string? Tipo { get; private set; }
        public DateTime? UltimaModificacao { get; private set; }
        public List<PropriedadeDinamica> PropriedadesDinamicas { get; private set; }
        public Peca(string nome, string? tipo, DateTime? ultimaModificacao, List<PropriedadeDinamica> propriedadesDinamicas)
        {
            Id = Guid.NewGuid();
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Tipo = tipo;
            UltimaModificacao = ultimaModificacao;
            PropriedadesDinamicas = propriedadesDinamicas ?? throw new ArgumentNullException(nameof(propriedadesDinamicas));
        }
    }
}
