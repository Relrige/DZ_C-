using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OVERLOAD
{
        class Vector
        {

            private int x, y;
            public Vector(int x, int y)
            {
                X = x;
                Y = y;
            }
            public double Length
            {
                get => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            }
            public int X
            {
                get => x;
                set => x = value;
            }
            public int Y
            {
                get => y;
                set => y = value;
            }
            public override string ToString()
            {
                return $"Vector : ({X} , {Y})";
            }
            public static Vector operator +(Vector v1, Vector v2)
            {
                return new Vector((v1.X + v2.X), (v1.Y + v2.Y));
            }

            public static Vector operator ++(Vector v)
            {
                return new Vector((v.X + 1), (v.Y + 1));
            }
            public static Vector operator --(Vector v)
            {
                return new Vector((v.X - 1), (v.Y - 1));
            }
        public static Vector operator- (Vector v) 
        {
            return new Vector((-v.X), (-v.Y));
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector((v1.X - v2.X), (v1.Y - v2.Y));
        }
        public static bool operator true(Vector v)
            {
                return (v.X != 0 || v.Y != 0);
            }
            public static bool operator false(Vector v)
            {
                return (v.X == 0 && v.Y == 0);
            }
            public int this[int index]
            {
                get
                {
                    if (index == 0)
                    {
                        return X;
                    }
                    else if (index == 1)
                    {
                        return Y;
                    }
                    else
                    {
                        throw new Exception("bad index ");
                    }
                }
            }



        public static Vector operator *(Vector v1, int num)
        {
            return new Vector(v1.X * num, v1.Y * num);
        }
        public static Vector operator *(Vector v1, Vector v2)
        {
            return new Vector(v1.X * v2.X, v1.Y * v2.Y);
        }
        public override bool Equals(object obj)
            {
                Vector v = obj as Vector;
                if (v == null)
                {
                    return false;
                }
                return (this.X == v.X && this.Y == v.Y);
            }
            public override int GetHashCode()
            {
                return this.ToString().GetHashCode();
            }
            public static bool operator ==(Vector v1, Vector v2)
            {
                if (ReferenceEquals(v1, v2))
                {
                    return true;
                }
                if (v1 is null)
                {
                    return false;
                }
                return v1.Equals(v2);
            }
            public static implicit operator Vector(int v)
            {
                return new Vector(v, 0);
            }
            public static bool operator !=(Vector v1, Vector v2)
            {
                return !(v1 == v2);
            }
        public static explicit operator double(Vector v)
        {
            return (double)(v.Length);
        }
    }
    
}
