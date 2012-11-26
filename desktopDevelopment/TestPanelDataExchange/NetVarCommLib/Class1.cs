using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetVarCommLib
{
    public class CommWorker : IDisposable
    {
        //==========================================================

        #region constants_static_readonly_data_fields

        private static int instanceId;
        private const int maxAllowedInstanceCount = 10;

        #endregion

        //==========================================================

        #region variable_data_fields

        private string instanceName;

        #endregion

        //==========================================================

        #region properties

        public static int InstanceId
        {
            get { return instanceId; }
            private set
            {
                if (value <= maxAllowedInstanceCount)
                    instanceId = value;
                else
                    throw new InvalidOperationException();
            }
        }

        #endregion

        //==========================================================

        #region constructors

        public CommWorker()
        {
            InstanceId++;
        }

        #endregion

        //==========================================================

        #region methods

        #region interface_methods

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

        public void Transmit (byte[] dataStream)
        {
            throw new NotImplementedException("Transmit method not implmented yet!");
        }

        #endregion
    }
}
