# Part 02 — answers

---

## Reports

- What was the problem?
  CsvReportExporter, JsonReportExporter and TextReportExporter each contained
  the same Export workflow (Load, Validate, Format, Save) and the same Load,
  Validate and Save code. Only Format was different, so any change to the
  workflow had to be made in three places.
- What did you change?
  Created the abstract class ReportExporter. Its Export method holds the steps
  and their order in exactly one place (Template Method pattern), together with
  Load, Validate and Save. Each exporter now only overrides the abstract
  Format method.
- Why did you choose that approach?
  An abstract class can hold real shared code and also force every subclass to
  implement the one step that differs (abstract Format). An interface cannot
  hold shared implementation, so each exporter would still have to repeat
  Load, Validate and Save. The protected and private members also keep the
  steps internal, while all interface members are public.

---

## Enrollment

- What was the problem?
  To enroll one student, Program.cs created four services (PaymentGateway,
  SeatInventory, InvoiceGenerator, EmailService) and called them one by one in
  the right order, passing the invoice id from the invoice step to the email.
  The caller had to know all the services and the exact order.
- What did you change?
  Added EnrollmentFacade with one method, Enroll(studentId, courseId, amount).
  It creates the services and runs the steps in order. Program.cs now makes a
  single call and no longer uses the four services. Services.cs was not changed.
- Why did you choose that approach?
  The Facade pattern gives one simple entry point to a group of classes that
  are always used together. The caller no longer needs to know which services
  exist, the order they must run in, or that the invoice id is used in the
  confirmation email. If the workflow changes, only the facade changes.