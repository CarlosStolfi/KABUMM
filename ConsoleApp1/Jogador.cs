using System.Security.Cryptography.X509Certificates;

public class Jogador
{
    //propriedades ou atributos
    public int x, y;
    private int vidas;
    private string simbolo;

    private ConsoleKey paraCima, paraBaixo, paraEsq, paraDir;

    // metodos ou operacoes

    public Jogador(int x, int y, string simbolo, ConsoleKey a, ConsoleKey b, ConsoleKey c, ConsoleKey d)
    {
        this.paraCima = a;
        this.paraBaixo = b;
        this.paraEsq = c;
        this.paraDir = d;
        this.x = x;
        this.y = y;
        this.simbolo = simbolo;
        this.vidas = 3;
    }

    public void apagar()
    {
        Console.SetCursorPosition(this.x, this.y);
        Console.Write(" ");
    }

    public void mover(ConsoleKey tecla)
    {
        this.apagar();
        if (tecla == this.paraCima) this.y--;
        if (tecla == this.paraBaixo) this.y++;
        if (tecla == this.paraEsq) this.x--;
        if (tecla == this.paraDir) this.x++;
        this.desenhar();

    }

    public void desenhar()
    {
        Console.SetCursorPosition(this.x, this.y);
        Console.Write(this.simbolo);
    }

    public void atirar(ConsoleKey tecla)
    {
        int tiroPositionX = this.x;
        int tiroPositionY = this.y;
    }

    public bool podeResponderTecla(ConsoleKey tecla)
    {
        /*bool podeMover =false;
        if(tecla == this.paraCima || tecla ==this.paraBaixo || tecla ==this.paraEsq || tecla ==this.paraDir)
        {
            podeMover=true;
        }*/
        return tecla == this.paraCima || tecla == this.paraBaixo || tecla == this.paraEsq || tecla == this.paraDir;
    }

    public string qualDirecao(ConsoleKey tecla)
    {
        string qual = "";
        if (tecla == this.paraCima) qual = "c";
        if (tecla == this.paraBaixo) qual = "b";
        if (tecla == this.paraEsq) qual = "e";
        if (tecla == this.paraDir) qual = "d";
        return qual;
    }
}
