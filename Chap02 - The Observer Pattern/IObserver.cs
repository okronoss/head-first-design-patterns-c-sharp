namespace Chap02
{
    public interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);
    }
}