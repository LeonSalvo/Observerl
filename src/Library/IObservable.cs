using System;
namespace Observer
{
    public interface IObservable<T>
    {
        public void Subscribe(IObserver<T> observer);
        public void Unsubscribe(IObserver<T> observer);
    }
}