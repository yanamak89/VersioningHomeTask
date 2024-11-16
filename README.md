# **Homework: Design Patterns in C#**

## **Task 2: Template Method**

Study the **Template Method** pattern. Pay attention to its application, the composition of its participants, and the relationships between them. Write a small program in C# that implements an abstract version of this pattern.

### **Description of the Template Method Pattern**
The **Template Method** is a design pattern that defines the general structure of an algorithm in a base class but allows derived classes to implement specific steps of the algorithm. The main idea is to avoid code duplication while providing flexibility for implementation details.

#### **Participants of the Pattern:**
1. **AbstractClass**:
   - Contains the template method, which defines the sequence of steps.
   - Defines abstract methods for steps that are implemented in derived classes.
   
2. **ConcreteClass**:
   - Implements specific steps of the algorithm by overriding abstract methods.

#### **Example Use Case:**
A program that processes files of different formats (Doc, CSV, PDF), where the general logic is stored in a base class, and the specific processing details are implemented in derived classes.

The full implementation is available here:  
**[TemplateMethodExample Repository](https://github.com/yanamak89/VersioningHomeTask/tree/master/TemplateMethodExample)**

---

## **Task 3: MSDN Search**

### **Task Description**
Use MSDN search tools to independently find a description of each topic covered in the lesson. Save the links and provide a short description for each.

### **Examples of Links:**
1. **[Template Method Pattern (MSDN)](https://learn.microsoft.com/en-us/previous-versions/msp-n-p/bb675192(v=pandp.10))**  
   A detailed description of the Template Method pattern, its use cases, and implementation.

2. **[Abstract Classes (MSDN)](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract)**  
   Explanation of abstract classes in C# and their application in software design.

3. **[Inheritance in C# (MSDN)](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance)**  
   Basics of inheritance in C# and how to work with base and derived classes.

4. **[Non-Virtual Interface Pattern (NVI)](https://learn.microsoft.com/en-us/previous-versions/msp-n-p/ff647811(v=pandp.10))**  
   Description of the Non-Virtual Interface pattern and examples of its usage.

---

## **Task 4: NVI Implementation**

Implement the **Non-Virtual Interface (NVI)** pattern in your own inheritance hierarchy.

### **Description of the NVI (Non-Virtual Interface) Pattern**
The **Non-Virtual Interface (NVI)** is a design pattern used to separate the user-facing interface from its implementation. This is achieved by using public methods that call protected virtual methods.

The full implementation is available here:  
**[Non-VirtualInterfacePaternExample Repository](https://github.com/yanamak89/VersioningHomeTask/tree/master/Non-VirtualInterfacePaternExample)**

