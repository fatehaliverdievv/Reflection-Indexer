using indexertask.Models;
Fruit apple = new Apple()
{
    Water = 65,
    Taste = "alma kimi dadir",
    VitaminA = 34,
};
Fruit banana = new Banana()
{
    Water = 65,
    Taste = "banana kimi dadir",
    VitaminB = 34,
};
Fruit orange = new Orange()
{
    Water = 65,
    Taste = "orange kimi dadir",
    VitaminC = 34,
};
Fruit[] fruit = {orange,apple,banana};
foreach (var item in fruit)
{
    Console.WriteLine(item.Taste+" type : " + item.GetType().Name);
}
 