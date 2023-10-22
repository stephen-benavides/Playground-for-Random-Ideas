using System;

namespace HelloPractice.Problems.Udemy.Intermediate
{
    class MethodPracticePoint
    {
        private int _x;
        private int _y;

        public MethodPracticePoint(int x, int y)
        {
            this._x = x;
            this._y = y;

        }

        public void Move(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public void Move(MethodPracticePoint newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation ");
            Move(x: newLocation._x, y: newLocation._y);
        }
    }
}