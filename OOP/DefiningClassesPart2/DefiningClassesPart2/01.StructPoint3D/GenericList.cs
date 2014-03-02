/*5. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
 * Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
 * Implement methods for adding element, accessing element by index, removing element by index, 
 * inserting element at given position, clearing the list, finding element by its value and ToString(). 
 * Check all input parameters to avoid accessing elements at invalid positions.*/

/*6. Implement auto-grow functionality: when the internal array is full, 
 * create a new array of double size and move all elements to it.*/

/*7. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
 * You may need to add a generic constraints for the type T.*/

namespace _01.StructPoint3D
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T>
    {
        #region fields
        private const int fixedCapacity = 5;

        private T[] elements;
        private int size = 0;
        #endregion

        #region constructors
        public GenericList(int fixedCapacity)
        {
            this.elements = new T[fixedCapacity];
        }

        public GenericList()
            : this(fixedCapacity)
        {

        }
        #endregion

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        #region methods
        //5.
        public void AddElement(T element)
        {
            if (elements.Length == size)
            {
                //extend array size
                AutoGrow();
            }

            this.elements[size] = element;
            size++;
        }

        //5.
        public T this[int index]
        {
            get
            {
                if (index > size || index < 0)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));       
                }

                T result = elements[index];

                return result;
            }
        }

        //5.
        public void RemoveElementByIndex(int index)
        {
            if (index > size || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index)); 
            }

            T[] shrinkedArray = new T[elements.Length - 1];

            for (int i = 0, j = 0; i < elements.Length; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }

                shrinkedArray[i] = elements[j];
            }

            size--;
            elements = shrinkedArray;
        }

        //5.
        public void InsertElementOnPosition(T element, int index)
        {
            if (index > size || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
            }

            T[] increasedArray = new T[elements.Length + 1];

            for (int i = 0, j = 0; i < elements.Length; i++, j++)
            {
                if (i == index)
                {
                    increasedArray[j] = element;
                    j++;
                }

                increasedArray[j] = elements[i];
            }

            size++;
            elements = increasedArray;
        }

        //5.
        public void FindElementByValue(T element)
        {
            bool isFound = false;
            
            foreach (var item in elements)
            {
                if (item.Equals(element))
                {
                    Console.WriteLine("The element '{0} has been found'", element);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No such element '{0} has been found'", element);
            }
        }

        //5.
        public void ClearList()
        {
            elements = new T[fixedCapacity];
            size = 0;
        }

        //5.
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var element in elements)
            {
                result.Append(element + " ");
            }
            
            return result.ToString();
        }

        //6.
        private void AutoGrow()
        {
            T[] doubledElementsSize = new T[2 * elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                doubledElementsSize[i] = elements[i];
            }

            elements = doubledElementsSize;
        }

        //7.
        public T Min<T>() where T : IComparable<T>, IComparable
        {
            dynamic min = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] < min)
                {
                    min = elements[i];
                }
            }

            return min;
        }

        public T Max<T>() where T : IComparable<T>, IComparable
        {
            dynamic max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] < max)
                {
                    max = elements[i];
                }
            }

            return max;
        }
        #endregion
    }
}
