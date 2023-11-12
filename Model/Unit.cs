using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Model
{
    public abstract class Unit : INotifyPropertyChanged
    {
        // Fields
        public float _taxRate;
        public float TaxRate
        {
            get => _taxRate;
            set
            {
                if (_taxRate != value)
                {
                    _taxRate = value;
                    OnPropertyChanged(nameof(TaxRate));
                }
            }
        }
        public float Health { get; set; }
        public float Efficiency
        {
            get
            {
                float efficiency = 100;

                // Based on Health
                if (Health < 100)
                {
                    float difference = 100 - Health;
                    efficiency -= difference;
                }
                return efficiency;
            }
            set { }
        }

        // INotify Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
