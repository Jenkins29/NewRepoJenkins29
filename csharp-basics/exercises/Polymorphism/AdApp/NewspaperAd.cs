namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _cm;

        public NewspaperAd(int fee) : base(fee)
        {
        }

        public NewspaperAd(int fee, int column, int cm) : base(fee)
        {
            _column = column;
            _cm = cm;
        }

        public override int Cost()
        {
            var fee = base.Cost();
            fee += _column * _cm;

            return fee;
        }

        public override string ToString()
        {
            return "\nNewspaper fee: " + Cost();
        }
    }
}