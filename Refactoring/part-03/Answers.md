# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(n * m), where n = 5,000 requests and
  m = 50,000 blocked ids. List.Contains scans the list linearly for every
  request.
- Time (ms) before: 13 ms
- What did you change?
  Replaced List<int> with HashSet<int> in BlockedUserChecker, so each lookup is
  a hash lookup instead of a linear scan. The found count is unchanged (5000).
- Time complexity after: O(n + m). Building the set is O(m) and each of the
  n lookups is O(1) on average.
- Time (ms) after: 0 ms (measured with dotnet run -c Release)

---

## Students

- What was the problem?
  GetAllStudents created a List with 1,000,000 Student objects before returning
  it, even though Program.cs prints only 3 students and then breaks. The other
  999,997 objects were created for nothing, using time and memory.
- What did you change?
  Changed GetAllStudents to use yield return, so it returns an
  IEnumerable<Student> that creates each student only when the loop asks for
  it. After the loop stops at 3, the rest are never created. The program still
  prints the first 3 students.