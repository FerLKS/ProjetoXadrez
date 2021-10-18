namespace tabuleiro
{
    class Posicao
    {
        public int linha {get; set; } //get e set significa que outras classes podem alterar o conteúdo da variável
        public int coluna{get; set; }

        public Posicao(int linha, int coluna) //construtor
        {
            this.linha = linha;
            this.coluna = coluna;

        }

        public override string ToString() //método para converter a impressão writeline do programa
        {
            return linha 
                + ", "
                + coluna;
             
        }


    }
}
