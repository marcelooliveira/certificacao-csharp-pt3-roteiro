# Which signature should you use for each method?

You are developing the following classes named:
Class1
Class2
Class3
All of the classes will be part of a single assembly named Assembly.dll. Assembly.dll will be
used by multiple applications.
All of the classes will implement the following interface, which is also part ofAssembly.dll:

public interface Interface1
{
void Method1(decimal amount);
void Method2(decimal amount);
}

You need to ensure that the Method2 method for the Class3 class can be executed only
when instances of the class are accessed through the Interface1 interface. The solution
must ensure that calls to the Method1 method can be made either through the interface or
through an instance of the class.
Which signature should you use for each method? (To answer, select the appropriate
signature for each method in the answer area.)

![](https://cdn.briefmenow.org/wp-content/uploads/70-483-v2/154.jpg)

![](https://cdn.briefmenow.org/wp-content/uploads/70-483-v2/155.jpg)
