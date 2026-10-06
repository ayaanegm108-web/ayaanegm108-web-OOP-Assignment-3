# Part 01 — answers

---
## ShippingCostCalculator

- What was the problem?
  A switch on the carrier name inside one class. Adding a carrier meant editing
  ShippingCostCalculator, which violates the Open/Closed Principle.
- What did you change?
  Created the ICarrier interface and one class per carrier (Aramex, FedEx, DHL).
  ShippingCostCalculator now receives the carriers and looks them up by name,
  so it knows no carrier details. Added BostaShippingCostCalculator as a new
  file without editing any existing class.

---

## Notifications

- What was the problem?
  An inheritance tree that grows with every combination: each mix of channel
  (email, sms) and feature (urgent, scheduled) needed its own class.
- What did you change?
  One INotification interface. Channels (Email, Sms, WhatsApp) are separate
  classes. Urgent and scheduled are a [Flags] enum, so any combination is just
  Urgent | Scheduled, with no class per combination. The shared formatting
  lives in one NotificationFormatter helper (composition, not inheritance).
  Trade-off: adding a new option means editing the enum and the formatter.

---

## Proof

- New carrier file(s): BostaShippingCostCalculator.cs
- New notification channel file(s): WhatsAppNotification.cs
- Existing classes left unchanged? (yes/no): yes
  (Only Program.cs was edited, to wire in the new carrier and channel.)