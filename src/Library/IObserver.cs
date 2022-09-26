using System;
namespace Observer
{
    public interface IObserver<T>
    {
        public void Update(T value);

    }
}