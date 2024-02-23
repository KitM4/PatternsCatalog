using PatternsCatalog.CreationalPatterns.AbstractFactory;

ConcreteFactory abstractFactory = new("A"); 
AbstractFactoryExecutor<ConcreteFactory, ConcreteProduct> factoryExecutor = new(abstractFactory);

Console.WriteLine(factoryExecutor.Execute());
Console.ReadLine();