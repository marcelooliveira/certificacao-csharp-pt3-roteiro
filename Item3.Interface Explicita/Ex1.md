# Which two code segments should you use?

You are developing an application that includes the following code segment:

![](https://cdn.briefmenow.org/wp-content/uploads/70-483-v2/271.jpg)

You need to implement the Open() method of each interface in a derived class named
UseResources and call the Open() method of each interface.
Which two code segments should you use? (Each correct answer presents part of the
solution. Choose two.)


![](https://cdn.briefmenow.org/wp-content/uploads/70-483-v2/272.jpg)

Answer
* Option A
* Option C

Explanation:
* An interface contains only the signatures of methods, properties, events or indexers. A
class or struct that implements the interface must implement the members of the interface
that are specified in the interface definition.
* Example:

interface ISampleInterface
{
void SampleMethod();
}
class ImplementationClass : ISampleInterface
{
// Explicit interface member implementation:
void ISampleInterface.SampleMethod()
{
// Method implementation.
}
static void Main()
{
// Declare an interface instance.
ISampleInterface obj = new ImplementationClass();
// Call the member.
obj.SampleMethod();
}
}