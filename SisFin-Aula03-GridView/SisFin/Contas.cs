using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFin
{
    class Contas
    {
        private int id{ get; set; }
        private String nome  { get; set; }
        private String descricao{ get; set; }
        private int idcategoria { get; set; }
        private int status { get; set; }

        private List<Contas> lstContas = new List<Contas>();
        private Contas contas = new Contas();

        public Contas()
        {
        }

        public Contas(int id, string nome, string descricao, int idcategoria, int status)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.idcategoria = idcategoria;
            this.status = status;
           
        }

        

        public void AddToList(int idCategoria, string nome, string descricao)
        {
            lstContas.Add(new Contas(idCategoria, nome, descricao));
        }

        public List<Contas> ToList()
        {
            return lstContas;
        }

        public List<Contas> GeraContas()
        {
            Contas co1 = new Contas (1,"Salario UNICAMP","Salario recebido da UNICAMP");
            Contas co2 = new Contas(2,"Abastecimento Onix", "Combustivel Onix");
            lstContas.Add(co1);
            lstContas.Add(co2);
            return lstContas;
        }
        
    }
}
