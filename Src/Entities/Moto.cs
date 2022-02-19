namespace Localiza_Poo.Src.Entities
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }
        public Moto(string Marca, string Modelo, int Ano, string Cor, double Preco, int Cilindradas) : base(Marca, Modelo, Ano, Cor, Preco)
        {
            this.Cilindradas  = Cilindradas;
        }

        public override double Taxa () {
            if (this.Preco >= 16000.00)
            {
                return this.Preco * 1.3;
            }
            return this.Preco;
        }
            

        public override string ToString () {
            return "Moto: " + this.Marca + "\n"
            + "Modelo: " + this.Modelo + "\n"
            + "Ano: " + this.Ano + "\n"
            + "Cor: " + this.Cor + "\n"
            + "Preço: " + Taxa() + "\n"
            + "Cilindradas: " + this.Cilindradas + "\n"
            + "Km rodado: " + this.KmRodados;

        }
    }
}