using DependencyInjection.Web.IRepository;
using DependencyInjectionPaymenet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Web.Implimentation
{
    public class StripePaymenetService : IStripePaymenetService
    {
        public ResponsModel GetPayment()
        {
            ResponsModel responsModel = new ResponsModel();
            responsModel.Status = "StripePaymenet";
            responsModel.ErrorMessage = "Not Available";
            return responsModel;
        }
    }

}

