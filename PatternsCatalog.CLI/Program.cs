using PatternsCatalog.CreationalPatterns.AbstractFactory;
using PatternsCatalog.CreationalPatterns.Builder;

// === Abstract Factory ===

ConcreteFactory abstractFactory = new("A"); 
AbstractFactoryExecutor<ConcreteFactory, ConcreteProduct> factoryExecutor = new(abstractFactory);

Console.WriteLine(factoryExecutor.Execute());

// === Builder ===

ConcreteBuilder<string> builder = new();
Director<string> director = new(builder);

director.BuildProduct("Part A", "Part B", "Part C");
Console.WriteLine(builder.GetProduct().ListParts());

Console.ReadLine();