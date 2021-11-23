using System;

namespace Chap02___WeatherStation
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private WeatherData _weatherData;

        private float _avgTemperature;
        private int _count;
        private float _maxTemperature = float.MinValue;
        private float _minTemperature = float.MaxValue;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            if (_maxTemperature < _temperature) _maxTemperature = _temperature;
            if (_minTemperature > _temperature) _minTemperature = _temperature;
            _count++;
            _avgTemperature = (_avgTemperature * (_count - 1) + _temperature) / _count;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {_avgTemperature:F1}/{_maxTemperature:F1}/{_minTemperature:F1}");
        }

   }
}