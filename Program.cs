using System; 
using System.Collections.Generic;
using controledevoo;

class Program {

 static void cadastroDeViagem (List<Viagem> lista_Viagens) {
    
    Viagem novaViagem = new Viagem();

    Console.WriteLine("Dados para o preenchimento da nova viagem");
   
    Console.WriteLine("Modelo: "); 
    novaViagem.modelo = Console.ReadLine();
    Console.WriteLine("Placa: "); 
    novaViagem.placa = Console.ReadLine();
    Console.WriteLine("Destino: "); 
    novaViagem.destino = Console.ReadLine();
    Console.WriteLine("Km: "); 
    novaViagem.km = double.Parse(Console.ReadLine());
    Console.WriteLine("Consumo: "); 
    novaViagem.consumo = double.Parse(Console.ReadLine());
  
  lista_Viagens.Add(novaViagem);}


static void mostrarViagens (List<Viagem> listaDeViagens) {
   int tamanho = listaDeViagens.Count;
   for (int i = 0; i<tamanho; i++){
        Console.WriteLine("Modelo: " + listaDeViagens[i].modelo);
        Console.WriteLine("Placa: " + listaDeViagens[i].placa);
        Console.WriteLine("Destino: " + listaDeViagens[i].destino);
        Console.WriteLine("km: " + listaDeViagens[i].km);
        Console.WriteLine("consumo: " + listaDeViagens[i].consumo);

 }

static bool buscaPlaca(List<Viagem> listaDeViagens, string PlacaBusca) {
  bool existe = false;
   int tamanho = listaDeViagens.Count;
    for (int i = 0; i<tamanho; i++){
       if (listaDeViagens[i].placa == PlacaBusca) {
            Console.WriteLine("Placa encontrada! -- > " + listaDeViagens[i].placa);
             existe = true;
           
       }
      
    }
 return existe;
}


static bool buscaPorConsumo (List<Viagem> listaDeViagens, double Litros) {
   int tamanho = listaDeViagens.Count;
    bool encontrou = false;
        for (int i = 0; i<tamanho; i++){
        double consumoindividual = listaDeViagens[i].consumo * listaDeViagens[i].km;
        if (consumoindividual>Litros) {
                    Console.WriteLine("Excedeu: ");
                    Console.WriteLine( "Modelo: " + listaDeViagens[i].modelo +" Placa: " + listaDeViagens[i].placa +  " Destino: " + listaDeViagens[i].destino +" km: " + listaDeViagens[i].km + " Consumo: " + listaDeViagens[i].consumo );
                 encontrou = true;
       }
        }
        return encontrou;
 }

 static void calcularGastoPorViagem(List<Viagem> listaDeViagens, double valorCombustivel) {
   int tamanho = listaDeViagens.Count;
    double gasto = 0;
    double consumototal = 0;
         for (int i = 0; i<tamanho; i++){
             consumototal = (listaDeViagens[i].consumo * listaDeViagens[i].km);
              gasto = consumototal * valorCombustivel;
              Console.WriteLine("Consumo total da viagem do carro de placa: " + listaDeViagens[i].placa + "==>" + consumototal + "Litros");
              Console.WriteLine("Gasto total de todas as viagens: " + gasto + "Reais"); 
}

}

static void calcularGastoGeral(List<Viagem> listaDeViagens, double valorCombustivel) {
     int tamanho = listaDeViagens.Count;
    double gasto = 0;
    double consumototal = 0;
        for (int i = 0; i<tamanho; i++){
            consumototal = consumototal + (listaDeViagens[i].consumo * listaDeViagens[i].km);
            gasto = gasto + (consumototal * valorCombustivel);
            }
  Console.WriteLine("Consumo total de todas as viagens: " + consumototal + "Litros");
  Console.WriteLine("Gasto total de todas as viagens: " + gasto + "Reais"); 
}

}

static void Main(){

    List<Viagem> viagens = new List<Viagem>();

   cadastroDeViagem (viagens);

}

}