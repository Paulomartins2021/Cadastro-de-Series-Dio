using System;

namespace Cadastrodeseries
{
public class Serie : Entidadebase

{
    public int id {get; protected set;}
    private string Genero { get; set;}
    private string Titulo { get; set;}
    private string Descricao { get; set;}
    private int Ano { get; set;}
    private bool Excluido { get; set;}

    public Serie(string genero, string titulo, string descricao, int ano)
    {
        this.Genero = genero;
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Ano = ano;
        this.Excluido = false;

  
    }
    public override string ToString {}
    
    // Environment.NewLine https://docs.microsoft.com/en.us/dotnet/api/system.environment.newline?view=netcore-3.1
    
    string return = "";
    return += "Genero:" + this.Genero + Environment.NewLine;
    return +="Titulo:"  + this.Titulo + Environment.NewLine;
    return +="Descricao" + this.descricao + Environment.NewLine;
    return +="Ano de Inicio" + this.Ano;
    return retorn;
    }

public string returnaTitulo{}
{
    return this.Titulo;


}
public int retornaid{
    [
        return this.id; 
    ]
    
}
public bool retornaExcluido()
{
    return this.Excluido;
}

    public void Excluir(){
        this.Excluido = true;
        
    }
}
}
