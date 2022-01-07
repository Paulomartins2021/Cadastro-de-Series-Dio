using System;

namespace Cadastrodeseries
{
    class Program
    {
        static Serierepositorio repositorio = new Serierepositorio();
        static void Main(string[] args)
        {

            string opcaoUsuario = ObteropcaoUsuario ( );
          
           while (opcaoUsuario.ToUpper( ) != "X")
           {    
               switch (opcaoUsuario)
               
                    case "1";
                        ListarSeries();
                        break;
                    case "2";
                        InserirSerie();
                        break;
                    case "3";
                        AtualizarSerie();
                        break;
                    
                    case "4";
                        ExcluirSerie();
                        break;
                    case "5";
                        VisualizarSerie();
                    case "C";
                        Console.Clear();
                        break;

                    default:
                    throw new ArgumentOutOfRangeException();

                    


           }
           { 
                Console.WriteLine();
                Console.WriteLine("Cadastro de series aproveite");
                Console.WriteLine(" Informe a opcao desejada");

                Console.WriteLine("1- Listar series");
                Console.WriteLine("2- Inserir series");
                Console.WriteLine("3- Atualizar series");
                Console.WriteLine("4- Excluirr serie");
                Console.WriteLine("5- Visualizar serie");
                Console.WriteLine("C- Limpar Tela");
                Console.WriteLine("x- Sair");

                opcaoUsuario = Console.ReadLine().ToUpper();

               switch (opcaoUsuario);
              
         private static void ListarSeries()
         
         {
                     Console.WriteLine("ListSerie");

                    var list = repositorio.List();
                    if (list.Count == 0)

                     {
                        Console.WriteLine("nemhuma serie cadastrada.");
                        return;

                    }
                    foreach ( var serie in list)
                    {
                        var Excluido = serie.retornaExcluido();

                        Console.WriteLine("#ID {0} : - {1} - {2}" , serie.retornaid(), serie.retornaTitulo(), (Excluido ? "Exluido" : ""));


         }
                                        
             }
                 
                                                     
                                       
                private static void InserirSerie( )
                {

                      Console.WriteLine("Inserir nova serie");
                   
                   foreach (int i in Enum.GetValues)(typeof(Genero), i);

                    {
                        Console.WriteLine(" {0} - {1}" , i , Enum.GetName (typeof(Genero), i));

                    }
                    Console.WriteLine("Digite o genero entre as opcoes acima");
                    it entradaGenero = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine( "Qual o titulo da Serie");
                    string entradaTitulo = Console.ReadLine( );

                    Console.WriteLine("Qual o ano de Inicio da  Serie");
                    int entradaAno = int.Parse (Console.ReadLine());

                    Console.WriteLine("Digite a descricao da Seie");
                string entradaDescricao = (Console.ReadLine ());
                Serie atualizaserie = new Serie (ID: indiceSerie,
                                          gernero: (Genero)entradaGenero,
                                          titulo: entradaTitulo,
                                          ano: entradaAno,
                                          descricao: entradaDescricao);           
                   


                    repositorio.Insere(novaserie);
                   
                }
                           
                  
                    
                private static void AtualizarSerie()
             {
                 Console.WriteLine("Digite o id da serie:");
                 int indiceSerie = int.Parse(Console.ReadLine());
                 foreach (int i in Enum.GetValues(tippof(Genero)))
                 {
                     Console.WriteLine("{0}-{1}", i, Enum.GetName(tipeof(Genero), i));

                 }
                Console.Write("Digite o genero entre as opcoes acima:");
                int entradaGenero = int.Parse(Console.ReadLine());
                
                Console.Write("Digite o Titulo da Serie");
                string entradaTitulo = Console.ReadLine();
               
                Console.Write("Digite oAno de Incio da Serie");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a descricao da Seie");
                string entradaDescricao = (Console.ReadLine ());
                Serie atualizaserie = new Serie (ID: indiceSerie,
                                          gernero: (Genero)entradaGenero,
                                          titulo: entradaTitulo,
                                          ano: entradaAno,
                                          descricao: entradaDescricao);
                   repositorio.Atualiza(indiceSerie, atualizaserie);                       
                    
             }
                    
                private static void ExcluirSerie ()
                { 
                    Console.Write("Digite o id da serie:");
                    int indiceSerie = int.Parse(Console.ReadLine());
                    repositorio.Exclui(indiceSerie);

                }    

                private static void VisualizarSerie()
                {
                    Console.Write("Digite o id da serie:");
                    int indiceSerie = int.Parse(Console.ReadLine());

                    var serie = repositorio.RetornaPorid(indiceSerie);
                    Console.WriteLine(serie);

                }





                       
               
               
               
               }


           }
        
        }
    }
}
 