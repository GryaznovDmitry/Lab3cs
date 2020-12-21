using System;
using System.ComponentModel;
using System.Numerics;

namespace GryaznovLab3
{
    public abstract class V5Data: INotifyPropertyChanged
    {
        private string InfoData;
        private DateTime Time;
        public string infodata
        { 
            get 
            {
                return InfoData;
            } 
            set 
            {
                InfoData = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("InfoData"));
            } 
        }
        public DateTime time
        { 
            get 
            {
                return Time;
            } 
            set 
            {
                Time = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Time"));
            } 
        }
        public V5Data(string id = "Empty Data", DateTime t = default)
        {
            InfoData = id;
            Time = t;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public abstract Vector2[] NearEqual(float eps);
        public abstract string ToLongString();
        public override string ToString()
        {
            return InfoData + ", " + Time.ToString() + "\n\n";
        }
        public abstract string ToLongString(string format);
    }
}
