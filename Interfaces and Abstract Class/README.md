This file contain the detailed about Interfaces and Abstract Class.
The followin Interfaces and Abstract Class are defined:- 

/************************************* Interfaces ************************************/
> Create the Interface use keyword 'Interface'
> It is convient way to write the Name of Interface with Latter 'I'
> Define the Method in Class body, where Interface is define, rather than in Interface body
> An interface can contain declarations of methods, properties, indexers, and events.
> An interface cannot contain constructors and fields.
> Interface members are by default abstract and public.
> Interface members must be implemented with the public modifier


1 ) INotifyPropertyChange Interface:
  > INotifyPropertyChange Interface let us know that the value has changed
  > It relay on ComponentModel namespace
  > denoted as keyword 'INotifyPropertyChange'

2) IComparable Interface:
   > define a type specific comparison method that our class can implement to order or sort its instances.
   > denoted as 'Icomparable'

3) IComparer Interface:
   > Icomparer interface is used to sort elements.
   > denoted as 'Icomparer'
   > part of system.collection namespace

4) IEquatable Interface:
   > used to define a method that can be implemented to create a way to determine if instances are equal to one another.
   > denoted as 'IEquatable'

5) IEqualityComparer Interface:
  > it takes two object and determines if they are equal.
  > it holds in System.Collections.Generic namespace
  > denoted as 'IEqualityComparer'

6) IEnumerable Interface:
  > interface is used to iterate foreach loop for custom collection that we create
  > this interface allow us to query data using links to something
  > lives in System.Collection namespace
  > denoted as 'IEnumerable'
  <!--
    > enumerator is an object that helps us to iterate over a collection of items.
    > it helps us to understand that where we are currently in the collection like which item we are on and where the next item is.
  -->

7) IEnumerator Interface:
   > IEnumerator Interface is used to support simple iteration over a collection that I enumerator works hand to hand with IEnumerable interface.
   > lives in System.Collection namespace.
   > denoted as 'IEnumerator'.

8) ICollection Interface:
   > lives in System.Collection namespace.
   > denoted as 'ICollection'.

/************************************* Abstract Class ************************************/
   > Abstruct Class is a class that must be implemented in any class that derives it.
   > It can not instantiate.
   > Used that we can have a common definition of a base class that multiple other classess can subclass and share.
 

/************************************* Abstract Method ************************************/
  > Abstract Method can be derived in the abstruct class not in the regular class. 
  > Abstract Class do not have a method body.
  > Method body or implementation goes inside the child class.
  > Abstract Method cannot be marked as static or virtual.
  > They can not be private.


/************************************* Virtual Method ************************************/
  > virtaul method has a default code in the base class
  > virtual keyword is added to Base Class Method
  > override keyword is added to Child Class Method
  > base keyword is used to invoke the base class method in the child class
