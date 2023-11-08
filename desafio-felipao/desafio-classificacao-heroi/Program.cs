Console.WriteLine("Digite o nome do seu herói: ");
string nome = Console.ReadLine();
Console.WriteLine($"Digite a XP que o herói{nome} possui:");
int xp = int.Parse(Console.ReadLine());
switch (xp) {
    case < 1000:
        Console.WriteLine($"O herói{nome}, com {xp} XP, é um ferro.");
    break;
    case < 2000:
        Console.WriteLine($"O herói{nome}, com {xp} XP, é um bronze.");
    break;
    case < 5000:
        Console.WriteLine($"O herói{nome}, com {xp} XP, é um prata.");
    break;
    case < 7000:
        Console.WriteLine($"O herói{nome}, com {xp} XP, é um ouro.");
    break;
    case < 8000:
        Console.WriteLine($"O herói{nome}, com {xp} XP, é um platina.");
    break;
    case < 9000:
        Console.WriteLine($"O herói{nome}, com {xp} XP, é um ascendente.");
    break;
    case < 10000:
        Console.WriteLine($"O herói{nome}, com {xp} XP, é um imortal.");
    break;
    case > 10000:
        Console.WriteLine($"O herói{nome}, com {xp} XP, é um RADIANTE.");
    break;
    default:
        Console.WriteLine($"Erro! Não foi possível determinar o nível do herói {nome}!");
    break;
}

