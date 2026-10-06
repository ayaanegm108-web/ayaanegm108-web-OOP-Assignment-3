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