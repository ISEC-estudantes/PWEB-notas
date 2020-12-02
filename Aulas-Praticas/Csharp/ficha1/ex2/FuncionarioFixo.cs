namespace f1_ex2{
    class FuncionarioFixo : Funcionario
    {
        public FuncionarioFixo(string nome, string apelido, int NIF, int comissao) : base(nome, apelido, NIF, comissao)
        {
            
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override int getVencimento()
        {
            return base.getVencimento();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}