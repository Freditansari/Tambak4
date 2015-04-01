using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace tambak.Web.WCFServices
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RunCmdShell
    {
        [OperationContract]
        public string runAverageCommand(string command)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + command);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();

                string result = proc.StandardOutput.ReadToEnd();

                return result;
            }
            catch (Exception g)
            {
                Console.WriteLine(g.Message.ToString());
                return g.Message.ToString();

            }
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
