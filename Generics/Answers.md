# Generics — answers

## Step 2 — What is the same and what is different between the two stores?

**Same:**
- Both keep their items in a List and have the same four methods: Add,
  GetById, GetAll and Remove.
- The body of every method is identical: GetById loops with foreach and
  compares Id, Remove calls GetById first, and so on.
- Both use an Id of type int to find an item.

**Different:**
- Only the type of the items: StudentStore works with Student and CourseStore
  works with Course (field name, parameter types and return types).
- Student has Id and Name, while Course has Id, Title and Price, but the
  stores never use those extra properties.

The logic is copy-pasted, so any fix or new feature (for example, faster
lookup) would have to be done once per store, and every new entity type
(Teacher, Room...) would need a third copy.


## Step 3 — Compiler error in GetById

Error copied from the compiler:

    error CS1061: 'T' does not contain a definition for 'Id' ... (paste your own full message here)

Why the compiler rejects it:
Store<T> is checked once, when it is written, not when it is used. At that
point T can be any type at all (string, int, a class without an Id), so the
compiler only knows that T is an object. It does not know that T has an Id
property, so item.Id is not allowed. It cannot just trust that I will only
use Student and Course. I have to tell it what T must have, using a constraint.

## Step 7 — Why must new Store<string>() NOT compile?
cause we have a constraint on the generic type parameter T that requires 
it to implement the IHasId interface. Since string does not implement IHasId,
it cannot be used as a type argument for Store<T>.


Compiler error (copied):
CS0311: The type 'string' cannot be used as type parameter 'T'
in the generic type or method 'Store<T>'. There is no implicit
reference conversion from 'string' to 'src.IHasId'