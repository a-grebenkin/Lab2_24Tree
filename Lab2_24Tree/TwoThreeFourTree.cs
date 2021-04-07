using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab2
{
    class TwoThreeFourTree
    {
        public TwoThreeFourTree Parent
        {
            get; private set;
        }
        //public TwoThreeFourTree Left
        //{
        //    get; private set;
        //}
        //public TwoThreeFourTree MiddleLeft
        //{
        //    get; private set;
        //}
        //public TwoThreeFourTree MiddleRight
        //{
        //    get; private set;
        //}
        //public TwoThreeFourTree Right
        //{
        //    get; private set;
        //}

        private List<int> _values = new List<int>();

        public List<int> Values
        {
            get => _values;
            set => _values = value.OrderBy(number => number).ToList();
        }

        public int Type => _values.Count + 1;

        public TwoThreeFourTree(int value, TwoThreeFourTree parent = null)
        {
            var values = Values;
            values.Add(value);
            Values = values;
            Parent = parent;
            Children = new TwoThreeFourTree[4];
        }

        public TwoThreeFourTree(int? value, TwoThreeFourTree parent)
        {
            var values = Values;
            values.Add((int)value);
            Values = values;
            Parent = parent;
            Children = new TwoThreeFourTree[4];
        }

        public TwoThreeFourTree[] Children;

        public bool IsParent => Parent == null;

        public bool IsLeaf
        {
            get
            {
                for (int i = 0; i < Children.Length; i++)
                    if (Children[i] != null)
                        return false;
                return true;
            }
        }




        public static TwoThreeFourTree GetHead(TwoThreeFourTree tree)
        {
            if (tree == null)
                return null;

            var head = tree;

            while (!head.IsParent)
            {
                head =  head.Parent;
            }

            return head;
        }

        public static void Add(int value, TwoThreeFourTree tree)
        {
            switch (tree.Type)
            {
                // наткнулись на 4-узел => разбваем его
                case 4:
                    if (tree.IsParent)
                    {
                        //случай когда является корнем
                        int middle = tree.Values[1];
                        var vals = tree.Values;

                        //оставляем только центральное значение
                        var list = new List<int>
                        {
                            middle
                        };
                        tree.Values = list;

                        //остальные значения раскидываем по новым детям 

                        var tree1 = new TwoThreeFourTree(vals[0], tree);
                        var tree2 = new TwoThreeFourTree(vals[2], tree);


                        // назначаем новых детей родителями для старых детей

                        //указываем их родителями

                        
                        if (tree.Children[0]!= null)
                            tree.Children[0].Parent = tree1;
                        if (tree.Children[1] != null)
                            tree.Children[1].Parent = tree1;
                        if (tree.Children[2] != null)
                            tree.Children[2].Parent = tree2;
                        if (tree.Children[3] != null)
                            tree.Children[3].Parent = tree2;

                        //указываем их детей
                        tree1.Children[0] = tree.Children[0];
                        tree1.Children[1] = tree.Children[1];
                        tree2.Children[0] = tree.Children[2];
                        tree2.Children[1] = tree.Children[3];


                        //Убираем всех предыдущих детей
                        for (int i = 0; i < tree.Children.Length; i++)
                        {
                            tree.Children[i] = null;
                        }

                        //Назначаем новых детей 

                        int k = 0;
                        for (int i = 0; i < tree.Children.Length; i++)
                        {
                            if (tree.Children[i] == null)
                            {
                                tree.Children[i] = tree1;
                                k = i;
                                break;
                            }
                        }
                        for (int i = k; i < tree.Children.Length; i++)
                        {
                            if (tree.Children[i] == null)
                            {
                                tree.Children[i] = tree2;
                                break;
                            }
                        }

                        if (tree.Children[1] != null && tree.Children[2] != null && (tree.Children[0].Values[1]>tree.Children[2].Values[0]))
                        {
                            var tmp = tree.Children[2];
                            tree.Children[2] = tree.Children[1];
                            tree.Children[1] = tmp;
                        }


                    }
                    else
                    {
                        //случай когда не является корнем

                        // добавляем центральное значение в список значений родителя
                        var valsParent = tree.Parent.Values;
                        valsParent.Add(tree.Values[1]);
                        tree.Parent.Values = valsParent;

                        var vals = tree.Values;

                        //удаляем текущий узел из детей родителя 

                        for (int i = 0; i < tree.Parent.Children.Length; i++)
                        {
                            if (tree == tree.Parent.Children[i])
                            {
                                tree.Parent.Children[i] = null; 
                                break;
                            }
                        }
                        
                        // крайние значения раскидываем по 2 новым узлам

                        var tree1 = new TwoThreeFourTree(vals[0], tree.Parent);
                        var tree2 = new TwoThreeFourTree(vals[2], tree.Parent);

                        //записываем новые узлы детьми к родителю
                        int k=0;
                        for (int i= 0; i < tree.Children.Length; i++)
                        {
                            if (tree.Parent.Children[i]==null)
                            {
                                tree.Parent.Children[i] = tree1;
                                k = i;
                                break;
                            }
                        }
                        for (int i=k ;i < tree.Children.Length; i++)
                        {
                            if (tree.Parent.Children[i] == null)
                            {
                                tree.Parent.Children[i] = tree2;
                                break;
                            }
                        }

                        if (tree.Parent.Children[1] != null && tree.Parent.Children[2] != null && (tree.Parent.Children[1].Values[0] > tree.Parent.Children[2].Values[0]))
                        {
                            var tmp = tree.Parent.Children[2];
                            tree.Parent.Children[2] = tree.Parent.Children[1];
                            tree.Parent.Children[1] = tmp;
                        }

                        //назначаем новые узлы родителями детям старого узла

                        //указываем их родителями
                        if (tree.Children[0] != null)
                            tree.Children[0].Parent = tree1;
                        if (tree.Children[1] != null)
                            tree.Children[1].Parent = tree1;
                        if (tree.Children[2] != null)
                            tree.Children[2].Parent = tree2;
                        if (tree.Children[3] != null)
                            tree.Children[3].Parent = tree2;

                        //указываем их детей
                        tree1.Children[0] = tree.Children[0];
                        tree1.Children[1] = tree.Children[1];

                        tree2.Children[0] = tree.Children[2];
                        tree2.Children[1] = tree.Children[3];

                        tree = tree.Parent;
                    }
                    break;
                default:
                    {
                        if (tree.IsLeaf)
                        {
                            var values = tree.Values;
                            values.Add((int)value);
                            tree.Values = values;
                            return;
                        }
                    }
                    break;
            }
            //сюда попадаем после разбиения 4-узла
            int n=0;
            for(int i=0;i<tree.Values.Count;i++)
            {
                if (value<tree.Values[i])
                {
                    if (tree.Children[i]!=null)
                        Add(value,tree.Children[i]);
                    else
                    {
                        tree.Children[i] = new TwoThreeFourTree(value, tree);
                    }
                    return;
                }
                n = i;
            }
            if (tree.Children[n+1] != null)
                Add(value, tree.Children[n+1]);
            else
            {
                tree.Children[n+1] = new TwoThreeFourTree(value, tree);
            }
        }
    }
}
