namespace List1_CSharp {
    class Funcionario {
        public int _id { get; set; }
        public string _nome { get; set; }
        public float _salario { get; set; }

        public Funcionario(int id, string nome, float salario) {
            _id = id;
            _nome = nome;
            _salario = salario;
        }

        public void aumentarSalario(float porcentagem) {
            _salario += (_salario * porcentagem / 100);
        }

        public override string ToString() {
            return _id + ", " + _nome + ", " + _salario;
        }
    }
}
