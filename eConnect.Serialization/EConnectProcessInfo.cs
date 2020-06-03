namespace eConnect.Serialization
{
    public partial class EConnectProcessInfo
    {
        public EConnectProcessInfo() {}

        public EConnectProcessInfo(string server, string database)
        {
            ConnectionString = $"data source={server}; initial catalog={database};integrated security=SSPI; persist security info=False;packet size=4096";
        }
    }
}