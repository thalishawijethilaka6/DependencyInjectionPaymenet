using DependencyInjectionPaymenet.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPaymenet.Intareface
{
    public interface IPaymenetService
    {
        ResponsModel GetPayment();
    }
}
