using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVisual
{
    class Sorts
    {
        protected Visualize visual;
        protected int size;
        protected int[] arr;

        public Sorts(Visualize visual, int[] arr, int size)
        {
            this.visual = visual;
            this.size = size;
            this.arr = arr;
        }

        public void swap(int p, int q)
        {
            int temp = arr[p];
            arr[p] = arr[q];
            arr[q] = temp;
            visual.swap(p, q);
        }

        public virtual bool next()
        {
            return true;
        }
    }


    class Insertion_Sort : Sorts
    {
        public Insertion_Sort(Visualize visual, int[] arr, int size) : base(visual, arr, size)
        {

        }

        private int i = 0;

        public void sort()
        {

        }

        public override bool next()
        {
            if (i == size + 1) return true;
            for (int j = i - 1; j > 0; j--)
            {
                if (arr[j] < arr[j - 1])
                    swap(j, j - 1);
                else
                    break;
            }
            i++;
            return false;
        }
    }

    class Selection_Sort : Sorts
    {
        public Selection_Sort(Visualize visual, int[] arr, int size) : base(visual, arr, size)
        {

        }

        public void sort()
        {
            int[] aux = new int[size];
            arr.CopyTo(aux, 0);
            for (int j = 0; j < size - 1; j++)
            {
                int minIndex = j;
                for (int k = j; k < size; k++)
                {
                    if (aux[k] < aux[minIndex])
                        minIndex = k;
                }
                int temp = aux[minIndex];
                aux[minIndex] = aux[j];
                aux[j] = temp;
            }
            return;
        }

        private int i = 0;

        public override bool next()
        {
            if (i == size - 1)
                return true;
            int minIndex = i + 1;
            for (int j = i + 1; j < size; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            swap(i, minIndex);
            i++;
            return false;
        }
    }
}
