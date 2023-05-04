using derevolab9;

class Program
{
    static void Main(string[] args)
    {
        Tree tree = new Tree();

        // Добавление узлов
        tree.Add(10);
        tree.Add(5);
        tree.Add(15);
        tree.Add(3);
        tree.Add(7);
        tree.Add(12);
        tree.Add(17);

        // Поиск узла
        Node node = tree.Search(15);
        if (node != null)
        {
            Console.WriteLine("Узел найден: " + node.Data);
        }
        else
        {
            Console.WriteLine("Узел не найден");
        }

        Console.ReadKey();
    }
}