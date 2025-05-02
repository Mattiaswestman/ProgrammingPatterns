Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate. 

The main difference between the facade and the adapter pattern is that the facade pattern does not change the interface of the system, but only simplifies it, while the adapter pattern changes the interface of the system to match another one.

Bridge and Adapter also looks quite similar. The difference is that Bridge is used during development of a new implementation, and Adapter is used with an existing implementation. That's why Adapter is often used in connection with third party code.

Use the Adapter class when you want to use some existing class, but its interface isn’t compatible with the rest of your code.

Use the pattern when you want to reuse several existing subclasses that lack some common functionality that can’t be added to the superclass.