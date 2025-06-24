Console.Clear();

int diaNasc, mesNasc;

string[] mes = {
    "O Zumbi",
    "O Assassino",
    "O Psicopata",
    "O Alienígena",
    "O Carniceiro",
    "O Matador",
    "O Vampiro",
    "O Maluco",
    "O Vingador",
    "O Monstro",
    "O Bruxo",
    "O Demônio"
};

string[] dia = {
    "Endiabrado",
    "Radioativo",
    "Endemoniado",
    "Vermelho",
    "Possuído",
    "Macabro",
    "Sombrio",
    "Sem Cabeça",
    "Desconhecido",
    "Inconsciente",
    "Oculto",
    "Esquecido",
    "Lúgubre",
    "Invocado",
    "Caído",
    "Costurado",
    "Amaldiçoado",
    "Anormal",
    "Perturbado",
    "Sanguinário",
    "Tenebroso",
    "Imortal",
    "Ressuscitado",
    "do Pântano",
    "da Encruzilhada",
    "do Porão",
    "do Velho Poço",
    "sem Perdão",
    "do Cemitério",
    "da Meia-Noite",
    "da Lua Cheia"
};

Console.WriteLine("--- Noite de Terror ---");
Console.WriteLine("Descubra qual monstro te perseguirá de acordo com sua data de nascimento.");

Console.Write("Qual o dia do seu nascimento? (1 a 31): ");
diaNasc = Convert.ToInt16(Console.ReadLine()!);

Console.Write("Qual o mês do seu nascimento? (1 a 12): ");
mesNasc = Convert.ToInt16(Console.ReadLine()!);

Console.WriteLine($"É melhor você fugir, {mes[mesNasc - 1]} {dia[diaNasc - 1]} está vindo te pegar!!");
    
    
