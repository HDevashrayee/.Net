using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Miscellaneous
{
    public class Myclass
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }

    public class Tree<T>
    {
        public Tree<T> Left;
        public Tree<T> Right;
        public T Data;
    }
    public static class Binary_Tree
    {
        /*
        The following example shows two ways in which parallel tasks can be used to traverse a tree data structure. 
        The creation of the tree itself is left as an exercise.
         */

        public static void DoTree<T>(Tree<T> tree, Action<T> action)
        {
            if (tree == null)
                return;

            var left = Task.Factory.StartNew(()=> DoTree(tree.Left, action));
            var right = Task.Factory.StartNew(()=> DoTree(tree.Right, action));

            action(tree.Data);

            try
            {
                Task.WaitAll(left, right);
            }
            catch (AggregateException)
            {

            }
        }

        public static void DoTree2<T>(Tree<T> tree, Action<T> action)
        {
            if (tree == null) return;

            Parallel.Invoke(
                ()=> DoTree2(tree.Left, action),
                ()=> DoTree2(tree.Right, action),
                ()=> action(tree.Data));
        }
    }
}
