namespace Tree {
    class Program {
        static void Main(string[] args) {
            var tree = new Tree();
            tree.Add(8);
            tree.Add(3);
            tree.Add(1);
            tree.Add(6);
            tree.Add(7);
            tree.Add(10);
            tree.Add(14);
            tree.Add(4);
            tree.Search(7);
            /*tree.Add(1);
            tree.Add(3);
            tree.Add(4);
            tree.Add(6);
            tree.Add(7);
            tree.Add(8);
            tree.Add(10);
            tree.Add(13);
            tree.Add(14); // */
        }
    }
}