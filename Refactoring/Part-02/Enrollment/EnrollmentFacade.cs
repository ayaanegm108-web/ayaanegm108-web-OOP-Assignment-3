using RefactoringLab.Part02.Enrollment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Part_02.Enrollment
{
    public class EnrollmentFacade
    {
        public void Enroll(string studentId, string courseId, decimal amount)
        {
            var paymentGateway = new PaymentGateway();
            paymentGateway.Charge(studentId, amount);
            var seatInventory = new SeatInventory();
            seatInventory.Reserve(courseId, studentId);
            var invoiceGenerator = new InvoiceGenerator();
            var invoiceId = invoiceGenerator.Create(studentId, amount);
            var emailService = new EmailService();
            emailService.Send(studentId, "EnrollmentFacade confirmed", $"Invoice {invoiceId} for {courseId}");
        }
    }
}
