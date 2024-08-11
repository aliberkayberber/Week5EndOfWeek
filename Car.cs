namespace Factory
{
    class Car
    {
        public Car()
        {
            _productionTime = DateTime.Now;
        }
        private DateTime _productionTime;
        private string _seriNumber;
        private string _brand;
        private string _model;
        private string _color;
        private int _doorCount;

        public DateTime ProductionTime
        {
            get{return _productionTime;}
            set{_productionTime = value;}
        }
        public string SeriNumber
        {
            get{return _seriNumber;}
            set{_seriNumber =value;}
        }
        public string Brand
        {
            get{return _brand;}
            set{_brand = value;}
        }
        public string Model
        {
            get{return _model;}
            set{_model =value;}
        }
        public string Color
        {
            get{return _color;}
            set{_color = value;}
        }
        public int DoorCount
        {
            get{return _doorCount;}
            set{_doorCount = value;}
        }
    }
}