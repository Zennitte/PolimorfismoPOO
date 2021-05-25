namespace Polimorfismo_Override.Classes
{
    public class MegaMan : Player
    {
        private string Buster;
        public override string Correr()
        {
            return "O MegaMan correu numa velocidade extraordinaria.";
        }
    }
}