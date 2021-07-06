using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.ExercicioFormacao.Models
{
    class Bacharelado : Formacao
    {
        //Propriedades
        public string ProjetoConclusao { get; set; }
        public int CargaHorariaEstagio { get; set; }

        //Construtor
        public Bacharelado(string nome, int cargaHorariaEstagio) : base(nome) //nome já consta em Formacao "pai"
        {
            CargaHorariaEstagio = cargaHorariaEstagio;
        }

        //Métodos
        public override decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 600 + CargaHorariaEstagio * 12;
        }
        public decimal CalcularMensalidade(decimal desconto)
        {
            return Mensalidade = CalcularMensalidade() - desconto;
        }
        protected override void DefinirDuracao()
        {
            if (Nome.ToLower().Contains("engenharia"))
                Duracao = 60;
            else
                Duracao = 48;
        }
        public override string ToString()
        {
            return base.ToString() + $"Projeto: {ProjetoConclusao}, Carga horária estágio: {CargaHorariaEstagio}";
        }
    }
}
