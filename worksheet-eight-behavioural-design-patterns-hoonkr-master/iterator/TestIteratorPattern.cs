using System;

namespace iterator
{
    public static class TestIteratorPattern
    {
        public static void Main(string[] args)
        {
            var storage = new ShapeStorage();
            storage.AddShape("Polygon");
            storage.AddShape("Hexagon");
            storage.AddShape("Circle");
            storage.AddShape("Rectangle");
            storage.AddShape("Square");

            ShapeIterator iterator = new ShapeIterator(storage.GetShapes());

         //   var iterator = new ShapeIterator<ShapeStorage<Shape>>(storage);

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.next());
            }

            Console.WriteLine("Removing items while iterating...");
            iterator = new ShapeIterator(storage.GetShapes());

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.next());
                iterator.Dispose();
            }
        }
    }
}