using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFin
{
    public class Contas
    {
        public int id{ get; set; }
        public String nome  { get; set; }
        public String descricao{ get; set; }
        public int idcategoria { get; set; }
        public int status { get; set; }

        private List<Contas> _lstContas = new List<Contas>();
        

        public Contas()
        {
        }

        public Contas(int id, string nome, string descricao, int idcategoria,int status)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.idcategoria = idcategoria;
            this.status = status;
        }

        

        public void AddToList(int id, string nome, string descricao,int idcategoria,int status)
        {
            _lstContas.Add(new Contas(id, nome, descricao,idcategoria,status));
        }

        public List<Contas> ToList()
        {
            return _lstContas;
        }

        public List<Contas> GeraContas()
        {
            Contas co1 = new Contas (1,"Salario UNICAMP","Salario recebido da UNICAMP",1,1);
            Contas co2 = new Contas(2,"Abastecimento Onix", "Combustivel Onix",2,1);
            _lstContas.Add(co1);
            _lstContas.Add(co2);
            return _lstContas;
        }
        
    }
}
