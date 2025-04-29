Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code. Using the Builder pattern makes sense only when your products are quite complex and require extensive configuration.

Use the Builder pattern to get rid of a “telescoping constructor”. I.e. when a class has multiple constructors were they have different combinations of parameters.

Use the Builder pattern when you want your code to be able to create different representations of some product (for example, stone and wooden houses).

Use the Builder to construct Composite trees or other complex objects.