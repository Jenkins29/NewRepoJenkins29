namespace AdApp
{
    public class TVAd: Advert
    {
        private int _airTime;
        private int _peakTime;
        private bool _isPeakTime;
        public TVAd(int fee) : base(fee)
        {
        }

        public TVAd(int fee, int airTime, int peakTime, bool isPeakTime) : base(fee)
        {
            _airTime = airTime;
            _peakTime = peakTime;
            _isPeakTime = isPeakTime;
        }
        
        public override int Cost() 
        {
            var fee = base.Cost();
            var cost = (_airTime - _peakTime) * fee;

            if (_isPeakTime)
            {
                cost += fee * _peakTime * 2;
            }
            return cost;
        }

        public override string ToString() 
        {
            return "\nTV ad Costs: " + Cost();
        }
    }
}