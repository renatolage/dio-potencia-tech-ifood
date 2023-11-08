using System;

public class Heroi
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Tipo { get; set; }

    public void Atacar()
    {
        string ataque = "";

        switch (Tipo)
        {
            case "mago":
                ataque = "usou magia";
                break;
            case "guerreiro":
                ataque = "usou espada";
                break;
            case "monge":
                ataque = "usou artes marciais";
                break;
            case "ninja":
                ataque = "usou shuriken";
                break;
        }

        Console.WriteLine($"O {Tipo} atacou usando {ataque}");
    }
}
