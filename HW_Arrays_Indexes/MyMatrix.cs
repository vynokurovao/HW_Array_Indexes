using System;
using System.Collections.Generic;

namespace HW_Arrays_Indexes_task1
{
    public class MyMatrix
    {
        private int _rows;
        private int _columns;
        private List<List<int>> _matrix;

        public int Rows
        {
            get { return _rows; }
            set 
            {
                int oldCapacity = _rows;
                _rows = value;
                if (_rows > oldCapacity)
                {
                    for (int i = oldCapacity; i < value; i++)
                    {
                        _matrix.Add(new List<int>(Columns));
                        for (int j = 0; j < Columns; j++)
                        {
                            _matrix[i].Add(0);
                        }
                    }
                }
            }
        }

        public int Columns
        {
            get { return _columns; }
            set 
            {
                int oldCapacity = _columns;
                _columns = value;
                if (value > oldCapacity)
                {
                    for (int i = 0; i < Rows; i++)
                    {
                        for (int j = oldCapacity; j < value; j++)
                        {
                           _matrix[i].Add(0);
                        }
                    }
                }
                else 
                {
                    for (int i = 0; i < Rows; i++)
                    {
                        _matrix[i].RemoveRange(value, oldCapacity - value);
                    }
                }
            }
        }

        public int this[int i, int j]
        {
            get { return _matrix[i][j]; }

            set { _matrix[i][j] = value; }
        }

        public MyMatrix(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            _matrix = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                _matrix.Add(new List<int>(columns));
                for (int j = 0; j < columns; j++)
                {
                    _matrix[i].Add(0);
                }
            }
        }
    }
}
