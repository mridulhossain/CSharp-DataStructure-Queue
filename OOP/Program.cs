using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue work fifo style(first in first out)
            // if you want to insert data in queue you have to use dataset.Enqueue(value) method.
            // if you want to see first data you can use peek method,like - dataset.Peek();
            //

            Queue<int> numbers = new Queue<int>();

            // you can add data by using enqueue method like this.
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);

            // check first data by using peek method
            Console.WriteLine(numbers.Peek());

            // you can remove first data by using dequeue method
            numbers.Dequeue();

            // let's check,remove or not.
            Console.WriteLine(numbers.Peek());

            // if you want to check exist or not,you can use contains method,it return boolean 
            Console.WriteLine(numbers.Contains(4));


            // you can count your dataset.
            Console.WriteLine(numbers.Count);

            //you can clear this data set using clear.
            numbers.Clear();
        }
    }
}


