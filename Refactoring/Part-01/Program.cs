using Part_01.src.Notifications;
using Part_01.src.ShippingCost;
using Part_01.src.OrderProcessor;
using Part_01.src.OrderProcessor.OrderSave;
using Part_01.src.OrderProcessor.Sender;


var email=EmailNotification.CreateEmailNotification(NotificationType.Scheduled);
email.Send("ahmed@example.com", "This is a scheduled email.", DateTime.Today.AddHours(18));
var sms = SmsNotification.CreateSmsNotification(NotificationType.Scheduled);
sms.Send("+201000000000", "This is a scheduled SMS.", DateTime.Today.AddHours(18));
Console.WriteLine();


var emailSender = EmailSender.GetInstance();
var dbRepository =  SqlOrderRepository.GetInstance();
var processor = new OrderProcessor(dbRepository,emailSender);
processor.Process(1001, "customer@example.com");
Console.WriteLine();


Console.WriteLine($"Aramex 2kg  {AramexShippingCostCalulator.Calculate(2)}");
Console.WriteLine($"FedEx 2kg   {FedExShippingCostCalulator.Calculate(2)}");
Console.WriteLine($"DHL 2kg     {DHLShippingCostCalulator.Calculate(2)}");
Console.WriteLine();

//var shipping = new ShippingCostCalculator();
//Console.WriteLine($"Aramex 2kg → {shipping.Calculate("Aramex", 2)}");
//Console.WriteLine($"FedEx 2kg  → {shipping.Calculate("FedEx", 2)}");
//Console.WriteLine();

//var processor = new OrderProcessor();
//processor.Process(1001, "customer@example.com");
//Console.WriteLine();

//new UrgentScheduledEmailNotification { SendAt = DateTime.Today.AddHours(18) }
//    .Send("customer@example.com", "Your order ships tomorrow");
//new UrgentSmsNotification()
//    .Send("+201000000000", "OTP 4821");
