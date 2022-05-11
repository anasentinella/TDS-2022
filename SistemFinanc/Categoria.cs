using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemFinanc
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome {get; set; }
        public string Descricao { get; set; }
        public int Tipo { get; set; }
        public int Status { get; set; }

        private List<Categoria> _listCategoria = new List<Categoria>();
  
        public Categoria()
        {

        }
            
        public Categoria(int id,string nome,string descricao,int tipo,int status)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Tipo = tipo;
            Status = status;
        }
            
        public List<Categoria> Tolist()
        {
            return _listCategoria;
        }

        public void addToList(int id, string nome, string descricao, int tipo, int status)
        {
            _listCategoria.Add(new Categoria(id, nome, descricao, tipo, status));
        }

        public List<Categoria> GeraCategorias()
        {
            Categoria _cat1 = new Categoria(1,"salário", "Salário da unicamp", 1, 1);
            Categoria _cat2 = new Categoria(1, "Combustível", "Despesas com combustível",2, 1);
            _listCategoria.Add(_cat1);
            _listCategoria.Add(_cat2);
            return _listCategoria;
        }

     }
}
