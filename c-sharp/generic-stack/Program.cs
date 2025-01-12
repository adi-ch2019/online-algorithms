using System;
using System.Collections.Generic;

public class GenericStack<T>
{
    private List<T> _items = new List<T>();

    public void Push(T item)
    {
        _items.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        int lastIndex = _items.Count - 1;
        T item = _items[lastIndex];
        _items.RemoveAt(lastIndex);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        return _items[_items.Count - 1];
    }

    public bool IsEmpty()
    {
        return _items.Count == 0;
    }

    public int Count
    {
        get { return _items.Count; }
    }
}

// Example usage
class Program
{
    static void Main(string[] args)
    {
        GenericStack<int> stack = new GenericStack<int>();
        
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine($"Count: {stack.Count}"); // Output: Count: 3
        Console.WriteLine($"Peek: {stack.Peek()}"); // Output: Peek: 3
        Console.WriteLine($"Pop: {stack.Pop()}");   // Output: Pop: 3
        Console.WriteLine($"Count: {stack.Count}"); // Output: Count: 2
        Console.WriteLine($"IsEmpty: {stack.IsEmpty()}"); // Output: IsEmpty: False
    }
}