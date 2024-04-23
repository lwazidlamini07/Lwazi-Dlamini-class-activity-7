using System;
public interface IPlayable
{
    void Play();
}
public class Guitar : IPlayable
{
    void IPlayable.Play()
    {
        Console.WriteLine("GUITAR IS NOW PLAYING!");
    }
}
public class Piano : IPlayable
{
    void IPlayable.Play()
    {
        Console.WriteLine("PIANO IS NOW PLAYING!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Guitar guitar = new Guitar();
        Piano piano = new Piano();
        ((IPlayable)guitar).Play();
        ((IPlayable)piano).Play();
    }
}