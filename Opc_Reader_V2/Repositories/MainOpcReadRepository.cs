using Opc.Ua.Client;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc_Reader_V2.Models;

namespace Opc_Reader_V2.Repositories
{
    public class MainOpcReadRepository:BaseRepository
    {
        public static MainOpcReadRepository init => _init??(_init=new MainOpcReadRepository());
        private static MainOpcReadRepository _init;

        public void readOpcDatas()
        {
            try
            {
                AddLog("Makine Okuma Başladı");
                var config = new ApplicationConfiguration()
                {
                    ApplicationName = "OpcReader",

                    ApplicationType = ApplicationType.Client,

                    SecurityConfiguration = new SecurityConfiguration
                    {
                        ApplicationCertificate = new CertificateIdentifier(),
                        AutoAcceptUntrustedCertificates = true,
                    },

                    ClientConfiguration = new ClientConfiguration { DefaultSessionTimeout = 600000 },
                };

                config.Validate(ApplicationType.Client).GetAwaiter().GetResult();

                if (config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
                {
                    config.CertificateValidator.CertificateValidation += (s, e) => { e.Accept = (e.Error.StatusCode == Opc.Ua.StatusCodes.BadCertificateUntrusted); };
                }
                //ent point parametreye alınacak
                var selectedEndpoint = CoreClientUtils.SelectEndpoint(ProjectConfig.PrConfig.opcIP, useSecurity: false);

                using (var session = Session.Create(config, new ConfiguredEndpoint(null, selectedEndpoint, EndpointConfiguration.Create(config)), false, "", 600000, null, null).GetAwaiter().GetResult())
                {
                    //dates
                    var starDate = DateTime.UtcNow.AddDays(-2);
                    var endDate = DateTime.UtcNow;
                    //Run History
                    //session metodları
                }
                AddLog("Makişne Okuma Bitti");

            }
            catch (Exception e)
            {
                AddLog("Makina Data Okuma Hatası"+e.Message);
            }
        }

        public void AddLog(string message)
        {
            AddDb(new ProjectLogs() { Message=message});
        }
    }
}
