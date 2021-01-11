namespace _15_12___M_todos_Construtores.classes
{
    public class Pessoa
    {
        private string sobreNome;
        public string SobreNome{
            get{return sobreNome;}
            set{sobreNome = value;}
        }
        private string nome;
        public string Nome{
            get{return sobreNome;}
            set{nome = value;}
        }

        public Pessoa(string firstName, string lastNome){
            sobreNome = lastNome;
            nome = firstName;
        }
        public Pessoa (string firstName){
            nome = firstName;
        }
    }
}