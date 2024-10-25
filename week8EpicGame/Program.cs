string folderPath = @"C:\data";
string heroFile = "heroes.txt";
string villianFile = "villians.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villians = File.ReadAllLines(Path.Combine(folderPath, villianFile));
string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "lego brick" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
int heroHP = GetCharacterHP(hero);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villian = GetRandomValueFromArray(villians);
string villianWeapon = GetRandomValueFromArray(weapon);
int villianHP = GetCharacterHP(villian);
Console.WriteLine($"Today {villian} with {villianWeapon} tries to take over the world!");

while(heroHP > 0 && villianHP > 0)
{
    heroHP = heroHP - Hit(villian, villianHP);
    villianHP = villianHP - Hit(hero, heroHP);
}

Console.WriteLine($"Hero {hero} HP: {heroHP}");
Console.WriteLine($"Villian {villian} HP: {villianHP}");

if(heroHP >
    
    
    
    
    )
static string GetRandomValuefromArray(string[] someArray)
    {
    Random rnd = new Random();  
    int RandomIndex = rnd.Next(0, someArray.Length);    
    string randomStringfromArray = someArray[RandomIndex];  
    return randomStringfromArray;

    }

static int GetCharacterHP(string charactername)
{
    if(charactername.Length < 10)
    {
        return 10;
    }
    else
    {
        return charactername.Length;
    }

}
static int Hit(string charactername, int characterHP)
{
    Random rnd = new Random();  
    int strike = rnd.Next(0, characterHP);  

    if(strike == 0)
    {
        Console.WriteLine($"{charactername} missed the target!");
    }
    else if(strike == characterHP - 1)
    {
        Console.WriteLine($"{charactername} made a critical hit!");
    }
    else
    {
        Console.WriteLine($"{charactername} hit {strike}!");
    }

    return strike;

}

