public class Campo
{
    //atributos ou propriedades
    private int largura;
    private int altura;
    private int coluna;
    private int linha;


    //metodo ou operacoes
    //metodo construtor > sempre publico > Tem o mesmo nome da classe > Nao tem return > Nao tem tipo
    public Campo(int largura,int altura,int coluna,int linha)
    {
        this.largura=largura;
        this.altura=altura;
        this.coluna=coluna;
        this.linha=linha;
    }

    public void desenhar()
    {
        int colIni,colFin,linIni,linFin,meio;
        colIni=this.coluna;
        colFin=this.coluna+this.largura;
        linIni=this.linha;
        linFin=this.linha+this.altura;
        meio=colFin/2;

        for(int x=colIni;x<=colFin;x++)
        {
            //linha superior
            Console.SetCursorPosition(x,linIni);
            Console.Write("-");
            //Linha inferior
            Console.SetCursorPosition(x,linFin);
            Console.Write("_");
        }
        for(int j =linIni;j<=linFin;j++)
        {
            //linha esquerda
            Console.SetCursorPosition(colIni,j);
            Console.Write("|");
            //linha meio
            Console.SetCursorPosition(meio,j);
            Console.Write("|");
            //linha direita
            Console.SetCursorPosition(colFin,j);
            Console.Write("|");
        }
    }

    public bool podeMover(int x,int y,ConsoleKey tecla)
    {
        bool pode = true;

        //verifica o limite superior

        if (tecla == ConsoleKey.W || tecla == ConsoleKey.UpArrow)
        {
            y--;
            if(y==linha)pode=false;
        }

        //verifica o limite inferior
        if (tecla == ConsoleKey.S || tecla == ConsoleKey.DownArrow)
        {
            y++;
            if(y==linha+altura)pode=false;
        }

        //Verifica o limite esquerdo
        if (tecla == ConsoleKey.A || tecla == ConsoleKey.LeftArrow)
        {
            x--;
            if(x==coluna)pode=false;
        }
        //Verifica o limite direito
        if (tecla == ConsoleKey.D || tecla == ConsoleKey.RightArrow)
        {
            x++;
            if(x==coluna+largura)pode=false;
        }
        return pode;
    }

}