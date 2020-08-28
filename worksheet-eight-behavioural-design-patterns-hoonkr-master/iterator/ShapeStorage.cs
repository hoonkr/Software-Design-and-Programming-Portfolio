namespace iterator
{
    public class ShapeStorage
    {
        private int _index;
        private Shape [] _shapes = new Shape[5];

        public void AddShape(string name)
        {
            int i = _index++;
            _shapes[i] = new Shape(i,name);
        }

        public Shape[] GetShapes()
        {
            return _shapes;
        }

        // Additional methods?

        // Indexer?z
    }
}