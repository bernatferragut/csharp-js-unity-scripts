---
layout: post
title: "VR - Intermediate Scripting in Unity"
description: "C# Snippet Compilation of Intermediate Unity scripting basics"
date: 2016-12-21
tags: [design, code, unity]
comments: true
share: true
---

## Intermediate Gameplay Scripting Guide in C#

> **01. Properties**

```C#
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    //Member variables can be referred to as fields.
    //By Getting or Setting you can make them visible or invisble
    public int Experience;
    {
        get
        {
            //Some other code
            return experience
        }
        set
        {
            //Some other code
            experience = value;
        }
    }

    //Level is property that converts experience
    //points into the level of a player automatically
    public int Level
    {
        get
        {
            return experience/1000;
        }
        set
        {
            experience = value * 1000;
        }
    }
    //This is an example of an autoimplemented property
    public int Health{ get; set;};
}

public class Game : MonoBehaviour
{
    void Start()
    {
        Player mPlayer = new Player();

        //Properties can be used just like variables
        mPlayer.Experience = 5;
        int x = mPlayer.Experience;
    }
}
```
> **02. TernaryOperator**

```C#
using UnityEngine;
using System.Collections;

public class TernaryOperator : MonoBehaviour
{
    void Start()
    {
        int health = 10;
        string message;

        //TernaryOperator choose message based on health
        //Similar to IF statements
        message = health>0 ?; "Players is alive" : "Playes is moonkied";
    }
}
```

> **03. Statics**

```C#
using UnityEngine;
using System.Collections;

public class Enemy
{
   //Static variables are shared across all instances of a class
   public static int enemmyCount = 0;

   public Enemy()
   {
       //Increment the static variable to know how many
       //objects of this class have been created
       enemmyCount++;
   }
}

public class 
{
   public class Game
   {
       void Start()
       {
           Enemy enemy1 = new Enemy();
           Enemy enemy2 = new Enemy();
           Enemy enemy3 = new Enemy();

           //You can access a static varaible by using
           //the class and the dot operator
           int x = Enemy.enemyCount;
       }
   }
}

public class Player : MonoBehaviour
{
   //Static variables are shared across all instances
   //of a class.
   public static int playerCount = 0;

   void Start()
   {
       //Increment the static variable to know how many
       //objects of this class have been created.
       playerCount++;
   }
}

public class PlayerManager : MonoBehaviour
{
   void Start()
   {
       //You can access a static variable using the class
       //name and the dot operator.
       int x = Player.playerCount;
   }
}

public static class Utilities
{
   //A static method can be invoked without an objects
   //of a class. Note that static methods cannot access
   //non-static member variables.
   public static int(int num1, int num2)
   {
       return num1 + num2;
   }
}

public class  UtilitiesExample : MonoBehaviour
{
   void Start()
   {
       //You can access a static method by using the class name
       //and the dot operator.
       int x = Utilities.Add(5,6);
   }
}
```

> **04. MethodOverloading**

```c#
using UnityEngine;
using System.Collections;

public class SomeClass
{
    //The first Add method has a signature of
    //"Add(int, int). This signature must be unique.
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    //The second Add method has a signature of
    //"Add(string, string)". Again, this must be unique.
    public string Add(string str1, string str2)
    {
        return str1+str2;
    }
}

public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        SomeClass myClass = new SomeClass();//Instantition

        //The specific Add method called will depend on
        //the arguments passed in.
        myClass.Add(1,2);
        myClass.Add("Hello", "Bern");
    }
}
```

> **05. Generics**

```c#
using UnityEngine;
using System.Collections;

public class SomeClass
{
   //Here is a generic method. Notice the generic
   //type"T". This 'T' will be replaced at runtime
   //with an actual type.
   public T GenericMethod<T>(T param)
   {
       return param;
   }
}

using UnityEngine;
using System.Collections;

public class SomeOtherClass : MonoBehaviour 
{
    void Start () 
    {
        SomeClass myClass = new SomeClass();
        
        //In order to use this method you must
        //tell the method what type to replace
        //'T' with.
        myClass.GenericMethod<int>(5);
    }
}

using UnityEngine;
using System.Collections;

//Here is a generic class. Notice the generic type 'T'.
//'T' will be replaced with an actual type, as will also 
//instances of the type 'T' used in the class.
public class GenericClass <T>
{
    T item;
    
    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}

using UnityEngine;
using System.Collections;

public class GenericClassExample : MonoBehaviour 
{
    void Start () 
    {       
        //In order to create an object of a generic class, you must
        //specify the type you want the class to have.
        GenericClass<int> myClass = new GenericClass<int>();
        
        myClass.UpdateItem(5);
    }
}
```
> **06. Inheritance**

```C#
using UnityEngine;
using System.Collections;

//This is a base class which is
//also known as the parent class
public class Fruit
{
    public string color;

    //This is the first constructor for the Fruit class
    //ans is not inherited by any derived classes.
    public Fruit()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    //This is a second constructor for the fruit class
    //and is not inherited by any derived classes.
    public Fruit(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor called");
    }

    public void Chop()
    {
        Debug.Log("The" + color + "fruit has been chopped");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit");
    }
}

using UnityEngine;
using System.Collections;

//This is the derived class which is
//also known as the Child class.
public class Apple : Fruit
{
    //This is the first constructor for the Apple class.
    //It calls the parent constructor immediately, even
    //before it runs.
    public Apple()
    {
        //Notice how Apple has access to the public variable
        //color, which is a part of the Fruit Class.
        color = "red";
        Debug.Log("first Apple constructor called);
    }


    //This is the second constructor for the Apple class.
    //It specifies which parent constructor will be called
    //using the "base" keyword.
    public Appl(string newColor) : base(newColor)
    {
        //Notice how this constructor does not set the color
        //since the base constructor sets the coloe that 
        //is passed as an arguments.
        Debug.Log("2nd Apple Constructor Called");
    }
}


using UnityEngine;
using System.Collections;

public class FruitSalad : MonoBehaviour
{
    void Start()
    {
        //Let's illustrate inheritance with the
        //default constructors.
        Debug.Log("Creating a Fruit");
        Fruit myFruit = new Fruit();
        Debug.Log("Creating the Apple");
        Apple myApple = new Apple();

        //Call the methods on the Fruit class.
        myFruit.SayHello();
        myFruit.Chop();

        //Now let's illustrate inheritance with the 
        //constructors that read in a string.
        Debug.Log("Creating the fruit");
        myFruit = new Fruit("yellow");
        Debug.Log("Creating the apple");
        myApple = new Apple("green");
        
        //Call the methods of the Fruit class.
        myFruit.SayHello();
        myFruit.Chop();

        //Call the methods of theh Apple class.
        //Notice how class Apple has access to all
        //of the public methods of class Fruit.
        myApple.SayHello();
        myApple.Chop();

        //Call the methods of the Apple class.
        //Notice how ckass Apple has access to all
        //of the public methods of the class Fruit.
        myApple.SayHello();
        myApple.Chop();
    }
}
```

> **07. Polymorphism**

```C#
using UnityEngine;
using System.Collections;

public class Fruit 
{
    public Fruit()
    {
        Debug.Log("1st Fruit Constructor Called");
    }
    
    public void Chop()
    {
        Debug.Log("The fruit has been chopped.");     
    }
    
    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}

using UnityEngine;
using System.Collections;

public class Apple : Fruit 
{
    public Apple()
    {
        Debug.Log("1st Apple Constructor Called");
    }
    
    //Apple has its own version of Chop() and SayHello(). 
    //When running the scripts, notice when Fruit's version
    //of these methods are called and when Apple's version
    //of these methods are called.
    //In this example, the "new" keyword is used to supress
    //warnings from Unity while not overriding the methods
    //in the Apple class.
    public new void Chop()
    {
        Debug.Log("The apple has been chopped.");     
    }
    
    public new void SayHello()
    {
        Debug.Log("Hello, I am an apple.");
    }
}

using UnityEngine;
using System.Collections;

public class FruitSalad : MonoBehaviour
{
    void Start () 
    {
        //Notice here how the variable "myFruit" is of type
        //Fruit but is being assigned a reference to an Apple. This
        //works because of Polymorphism. Since an Apple is a Fruit,
        //this works just fine. While the Apple reference is stored
        //in a Fruit variable, it can only be used like a Fruit
        Fruit myFruit = new Apple();

        myFruit.SayHello();
        myFruit.Chop();
        
        //This is called downcasting. The variable "myFruit" which is 
        //of type Fruit, actually contains a reference to an Apple. Therefore,
        //it can safely be turned back into an Apple variable. This allows
        //it to be used like an Apple, where before it could only be used
        //like a Fruit.
        Apple myApple = (Apple)myFruit;
        
        myApple.SayHello();
        myApple.Chop(); 
    }
}
```
> **08. MemberHiding**

```C#
using UnityEngine;
using System.Collections;

public class Humanoid
{
    //Base version of the Yell method
    public void Yell()
    {
        Debug.Log("Humanoid version of the Yell() method");
    }
}

using UnityEngine;
using System.Collections;

public class Enemy : Humanoid
{
    //This hides the Humanoid version.
    new public void Yell()
    {
        Debug.Log ("Enemy version of the Yell() method");
    }
}

using UnityEngine;
using System.Collections;

public class Orc : Enemy
{
    //This hides the Enemy version.
    new public void Yell()
    {
        Debug.Log ("Orc version of the Yell() method");
    }
}

using UnityEngine;
using System.Collections;

public class WarBand : MonoBehaviour 
{
    void Start () 
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy();
        Humanoid orc = new Orc();
        
        //Notice how each Humanoid variable contains
        //a reference to a different class in the
        //inheritance hierarchy, yet each of them
        //calls the Humanoid Yell() method.
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
```
> **09. Overriding**

```c#
using UnityEngine;
using System.Collections;

public class Fruit 
{
    public Fruit ()
    {
        Debug.Log("1st Fruit Constructor Called");
    }
    
    //These methods are virtual and thus can be overriden
    //in child classes
    public virtual void Chop ()
    {
        Debug.Log("The fruit has been chopped.");     
    }
    
    public virtual void SayHello ()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}

using UnityEngine;
using System.Collections;

public class Apple : Fruit 
{
    public Apple ()
    {
        Debug.Log("1st Apple Constructor Called");
    }
    
    //These methods are overrides and therefore
    //can override any virtual methods in the parent
    //class.
    public override void Chop ()
    {
        base.Chop();
        Debug.Log("The apple has been chopped.");     
    }
    
    public override void SayHello ()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple.");
    }
}

using UnityEngine;
using System.Collections;

public class FruitSalad : MonoBehaviour 
{   
    void Start () 
    {
        Apple myApple = new Apple();
        
        //Notice that the Apple version of the methods
        //override the fruit versions. Also notice that
        //since the Apple versions call the Fruit version with
        //the "base" keyword, both are called.
        myApple.SayHello();
        myApple.Chop(); 
        
        //Overriding is also useful in a polymorphic situation.
        //Since the methods of the Fruit class are "virtual" and
        //the methods of the Apple class are "override", when we 
        //upcast an Apple into a Fruit, the Apple version of the 
        //Methods are used.
        Fruit myFruit = new Apple();
        myFruit.SayHello();
        myFruit.Chop();
    }
}
```
> **10. Interfaces**

```c#
using UnityEngine;
using System.Collections;

//This is a basic interface with a single required
//method.
public interface IKillable
{
    void Kill();
}

//This is a generic interface where T is a placeholder
//for a data type that will be provided by the 
//implementing class.
public interface IDamageable<T>
{
    void Damage(T damageTaken);
}

using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{
    //The required method of the IKillable interface
    public void Kill()
    {
        //Do something fun
    }
    
    //The required method of the IDamageable interface
    public void Damage(float damageTaken)
    {
        //Do something fun
    }
}
```

> **11. Extension Methods**

```c#
using UnityEngine;
using System.Collections;

//It is common to create a class to contain all of your
//extension methods. This class must be static.
public static class ExtensionMethods
{
    //Even though they are used like normal methods, extension
    //methods must be declared static. Notice that the first
    //parameter has the 'this' keyword followed by a Transform
    //variable. This variable denotes which class the extension
    //method becomes a part of.
    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1, 1, 1);
    }
}

using UnityEngine;
using System.Collections;

public class SomeClass : MonoBehaviour 
{
    void Start () {
        //Notice how you pass no parameter into this
        //extension method even though you had one in the
        //method declaration. The transform object that
        //this method is called from automatically gets
        //passed in as the first parameter.
        transform.ResetTransformation();
    }
}

```

> **12. Namespaces**

```c#
using UnityEngine;
using System.Collections;

namespace SampleNamespace
{
    public class SomeClass : MonoBehaviour 
    {
        void Start () 
        {
         // DoStuff;
        }
    }
}

```

> **13. Lists and Dictionaries**

```c#
using UnityEngine;
using System.Collections;
using System;//This allows the IComparable Interface

//This is the class you will be storing
//in the different collections. In order to use
//a collection's Sort() method, this class nedds to
//implement the IComparable interface
public class BadGuy : Icomparable<BadGuy>
{
  public string name;
  public int power;

  public BadGuy(string newName, int newPower)
  {
      name = newName;
      power  newPower;
  }

  //This method is required by the IComparable Interface
  public int CompareTo(BadGuy other)
  {
      if(other == nyll)
      {
          return 1;
      }

      //Return the differnce in power.
      return power - other.power;
  }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SomeClass : MonoBehaviour
{
    void Start()
    {
        //This is how you create a list. Notice how the type
        //is specified in the angle brackets(<>).
        List<BadGuy> badguys = new List<BadGuy>();

        //Here you add 3 BadGuys to the List
        badguys.Add(new BadGuy("Harvey", 50));
        badguys.Add(new BadGuy("Magneto", 50));
        badguys.Add(new BadGuy("Pip", 50));

        badguys.Sort();

        foreach (BadGuy guy in badguys)
        {
            print(guy.name + " " + guy.power);
        }

        //This clears out the list so that it is 
        //empty
        badguys.Clear();
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SomeOtherClass : MonoBehaviour 
{
    void Start()
    {
        //This is how you create a dictionay. Notice how this takes
        //two generic terms. In this case you are using a string and a 
        //BadGuy as your two values.

        Dictionary<string, BadGuy> badguys = new Dictionary<string, BadGuy>();

        BadGuy bg1 =  new BadGuy("Harvey", 50);
        BadGuy bg2 =  new BadGuy("Magneto", 100);

        //You can place variables into the Dictionary with the
        //Add() method.

        badguys.Add("gangster", bg1);
        badguys.Add("mutant", bg2);

        BadGuy magneto = badguys["mutant"];

        BadGuy temp = null;

        //This is a safer, but slow, method of accessing
        //values in a dictionary.
        {
            //success!
        }
        else
        {
            //failure!
        }
    }
}

```

> **14. Coroutines**

```c#
using UnityEngine;
using System.Collections;

public class CoroutinesExample : MonoBhaviour
{
    public float smoothing = 1f;
    public Transform target;

    void Start()
    {
        StartCoroutine(MyCoroutine(target));
    }

    IEnumerator MyCoroutine (Transform target)
    {
        while(Vector3.Distance(transform.post, target.post) > 0.05f)
        {
            transform.position = Vector3.Ler(transform.position, target.position, smoothing * Time.deltaTime);
            yield return null;
        }
    
        print("Reached the target");
        yield return new WaitForSeconds(3f);
        print("MyCoroutine is now finished");
    }
}

using UnityEngine;
using System.Collections;

public class PropertiesAndCoroutines : MonoBhaviour
{
    public float smoothing = 7f;
    public Vector3 Target
    {
        get { return target;}
        set
        {
            target = value;

            StopCoroutine("Movement");
            StartCoroutine("Movement", target);
        }
    }

    private Vector3 target;

    IEnumerator Movement (Vector3 target)
    {
        while(Vector3.Distance(trans.position, target) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target, smoothing*Time.deltaTime);
            yield return null;
        }
    }
}

using UnityEngine;
using System.Collections;

public class ClickSetPosition : MonoBhaviour
{
    public PropertiesAndCoroutines coroutinesScript;

    void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenToRay(Input.mousePosition);
        RaycastHit hit;

        Physics.Raycast(ray, out hit);

        if (hit.collider.gameObject == gameObject)
        {
            Vector3 newTarget = hit.point + new Vector3(0,0.5f,0);
            coroutinesScript.Target = newTarget;
        }
    }
}
```

> **15. Quaternions**

```c#
using UnityEngine;
using System.Collections;

public class MotionScript : MonoBehaviour 
{   
    public float speed =  3f;

    void Update()
    {
        transform.Translate(-Input.GetAxis("Horizontal")*speed*Time.deltaTime, 0, 0);
    }
}

using UnityEngine;
using System.Collections;

public class LooAtScript : MonoBehaviour 
{   
    public Transform target;

    void Update () 
    {
        Vector3 relativePos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);
    }
}

using UnityEngine;
using System.Collections;

public class GravityScript : MonoBehaviour 
{   
    public Transform target;
    
    void Update () 
    {
        Vector3 realativePos = (target.position + new Vector3(0,1,5f,0))- transform.poition;
        Quaternion rotation = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        transform.Translate(0,0,3 *Time.deltaTime);
    }
}

using UnityEngine;
using System.Collections;

public class SomeClass : MonoBehaviour 
{   
    void Update () 
    {
        transform.rotation = Quaternion.identity;
    }
}
```

> **16. Delegates**

```c#
using UnityEngine;
using System.Collections;

namespace DelegateScript : MonoBhaviour
{
    Delegate  void MyDelegate(int num);//function pattern def
    MyDelegate myDelegate;//We pass functions through delegates

    void Start()
    {
        myDelegate = PrintNum;//we assign the function to delegate
        myDelegate(50);//Execution

        myDelegate = DoubleNum;
        myDelegate(50)
    }

    void PrintNum(int num)
    {
        print("Print Num: " + num);
    }

    void DoubleNum(int num)
    {
        print("Double Num: " + num * 2);
    }
}

using UnityEngine;
using System.Collections;

namespace MultiCastScript : MonoBhaviour
{
    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;

    void Start()
    {
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnRed;

        if (myMultiDelegate != null)
        {
            myMultiDelegate();
        }
    }

    void PowerUp
    {
        print ("Orb is powering up!");
    }

    void TurnRed()
    {
        renderer.material.color = Color.red;
    }
}

```

> **17. Attributes**

```c#
using UnityEngine;
using System.Collections;

namespace SpinScript :MonoBhaviour
{
    [Range(-100, 100])]
    public int speed = 0;

    void Update()
    {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0);
    }
}

using UnityEngine;
using System.Collections;

[ExecuteEditMode]
public class ColorScript : MonoBhaviour
{
    void Start()
    {
        renderer,sharedMaterial.color = Color.red;
    }
}
```
> **18. Events**

```c#
using UnityEngine;
using System.Collections;

namespace EventManager :MonoBhaviour
{
   public delegate void ClickAction(); // Delegate declaration
   public static event ClickAction OnClicked; // event declaration

   void OnGUI()
   {
       if(GUI.Button(new Rect(Screen.width / 2 -50, 5, 100, 30), "Click"))
       {
           if(OnClicked != null)
            OnClicked();
       }
   }
}

using UnityEngine;
using System.Collections;

namespace Teleport :MonoBhaviour
{
   void OnEnable()
   {
       EventManager.OnClicked += Teleport;
   }

   void OnDisable()
   {
       EventManager.OnClicked -= Teleport;
   }

   void Teleport()
   {
       Vector3 pos = transform.position;
       pos.y = Random.Range(1.0f, 3.0f);
       transform.position = pos;
   }
}

using UnityEngine;
using System.Collections;

namespace TurnColorScript :MonoBhaviour
{
   void OnEnable()
   {
       EventManager.OnClicked += TurnColor;
   }

   void OnDisable()
   {
       EventManager.OnClicked -= TurnColor;
   }

   void TurnColor()
   {
       Color col = new Color(Random.value, Random.value);
       renderer.material.color = col;
   }
}
```

