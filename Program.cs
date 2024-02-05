
Menu();

static void Menu(){

    Console.Clear();
    Console.WriteLine("Quanto tempo deseja contar?");
    Console.WriteLine(" ");
    Console.WriteLine("S = Segundos => 10s = 10 segundos");
    Console.WriteLine("M = Minutos => 1m = 1 minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine(" ");


    // ToLower = Converte para minúsculo.
    string data = Console.ReadLine().ToLower();

    // Substring = Pega uma parte da cadeia de caracteres. A posição da parte e a quantidade de caracteres.

    // Pegar o último caractere.
    char type = char.Parse(data.Substring(data.Length - 1, 1));

    // Pegar sempre os primeiros caracteres, menos o último. 
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;


    // Se for minutos, o multiplicador vai ser 60.
    if(type == 'm'){
        multiplier = 60;
    }

    // Se escolher 0, vai sair do programa
    if(time == 0){
        System.Environment.Exit(0);
    }

    PreStart (time * multiplier);
}

static void PreStart(int time){

    Console.Clear();
    Console.WriteLine("Ready...");
    Console.WriteLine(" ");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Console.WriteLine(" ");
    Thread.Sleep(1000);
    Console.WriteLine("Go!");
    Console.WriteLine(" ");
    Thread.Sleep(2500);

    Start(time);
}

static void Start(int time){

    int currentTime = 0;

    // Contador até 10 que limpa e a cada interação do While a Thread durma por 1 segundo.

    while(currentTime != time){

        // Limpa
        Console.Clear(); 

        // Adiciona um número
        currentTime++;

        // Printa na tela
        Console.WriteLine(currentTime);

        // Ele fala para a aplicação esperar 1 segundo (1000 milisegundos) antes do próximo While.
        Thread.Sleep(1000);


    }

    Console.Clear();
    Console.WriteLine("Stopwatch finalizado.");
    Thread.Sleep(2500);

}