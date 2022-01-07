using System;
using System.Collections.Generic;
namespace Cadastrodeseries
{
class Serierepositorio : IRepositorio<Serierepositorio>
{
    private List<Serie> listSerie = new List<Serie>();
    
        public void Atualiza(int id, Serie entidade)
{
        listaSerie(id) = objeto;

        public void Insere(Serie Objeto)
    {
        listaSerie.Add(Objeto);
             
   }
        public void Exlui(int id);
    {
        ListaSerie(id).Excluir();

    }

    piblic List<Serie> Lista ( )
    {
        return listaSerie;
        
    }


        public int Proximo()
    {
        return listSerie.Count;
    }
    
       public Serie RetornaPorid(int id)
    {
        return listSerie[id];

    }

  
}

}

