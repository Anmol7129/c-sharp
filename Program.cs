// Console.WriteLine("Hello, World!");
// for (int i= 0; i<10; i++)
// {
//  Console.WriteLine(i); 
// }

// int[]numbers= [1,2,3,4,5];
// foreach(int number in numbers)
// {
//   Console.WriteLine(number);  
// }


// using System.Transactions;

// Console.WriteLine("enter your name");
// string name = Console.ReadLine();
// Console.WriteLine("Hello " + name);

// Console.WriteLine("enter your name");
// string fullname= Console.ReadLine();
// Console.WriteLine("your name is " + fullname);


// public struct Student
// {
//     public int id;
//     public string name;
//     public int age;
//     public int rollNo;
//     public string className;

    
// }
// Student student1;
// student1.id=12;
// student1.name="John";
// student1.age=20;
// student1.rollNo=123;
// student1.className="10th grade";    

// Console.WriteLine(student1.name);

// public struct Student
// {
//     public int id;
//     public string name;
//     public int age;
//     public int rollNo;
//     public string className;

    
// }
// Student student1;
// student1.id=12;
// student1.name="John";
// student1.age=20;
// student1.rollNo=123;
// student1.className="10th grade";        


using System;

// write program 

// int marks= 20;
// if (marks>=30)
// {
//     Console.WriteLine("pass");
// }
// else
// {
//     Console.WriteLine("fail");
// }


// int marks= 20;
// if (marks>=30)
// {
//     Console.WriteLine("pass");
// }
// else if (marks>=20)
// {
//     Console.WriteLine("average");
// }
// else
// {
//     Console.WriteLine("fail");
// }


// int day =4;
// switch (day)
// {   case 1:
//         Console.WriteLine("Monday");
//         break;
//     case 2:
//         Console.WriteLine("Tuesday");
//         break;
//     case 3:
//         Console.WriteLine("Wednesday");
//         break;
//     case 4:
//         Console.WriteLine("Thursday");
//         break;
//     case 5:
//         Console.WriteLine("Friday");
//         break;
//     case 6:
//         Console.WriteLine("Saturday");
//         break;
//     case 7:
//         Console.WriteLine("Sunday");
//         break;
//     default:
//         Console.WriteLine("Invalid day");
//         break;
    
//         }


// for (int i=1; i<=5; i++)
// {
//     Console.WriteLine(i);
// }   





// public struct Student
// {
// public string name ;
// public int age ;
// public int rollno;
// public int marks;
// public string classname;

// }
// class program
// {
//     static void Main(string[] args)
//     {
//         Student s1;
//         s1.name = "John";
//         s1.age = 20;
//         s1.rollno = 101;
//         s1.marks = 85;
//         s1.classname = "10th Grade";

//         Console.WriteLine("Name: " + s1.name);
//         Console.WriteLine("Age: " + s1.age);
//         Console.WriteLine("Roll No: " + s1.rollno);
//         Console.WriteLine("Marks: " + s1.marks);
//         Console.WriteLine("Class Name: " + s1.classname);
//     }
// }


// public struct Student
// {
//     public string name;
//     public int id;
//     public int rollno;

// }
// class program
// {
//     static void Main(string[] args)
//     {
//         Student s1;
//         s1.name = "anmol";
//         s1.id = 101;
//         s1.rollno = 10;

//         Console.WriteLine("Name: " + s1.name);
//         Console.WriteLine("ID: " + s1.id);
//         Console.WriteLine("Roll No: " + s1.rollno);
//     }
// }


using System.Data.SqlTypes;
using System.Transactions;

// public struct student
// {
//     public string name;
//     public int id;
//     public int rolno;

// }
// class program
// {
//     static void Main(string[] args)
//     {
//         student s1;
//         Console.WriteLine("enter your name");
//         s1.name = Console.ReadLine();
//         Console.WriteLine("enter your id");
//         s1.id= Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("enter your rollno");
//         s1.rolno = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Name: " + s1.name);
//         Console.WriteLine("ID: " + s1.id);
//         Console.WriteLine("Roll No: " + s1.rolno);
//     }
// }


// public struct student
// {
//     public string name;
//     public int id;
//     public int rollno;

// }
// class program
// {
//     static void Main(string[] args)
//     {
//         student s1;
//         Console.WriteLine("enter your name");
//         s1.name=Console.ReadLine();

//         Console.WriteLine("enter your id");
//         s1.id=Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("enter your rollno");
//         s1.rollno = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("enter your classname");
//         string classname = Console.ReadLine();
//         {
//             Console.WriteLine ("name:" + s1.name);
//             Console.WriteLine("id:" + s1.id);
//             Console.WriteLine("rollno:" + s1.rollno);
//             Console.WriteLine("classname:" + classname);
//         }
//     }
// }


// int age = 30;
// if (age >= 18)
// {
//     Console.WriteLine("You are eligible to vote.");
// }
// else
// {
//     Console.WriteLine("You are not eligible to vote.");
// }       

// int age = 30;
// if (age >= 18)
// {
//     Console.WriteLine("You are eligible to drive.");}
//     else if (age >= 16)
//     {
//         Console.WriteLine("You are eligible to drive.");
//     }
//     else
//     {
//         Console.WriteLine("You are not eligible to vote or drive.");

//     }

                   
// int age = 19;
// if (age > 18)
// {
//     Console.WriteLine("you can vote");

// }
// else
// {
//     Console.WriteLine("you cannot vote");

// }            

// List <int> a = new List<int> ();// 21 april 2026
// List <int> numbers= new List<int>();
// numbers.Add(10);
// numbers.Add(20);
// Console.WriteLine(numbers[0]);

// List <int> numbers= new List<int>();
// numbers.Add(10); 
// numbers.Add(20);


// numbers[0]=40;
// numbers[1]=50;
// foreach(int number in numbers)
// {
//     Console.WriteLine(number);
// }


// List<int> numbers= new List<int>();
// numbers.Add(10);
// numbers.Add(20);
// numbers.Add(30);

// for (int i=0; i<numbers.Count; i++)
// {
//     Console.WriteLine(numbers[i]);
// }
// numbers.Remove(10);
// numbers.RemoveAll(number => number == 20);
// Console.WriteLine(numbers);

// Stack <int> stack = new Stack<int>();
// stack.Push(10);
// stack.Push(20);
// stack.Push(30); 
// Console.WriteLine(stack.Pop());
// Console.WriteLine(stack.Peek());    



// Stack <int> stack = new Stack<int>();

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Collections;

// class Program
// {
//     static void Main()
//     {
//         Stack<string> undoStack = new Stack<string>();

//         undoStack.Push("Typed: Hello");
//         undoStack.Push("Typed: Hello World");
//         undoStack.Push("Deleted: World");

//         Console.WriteLine("Undo action: " + undoStack.Pop());
//         Console.WriteLine("Current state: " + undoStack.Peek());
//     }
// }

// Stack<int> stack = new Stack<int>();
// stack.Push(10);
// stack.Push(30);

// foreach (int item in stack)
// {
//     Console.WriteLine(item);
// }


// using System;
// using System.Net.Security;

// ArrayList list=new ArrayList();
// list.Add("hello");
// list.Add(9);

// list[0]="Anmol";
// foreach (var item in list)
// {
//     Console.WriteLine(item);
// }


// SortedList sort=new SortedList();
// sort.Add(5,24);
// sort.Add(8,"Anmol");
// sort.Add(7,"Sugal");
// foreach (var item in sort)
// {
//     Console.WriteLine(item);
// }

// Hashtable h=new Hashtable();
// h.Add(2, "B");
// h.Add(1,"A");
// h.Add(3,"B");
// h.Add(4,"D");

// h[1]= "C";
// foreach(var item in h)
// {
//     Console.WriteLine(item);
// }

// Dictionary<string, string> dict = new Dictionary<string, string>();
// dict.Add("Anmol","K xa hajur");
// dict.Add("Sugal","Thik xa hajur"); 
// foreach (var item in dict)
// {
//     Console.WriteLine(item);
// }         

// int[] array = new int[5];
// array[0] = 10;
// array[1] = 20;
// array[2] = 30; 
// array[3] = 40;
// array[4] = 50;
// foreach (int item in array)
// {
//     Console.WriteLine(item);
// }        

// int[]array= new int[4] {10,20,40,50};
// int newData= 30;
// int pos=2;

// int[]newArray= new int[array.Length+1];
// // Console.WriteLine(newArray[0]);
// for(int i=0; i<pos; i++)
// {
//     newArray[i]=array[i];
// }
// //  Console.WriteLine(newArray[0]);
// newArray[pos]=newData;
// for(int i=pos; i<array.Length; i++)
// {
//     newArray[i+1]=array[i];
// }
// foreach( var item in newArray)
// {
//     Console.WriteLine(item);
// }


Console.WriteLine("Hello, World!");
Console.WriteLine("hello students");