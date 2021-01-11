namespace Ex2.classes
{
    public class Produtos
    {
        public int Codigo{get;set;}
        public string Nome{get;set;}
        public string Descricao{get;set;}
        public int Estoque{get;set;}

        public Produtos(){
            
        }

        public Produtos(int valor){
            Codigo = valor;
        }
        public Produtos(int codigo, string nome, string descricao, int estoque){
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;  

        }
    }
}