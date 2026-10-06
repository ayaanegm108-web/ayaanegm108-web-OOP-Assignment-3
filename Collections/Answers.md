## Task 2.2 — Pick the Collection

| # | Scenario | Collection | Why |
|---|---|---|---|
| S1 | Find a student by national ID, thousands of times a day | Dictionary | A lookup by key is O(1) on average, so it does not scan the data for every search. |
| S2 | Course tags, the same tag never stored twice | HashSet | It rejects duplicates automatically, so a tag can exist only once. |
| S3 | Grades in the order entered, duplicates allowed | List | It keeps the insertion order and allows the same value many times. |
| S4 | Public method returns the price list, read-only for callers | IReadOnlyDictionary | Callers can read prices by key, but the interface has no Add or Remove. |
| S5 | Timetable keyed by start time, always printed in time order | SortedDictionary | Its keys stay sorted at all times, even when sessions are added at any moment. |
| S6 | Results the caller loops over once and may stop early | IEnumerable | Items can be produced one at a time (with yield return), so nothing extra is built if the caller stops. |