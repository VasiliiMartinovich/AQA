namespace Lesson9;

public class MyFirstException : Exception
{
    public MyFirstException() : base () //Hresult
    {}
    public MyFirstException(string message) : base(message) //передает сообщение 
    {}
    public MyFirstException(string message, Exception inner) : base(message, inner) //передает innerException
    {}
}