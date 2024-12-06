using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouse.Abstractions.Service;

public interface IPaymentService
{
    public Task<double> CalculateTotalAmountAsync(int customerId);

    public bool ValidateCardNumber(string cardNumber);

    public Task<string> SendPaymentRequestAsync(double amount, string cardNumber, int expMonth, int expYear, string cvv);

}