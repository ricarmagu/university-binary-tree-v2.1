using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeUniversity
{
    class UniversityTree
    {

        public PositionNode Root;
        public PositionNode NodoTemp = null;
        float higher = 0;


        public void CreatePosition(PositionNode parent,
            Position positionToCreate,
            string parentPositionName)
        {

            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;

            if (Root == null)
            {
                Root = newNode;
                return;
            }
            if (parent == null) return;


            if (parent.Position.Name == parentPositionName)
            {

                if (parent.Left == null)
                {
                    parent.Left = newNode;
                    return;
                }

                parent.Right = newNode;
                return;
            }

            CreatePosition(parent.Left, positionToCreate, parentPositionName);
            CreatePosition(parent.Right, positionToCreate, parentPositionName);
        }


        public void PrintTree(PositionNode node)
        {
            if (node == null) return;

            Console.WriteLine("{0,30} {1,10} {2,10} {3,10}", $"{node.Position.Name}:", $"{node.Position.Salary}", $"{node.Position.Percentage}", $"{node.Position.TaxValue}");


            PrintTree(node.Left);
            PrintTree(node.Right);
        }

        public float SumSalaries(PositionNode node)
        {
            if (node == null) return 0;

            return node.Position.Salary + SumSalaries(node.Left) + SumSalaries(node.Right);
        }


        public float SalaryHigher(PositionNode node)
        {
            if (node != null)
            {
                if (higher < node.Position.Salary)
                    higher = node.Position.Salary;

                float higherValueLeft = SalaryHigher(node.Left);
                float higherValueRight = SalaryHigher(node.Right);

                if (higherValueLeft > higherValueRight) return higherValueLeft;

                return higherValueRight;
            }

            return higher;
        }


        public float Count(PositionNode from)
        {
            if (from == null) return 0;

            float countLeft = Count(from.Left);
            float countRight = Count(from.Right);

            return countLeft + countRight + 1;
        }


        public PositionNode SearchNode(PositionNode node, String name)
        {
            if (node != null)
            {

                if (node.Position.Name.Equals(name)) return node;
                else
                {

                    NodoTemp = SearchNode(node.Left, name);
                    if (NodoTemp == null)
                        NodoTemp = SearchNode(node.Right, name);
                }
            }
            return NodoTemp;
        }


        public float SumTax(PositionNode node)
        {
            if (node == null) return 0;

            return node.Position.TaxValue + SumTax(node.Left) + SumTax(node.Right);
        }
    }
}