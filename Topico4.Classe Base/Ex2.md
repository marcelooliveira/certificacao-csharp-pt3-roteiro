# Which two code segments should you use?

You are developing an application that includes the following code segment:

![](https://cdn.briefmenow.org/wp-content/uploads/70-483-v2/297.jpg)

You need to implement both Start() methods in a derived class named UseStart that uses
the Start() method of each interface.
Which two code segments should you use? (Each correct answer presents part of the
solution. Choose two.)

![](https://cdn.briefmenow.org/wp-content/uploads/70-483-v2/298.jpg)


* Option B

* Option E

Explanation:

B:
* Implementing Multiple Interfaces
A class can implement multiple interfaces using the following syntax:
C#
public class CDAndDVDComboPlayer : ICDPlayer, IDVDPlayer
If a class implements more than one interface where there is ambiguity in the names of
members, it is resolved using the full qualifier for the property or method name. In other
words, the derived class can resolve the conflict by using the fully qualified name for the
method to indicate to which interface it belongs
* In C#, both inheritance and interface implementation are defined by the : operator,
equivalent to extends and implements in Java. The base class should always be leftmost in
the class declaration.