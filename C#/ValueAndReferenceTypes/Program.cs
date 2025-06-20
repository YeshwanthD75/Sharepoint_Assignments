﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueAndReferenceTypes
{
    #region Simple structure
    struct Point
    {
        // Fields of the structure.
        public int X;
        public int Y;

        // Add 1 to the (X, Y) position.
        public void Increment()
        {
            X++; Y++;
        }

        // Subtract 1 from the (X, Y) position.
        public void Decrement()
        {
            X--; Y--;
        }

        // Display the current position.
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }

        // A custom constructor.
        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }
    }
    #endregion

    #region Simple class
    class PointRef
    {
        // Fields of the structure.
        public int X;
        public int Y;

        // Add 1 to the (X, Y) position.
        public void Increment()
        {
            X++; Y++;
        }

        // Subtract 1 from the (X, Y) position.
        public void Decrement()
        {
            X--; Y--;
        }

        // Display the current position.
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }

        // A custom constructor.
        public PointRef(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }
    }
    #endregion

    #region Struct containing class!
    class ShapeInfo
    {
        public string InfoString;
        public ShapeInfo(string info)
        { InfoString = info; }
    }

    struct Rectangle
    {
        // The Rectangle structure contains a reference type member.
        public ShapeInfo RectInfo;

        public int RectTop, RectLeft, RectBottom, RectRight;

        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            RectInfo = new ShapeInfo(info);
            RectTop = top; RectBottom = bottom;
            RectLeft = left; RectRight = right;
        }

        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
                              "Left = {3}, Right = {4}",
                RectInfo.InfoString, RectTop, RectBottom, RectLeft, RectRight);
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Values types / Reference types *****\n");
            //ValueTypeAssignment();
            //Console.WriteLine();

            ReferenceTypeAssignment();
            Console.WriteLine();

        }

        #region Structures and assignment operator
        // Assigning two intrinsic value types results in
        // two independent variables on the stack.
        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning value types\n");

            Point p1 = new Point(10, 10);
            Point p2 = p1;

            // Print both points.
            p1.Display();
            p2.Display();

            // Change p1.X and print again. p2.X is not changed.
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }
        #endregion

        #region Classes and assignment operator
        static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning reference types\n");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;

            // Print both point refs.
            p1.Display();
            p2.Display();

            // Change p1.X and print again.
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }
        #endregion
    }
}