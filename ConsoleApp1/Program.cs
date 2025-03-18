Jogo jogoAtual = new Jogo(20,70);
jogoAtual.adicionarJogador(new Jogador(2,2,"#",ConsoleKey.W,ConsoleKey.S,ConsoleKey.A,ConsoleKey.D));
jogoAtual.adicionarJogador(new Jogador(10,10,"&",ConsoleKey.I,ConsoleKey.K,ConsoleKey.J,ConsoleKey.L));
jogoAtual.adicionarJogador(new Jogador(60,17,"%",ConsoleKey.UpArrow,ConsoleKey.DownArrow,ConsoleKey.LeftArrow,ConsoleKey.RightArrow));

//executa o jogo(desenha);
jogoAtual.desenhar();

//desliga o cursor
//teste
Console.CursorVisible=false;
ConsoleKeyInfo tecla;

// Game Looping
while(true)
{
    tecla = Console.ReadKey(true);
    if(tecla.Key == ConsoleKey.Escape)break;
    jogoAtual.processarTecla(tecla.Key);
    
}