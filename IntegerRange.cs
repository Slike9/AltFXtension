namespace Ekra14.AltFXtension
{
    public struct IntegerRange
    {
        private readonly int _min;
        public int Min
        {
            get { return _min; }
        }

        private readonly int _max;
        public int Max
        {
            get { return _max; }
        }

        #region ctor
        public IntegerRange(int min, int max)
        {
            _min = min;
            _max = max;
        } 
        #endregion

        public bool Contains(int item)
        {
            return item >= _min && item <= _max;
        }
    }
}