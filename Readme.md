# Writing the Classes of a Game

This project demonstrates a simple implementation of a **Hero** class in C#.  
The class models a game character with basic attributes and an attack behavior that changes depending on the hero type.

---

## 🧩 Hero Class Overview

### **Properties**
- **Name** (`string`): The hero’s name  
- **Age** (`int`): The hero’s age  
- **Type** (`string`): The hero’s class/type (e.g., *mage*, *warrior*, *ninja*)

---

## 📦 Constructor

```csharp
public Heroi(string name, int age, string type)
{
    Name = name;
    Age = age;
    Type = type;
}
```

## 🗡️ Methods

**Attack()**

Returns an attack action based on the hero type.

Behavior:

+ mage → "Attack with magic"

+ warrior → "Attack with sword"

+ ninja → "Attack with shuriken"

+ other → "Attack"
