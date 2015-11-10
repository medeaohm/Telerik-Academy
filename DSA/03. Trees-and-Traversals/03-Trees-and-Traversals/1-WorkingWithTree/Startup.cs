//1. You are given a ** tree of N nodes** represented as a set of `N-1` pairs of nodes(parent node, child node), each in the range(`0..N-1`).
//   Write a program to read the tree and find:  
//       1. the root node
//       2. all leaf nodes
//       3. all middle nodes
//       4. the longest path in the tree
//       5. (*) all paths in the tree with given sum `S` of their nodes
//       6. (*) all subtrees with given sum `S` of their nodes

namespace WorkingWithTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        static void Main()
        {
            Tree<int> tree =
                new Tree<int>(7,
                      new Tree<int>(19,
                                    new Tree<int>(1),
                                    new Tree<int>(12),
                                    new Tree<int>(31)),
                      new Tree<int>(21),
                      new Tree<int>(14,
                                    new Tree<int>(23),
                                    new Tree<int>(6)));

            Console.WriteLine("Tree:");
            tree.TraverseDFS();
            Console.WriteLine();

            Console.WriteLine("The root is: {0}", tree.GetRoot());
            Console.WriteLine();

            Console.Write("Leaf nodes: ");
            tree.GetLeaves();
            Console.WriteLine("\n");

            Console.Write("Middle nodes: ");
            tree.GetMiddle();
            Console.WriteLine("\n");

            var longestPaths = GetLongestPath(tree);
            var pathStrings = longestPaths.Select(path => string.Join(" -> ", path.Reverse())).ToArray();
            Console.WriteLine("Longest path(s):\n" + string.Join("\n", pathStrings));
            Console.WriteLine();
        }


        private static void GetPathsFromNode(Node<int> node, Stack<Node<int>> stack, List<Node<int>[]> paths)
        {
            stack.Push(node);
            paths.Add(stack.ToArray());

            foreach (var child in node.Children)
            {
                GetPathsFromNode(child, stack, paths);
            }

            stack.Pop();
        }

        private static List<Node<int>[]> GetLongestPath(Tree<int> tree)
        {
            List<Node<int>[]> paths = new List<Node<int>[]>();
            GetPathsFromNode(tree.GetRoot(), new Stack<Node<int>>(), paths);
            paths = paths.OrderByDescending(path => path.Length).GroupBy(path => path.Length).First().ToList();
            return paths;
        }

        private static void GetPath(Node<int> node, Stack<Node<int>> path, List<Node<int>[]> paths)
        {
            path.Push(node);

            foreach (var child in node.Children)
            {
                GetPath(child, path, paths);
            }

            if (!node.HasChildren)
                paths.Add(path.ToArray());

            path.Pop();
        }


    }
}
