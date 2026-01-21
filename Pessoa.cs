namespace flavio
{
     class Pessoa 
    {
        public string Nome;
        public int Idade;

        public void Apresentar()
        {
            Console.WriteLine($"Meu Nome é {Nome} e tenho {Idade} anos");
        }
    }
}