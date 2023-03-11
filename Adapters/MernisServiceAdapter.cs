using ISteam.Abstract;
using ISteam.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;

namespace ISteam.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            EndpointConfiguration configuration = new EndpointConfiguration();
            KPSPublicSoapClient kPSPublicSoapClient1 = new KPSPublicSoapClient(configuration);
            KPSPublicSoapClient kPSPublicSoapClient = kPSPublicSoapClient1;
            KPSPublicSoapClient client = kPSPublicSoapClient;
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.TcNo), customer.Name.ToUpper(), customer.LastName.ToUpper(), customer.BirthYear.Year);
            result.Wait();
            bool sonuc = result.Result.Body.TCKimlikNoDogrulaResult;
            return sonuc;
        }
    }
}
