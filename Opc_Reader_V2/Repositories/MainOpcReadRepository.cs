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

        public IList<object> CallMethodts(string noteClassId, string noteId, params object[] args)
        {
            try
            {
                Console.WriteLine("Step 1 - Create application configuration and certificate.");
                var config = new ApplicationConfiguration()
                {
                    ApplicationName = "OpcReader",
                    ApplicationType = ApplicationType.Client,
                    SecurityConfiguration = new SecurityConfiguration
                    {
                        ApplicationCertificate = new CertificateIdentifier(),
                        AutoAcceptUntrustedCertificates = true,
                    },

                    ClientConfiguration = new ClientConfiguration { DefaultSessionTimeout = 60000 },

                };

                config.Validate(ApplicationType.Client).GetAwaiter().GetResult();

                if (config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
                {
                    config.CertificateValidator.CertificateValidation += (s, e) => { e.Accept = (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted); };
                }
                //ent point parametreye alınacak
                var selectedEndpoint = CoreClientUtils.SelectEndpoint(ProjectConfig.PrConfig.opcIP, useSecurity: false);

                Console.WriteLine($"Step 2 - Create a session with your server: {selectedEndpoint.EndpointUrl} ");
                using (var session = Session.Create(config, new ConfiguredEndpoint(null, selectedEndpoint, EndpointConfiguration.Create(config)), false, "", 60000, null, null).GetAwaiter().GetResult())
                {
                    Console.WriteLine("Step 3 - Browse the server namespace.");
                    ReferenceDescriptionCollection refs;
                    Byte[] cp;
                    session.Browse(null, null, ObjectIds.ObjectsFolder, 0u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method, out cp, out refs);

                    Console.WriteLine("Sesion Call Methods");

                    IList<object> vals = session.Call(
                        new NodeId(noteClassId),
                        new NodeId(noteId),
                        args
                        );
                    return vals;
                }

            }
            catch (Exception e)
            {

                throw e;
            }

        }

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
