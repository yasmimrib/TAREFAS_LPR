namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Personagem personagem = new Personagem();
            personagem.nome = "Mario";
            personagem.vidas = 3;
            personagem.Pular();
            personagem.PegaPoder();
            personagem.ColetaItem();
            personagem.Ataque();

            Inimigo inimigo = new Inimigo();
            inimigo.nome = "moço do mal";
            inimigo.forca = 6;
            inimigo.Atacar();
            inimigo.Dano();

            Item item = new Item();
            item.nome = "Cogumelo";
            item.efeito = "aumentar o tamnho";
            item.usoItem();

            /* if (inimigo.forca > 5)
             {
                 personagem.vidas = personagem.vidas - 1;
                 Console.WriteLine(personagem.nome + " perdeu uma vida após o ataque");
             }*/



        }
    }
}
