using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    /// <Author>
    /// Erwin Bonnet
    /// </Author>
    public class CharData
    {
        /// <summary>
        /// True means that it should be colored, false means that it should be white
        /// </summary>
        private Dictionary<Point, bool> _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m, _n, _o, _p, _q, _r, _s, _t, _u, _v, _w, _x, _y, _z;
        private Dictionary<Point, bool> _1, _2, _3, _4, _5, _6, _7, _8, _9, _0;

        private List<Dictionary<Point, bool>> _char;
        private static CharData _instance;

        private CharData() { }

        public static CharData Data
        {
            get
            {
                if (_instance == null)
                    _instance = new CharData();
                return _instance;
            }
        }

        public List<Dictionary<Point, bool>> Characters
        {
            get
            {
                if (_char == null)
                {
                    _char = new List<Dictionary<Point, bool>>();
                    _char.Add(A);
                    _char.Add(B);
                    _char.Add(C);
                    _char.Add(D);
                    _char.Add(E);
                    _char.Add(F);
                    _char.Add(G);
                    _char.Add(H);
                    _char.Add(I);
                    _char.Add(J);
                    _char.Add(K);
                    _char.Add(L);
                    _char.Add(M);
                    _char.Add(N);
                    _char.Add(O);
                    _char.Add(P);
                    _char.Add(Q);
                    _char.Add(R);
                    _char.Add(S);
                    _char.Add(T);
                    _char.Add(U);
                    _char.Add(V);
                    _char.Add(W);
                    _char.Add(X);
                    _char.Add(Y);
                    _char.Add(Z);
                    _char.Add(n0);
                    _char.Add(n1);
                    _char.Add(n2);
                    _char.Add(n3);
                    _char.Add(n4);
                    _char.Add(n5);
                    _char.Add(n6);
                    _char.Add(n7);
                    _char.Add(n8);
                    _char.Add(n9);
                }
                return _char;
            }
        }

        public Dictionary<Point, bool> A {
            get
            {
                if (_a == null)
                {
                    _a = new Dictionary<Point, bool>();

                    _a.Add(new Point(46, 15), true);
                    _a.Add(new Point(29, 46), true);
                    _a.Add(new Point(62, 45), true);
                    _a.Add(new Point(18, 73), true);
                    _a.Add(new Point(72, 74), true);
                    _a.Add(new Point(43, 76), true);
                    _a.Add(new Point(80, 102), true);
                    _a.Add(new Point(8, 104), true);

                    _a.Add(new Point(15, 17), false);
                    _a.Add(new Point(73, 18), false);
                    _a.Add(new Point(46, 38), false);
                    _a.Add(new Point(8, 54), false);
                    _a.Add(new Point(80, 54), false);
                    _a.Add(new Point(39, 62), false);
                    _a.Add(new Point(53, 63), false);
                    _a.Add(new Point(27, 90), false);
                    _a.Add(new Point(59, 91), false);
                    _a.Add(new Point(45, 99), false);
                    _a.Add(new Point(26, 106), false);
                    _a.Add(new Point(63, 104), false);
                }
                return _a;
            }
        }

        public Dictionary<Point, bool> B
        {
            get
            {
                if (_b == null)
                {
                    _b = new Dictionary<Point, bool>();

                    _b.Add(new Point(29, 8), true);
                    _b.Add(new Point(55, 11), true);
                    _b.Add(new Point(8, 14), true);
                    _b.Add(new Point(62, 33), true);
                    _b.Add(new Point(7, 47), true);
                    _b.Add(new Point(33, 49), true);
                    _b.Add(new Point(59, 54), true);
                    _b.Add(new Point(6, 77), true);
                    _b.Add(new Point(65, 88), true);
                    _b.Add(new Point(6, 100), true);
                    _b.Add(new Point(44, 102), true);

                    _b.Add(new Point(72, 6), false);
                    _b.Add(new Point(27, 24), false);
                    _b.Add(new Point(46, 32), false);
                    _b.Add(new Point(77, 25), false);
                    _b.Add(new Point(76, 50), false);
                    _b.Add(new Point(25, 77), false);
                    _b.Add(new Point(52, 86), false);
                    _b.Add(new Point(26, 89), false);
                    _b.Add(new Point(77, 107), false);
                }
                return _b;
            }
        }

        public Dictionary<Point, bool> C
        {
            get
            {
                if (_c == null)
                {
                    _c = new Dictionary<Point, bool>();

                    _c.Add(new Point(33, 5), true);
                    _c.Add(new Point(59, 3), true);
                    _c.Add(new Point(11, 23), true);
                    _c.Add(new Point(8, 43), true);
                    _c.Add(new Point(7, 65), true);
                    _c.Add(new Point(10, 91), true);
                    _c.Add(new Point(22, 104), true);
                    _c.Add(new Point(32, 115), true);
                    _c.Add(new Point(44, 121), true);
                    _c.Add(new Point(58, 120), true);
                    _c.Add(new Point(72, 117), true);

                    _c.Add(new Point(8, 7), false);
                    _c.Add(new Point(37, 29), false);
                    _c.Add(new Point(60, 30), false);
                    _c.Add(new Point(28, 61), false);
                    _c.Add(new Point(49, 60), false);
                    _c.Add(new Point(67, 61), false);
                    _c.Add(new Point(39, 94), false);
                    _c.Add(new Point(66, 96), false);
                    _c.Add(new Point(6, 117), false);
                }
                return _c;
            }
        }

        public Dictionary<Point, bool> D
        {
            get
            {
                if (_d == null)
                {
                    _d = new Dictionary<Point, bool>();


                }
                return _d;
            }
        }

        public Dictionary<Point, bool> E
        {
            get
            {
                if (_e == null)
                {
                    _e = new Dictionary<Point, bool>();


                }
                return _e;
            }
        }

        public Dictionary<Point, bool> F
        {
            get
            {
                if (_f == null)
                {
                    _f = new Dictionary<Point, bool>();


                }
                return _f;
            }
        }

        public Dictionary<Point, bool> G
        {
            get
            {
                if (_g == null)
                {
                    _g = new Dictionary<Point, bool>();


                }
                return _g;
            }
        }

        public Dictionary<Point, bool> H
        {
            get
            {
                if (_h== null)
                {
                    _h = new Dictionary<Point, bool>();


                }
                return _h;
            }
        }

        public Dictionary<Point, bool> I
        {
            get
            {
                if (_i == null)
                {
                    _i = new Dictionary<Point, bool>();


                }
                return _i;
            }
        }

        public Dictionary<Point, bool> J
        {
            get
            {
                if (_j == null)
                {
                    _j = new Dictionary<Point, bool>();


                }
                return _j;
            }
        }

        public Dictionary<Point, bool> K
        {
            get
            {
                if (_k == null)
                {
                    _k = new Dictionary<Point, bool>();


                }
                return _k;
            }
        }

        public Dictionary<Point, bool> L
        {
            get
            {
                if (_l == null)
                {
                    _l = new Dictionary<Point, bool>();


                }
                return _l;
            }
        }

        public Dictionary<Point, bool> M
        {
            get
            {
                if (_m == null)
                {
                    _m = new Dictionary<Point, bool>();


                }
                return _m;
            }
        }

        public Dictionary<Point, bool> N
        {
            get
            {
                if (_n == null)
                {
                    _n = new Dictionary<Point, bool>();


                }
                return _n;
            }
        }

        public Dictionary<Point, bool> O
        {
            get
            {
                if (_o == null)
                {
                    _o = new Dictionary<Point, bool>();


                }
                return _o;
            }
        }

        public Dictionary<Point, bool> P
        {
            get
            {
                if (_p == null)
                {
                    _p = new Dictionary<Point, bool>();


                }
                return _p;
            }
        }

        public Dictionary<Point, bool> Q
        {
            get
            {
                if (_q == null)
                {
                    _q = new Dictionary<Point, bool>();


                }
                return _q;
            }
        }

        public Dictionary<Point, bool> R
        {
            get
            {
                if (_r == null)
                {
                    _r = new Dictionary<Point, bool>();


                }
                return _r;
            }
        }

        public Dictionary<Point, bool> S
        {
            get
            {
                if (_s == null)
                {
                    _s = new Dictionary<Point, bool>();


                }
                return _s;
            }
        }

        public Dictionary<Point, bool> T
        {
            get
            {
                if (_t == null)
                {
                    _t = new Dictionary<Point, bool>();


                }
                return _t;
            }
        }

        public Dictionary<Point, bool> U
        {
            get
            {
                if (_u == null)
                {
                    _u = new Dictionary<Point, bool>();


                }
                return _u;
            }
        }

        public Dictionary<Point, bool> V
        {
            get
            {
                if (_v == null)
                {
                    _v = new Dictionary<Point, bool>();


                }
                return _v;
            }
        }

        public Dictionary<Point, bool> W
        {
            get
            {
                if (_w == null)
                {
                    _w = new Dictionary<Point, bool>();


                }
                return _w;
            }
        }

        public Dictionary<Point, bool> X
        {
            get
            {
                if (_x == null)
                {
                    _x = new Dictionary<Point, bool>();


                }
                return _x;
            }
        }

        public Dictionary<Point, bool> Y
        {
            get
            {
                if (_y == null)
                {
                    _y = new Dictionary<Point, bool>();


                }
                return _y;
            }
        }

        public Dictionary<Point, bool> Z
        {
            get
            {
                if (_z == null)
                {
                    _z = new Dictionary<Point, bool>();


                }
                return _z;
            }
        }

        public Dictionary<Point, bool> n1
        {
            get
            {
                if (_1 == null)
                {
                    _1 = new Dictionary<Point, bool>();


                }
                return _1;
            }
        }

        public Dictionary<Point, bool> n2
        {
            get
            {
                if (_2 == null)
                {
                    _2 = new Dictionary<Point, bool>();


                }
                return _2;
            }
        }

        public Dictionary<Point, bool> n3
        {
            get
            {
                if (_3 == null)
                {
                    _3 = new Dictionary<Point, bool>();


                }
                return _3;
            }
        }

        public Dictionary<Point, bool> n4
        {
            get
            {
                if (_4 == null)
                {
                    _4 = new Dictionary<Point, bool>();


                }
                return _4;
            }
        }

        public Dictionary<Point, bool> n5
        {
            get
            {
                if (_5 == null)
                {
                    _5 = new Dictionary<Point, bool>();


                }
                return _5;
            }
        }

        public Dictionary<Point, bool> n6
        {
            get
            {
                if (_6 == null)
                {
                    _6 = new Dictionary<Point, bool>();


                }
                return _6;
            }
        }

        public Dictionary<Point, bool> n7
        {
            get
            {
                if (_7 == null)
                {
                    _7 = new Dictionary<Point, bool>();


                }
                return _7;
            }
        }

        public Dictionary<Point, bool> n8
        {
            get
            {
                if (_8 == null)
                {
                    _8 = new Dictionary<Point, bool>();


                }
                return _8;
            }
        }

        public Dictionary<Point, bool> n9
        {
            get
            {
                if (_9 == null)
                {
                    _9 = new Dictionary<Point, bool>();


                }
                return _9;
            }
        }

        public Dictionary<Point, bool> n0
        {
            get
            {
                if (_0 == null)
                {
                    _0 = new Dictionary<Point, bool>();


                }
                return _0;
            }
        }
    }
}
