using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derevolab9
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
/* Класс Node представляет узел дерева с двумя ссылками на левое и правое поддерево, а класс 
 * Tree представляет само дерево с корневым узлом. В классе Tree определены методы Add() для
 * добавления узлов и Search() для поиска узлов в дереве. Метод Add() обходит дерево в поисках места 
 * для вставки нового узла, а метод Search() ищет узел с заданным значением.
 * Оба метода реализованы с помощью рекурсивных вызовов.
 */