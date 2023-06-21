using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        World world = new World1(); // Создание экземпляра мира "Мир 1"
        world.SimulateEcosystem();

        // Другие действия или создание других миров...
    }
}

// Абстрактный класс для представления мира
public abstract class World
{
    public abstract List<Plant> CreatePlants();
    public abstract List<Herbivore> CreateHerbivores();
    public abstract List<Predator> CreatePredators();

    public void SimulateEcosystem()
    {
        List<Plant> plants = CreatePlants();
        List<Herbivore> herbivores = CreateHerbivores();
        List<Predator> predators = CreatePredators();

        // Имитация взаимодействия между животными и растениями
        foreach (var predator in predators)
        {
            foreach (var herbivore in herbivores)
            {
                predator.Hunt(herbivore);
            }
        }

        foreach (var herbivore in herbivores)
        {
            foreach (var plant in plants)
            {
                herbivore.Eat(plant);
            }
        }
    }
}

// Конкретный класс мира "Мир 1"
public class World1 : World
{
    public override List<Plant> CreatePlants()
    {
        return new List<Plant> { new Plant1(), new Plant2(), new Plant3() };
    }

    public override List<Herbivore> CreateHerbivores()
    {
        return new List<Herbivore> { new Herbivore1(), new Herbivore2(), new Herbivore3() };
    }

    public override List<Predator> CreatePredators()
    {
        return new List<Predator> { new Predator1(), new Predator2(), new Predator3() };
    }
}

// Конкретный класс мира "Мир 2"
public class World2 : World
{
    public override List<Plant> CreatePlants()
    {
        return new List<Plant> { new Plant4(), new Plant5(), new Plant6() };
    }

    public override List<Herbivore> CreateHerbivores()
    {
        return new List<Herbivore> { new Herbivore4(), new Herbivore5(), new Herbivore6() };
    }

    public override List<Predator> CreatePredators()
    {
        return new List<Predator> { new Predator4(), new Predator5(), new Predator6() };
    }
}

// Абстрактный класс для представления растений
public abstract class Plant
{
}

// Конкретные классы растений
public class Plant1 : Plant
{
}

public class Plant2 : Plant
{
}

public class Plant3 : Plant
{
}

public class Plant4 : Plant
{
}

public class Plant5 : Plant
{
}

public class Plant6 : Plant
{
}

// Абстрактный класс для представления травоядных
public abstract class Herbivore
{
    public void Eat(Plant plant)
    {
        Console.WriteLine("Herbivore eats plant");
    }
}

// Конкретные классы травоядных
public class Herbivore1 : Herbivore
{
}

public class Herbivore2 : Herbivore
{
}

public class Herbivore3 : Herbivore
{
}

public class Herbivore4 : Herbivore
{
}

public class Herbivore5 : Herbivore
{
}

public class Herbivore6 : Herbivore
{
}

// Абстрактный класс для представления хищников
public abstract class Predator
{
    public void Hunt(Herbivore herbivore)
    {
        Console.WriteLine("Predator hunts herbivore");
    }
}

// Конкретные классы хищников
public class Predator1 : Predator
{
}

public class Predator2 : Predator
{
}

public class Predator3 : Predator
{
}

public class Predator4 : Predator
{
}

public class Predator5 : Predator
{
}

public class Predator6 : Predator
{
}
