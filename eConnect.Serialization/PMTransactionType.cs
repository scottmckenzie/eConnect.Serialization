namespace eConnect.Serialization
{
    public partial class PMTransactionType
    {
        private int _distSequenceCounter;
        private TaPMDistribution_ItemsTaPMDistribution _pay;
        private TaPMDistribution_ItemsTaPMDistribution _taxes;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public int DistributionSequenceCounter
        {
            get
            {
                return _distSequenceCounter;
            }
            set
            {
                _distSequenceCounter = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TaPMDistribution_ItemsTaPMDistribution PMPayDistribution
        {
            get
            {
                return _pay;
            }
            set
            {
                _pay = value;
                _taPMDistribution_Items.Add(value);
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TaPMDistribution_ItemsTaPMDistribution PMTaxesDistribution
        {
            get
            {
                return _taxes;
            }
            set
            {
                _taxes = value;
                _taPMDistribution_Items.Add(value);
            }
        }
   }
}