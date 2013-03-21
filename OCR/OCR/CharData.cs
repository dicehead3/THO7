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

        public Dictionary<Point, bool> A{
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

                    _d.Add(new Point(8, 9), true);
                    _d.Add(new Point(22, 8), true);
                    _d.Add(new Point(45, 8), true);
                    _d.Add(new Point(65, 13), true);
                    _d.Add(new Point(10, 28), true);
                    _d.Add(new Point(9, 51), true);
                    _d.Add(new Point(10, 71), true);
                    _d.Add(new Point(8, 92), true);
                    _d.Add(new Point(52, 115), true);
                    _d.Add(new Point(31, 117), true);
                    _d.Add(new Point(11, 117), true);

                    _d.Add(new Point(97, 8), false);
                    _d.Add(new Point(22, 22), false);
                    _d.Add(new Point(44, 25), false);
                    _d.Add(new Point(87, 58), false);
                    _d.Add(new Point(63, 64), false);
                    _d.Add(new Point(42, 100), false);
                    _d.Add(new Point(22, 102), false);
                    _d.Add(new Point(97, 111), false);
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

                    _e.Add(new Point(9, 6), true);
                    _e.Add(new Point(39, 6), true);
                    _e.Add(new Point(65, 6), true);
                    _e.Add(new Point(8, 31), true);
                    _e.Add(new Point(8, 55), true);
                    _e.Add(new Point(31, 55), true);
                    _e.Add(new Point(52, 55), true);
                    _e.Add(new Point(11, 43), true);
                    _e.Add(new Point(11, 114), true);
                    _e.Add(new Point(26, 116), true);
                    _e.Add(new Point(43, 117), true);
                    _e.Add(new Point(66, 115), true);

                    _e.Add(new Point(27, 28), false);
                    _e.Add(new Point(63, 25), false);
                    _e.Add(new Point(61, 39), false);
                    _e.Add(new Point(28, 38), false);
                    _e.Add(new Point(23, 68), false);
                    _e.Add(new Point(62, 68), false);
                    _e.Add(new Point(24, 100), false);
                    _e.Add(new Point(66, 100), false);
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

                    _f.Add(new Point(1, 0), true);
                    _f.Add(new Point(69, 0), true);
                    _f.Add(new Point(15, 14), true);
                    _f.Add(new Point(69, 14), true);
                    _f.Add(new Point(15, 50), true);
                    _f.Add(new Point(15, 64), true);
                    _f.Add(new Point(1, 123), true);
                    _f.Add(new Point(15, 123), true);
                    _f.Add(new Point(48, 62), true);
                    _f.Add(new Point(48, 64), true);
                    _f.Add(new Point(59, 64), true);

                    _f.Add(new Point(71, 15), false);
                    _f.Add(new Point(20, 22), false);
                    _f.Add(new Point(20, 49), false);
                    _f.Add(new Point(72, 64), false);
                    _f.Add(new Point(61, 65), false);
                    _f.Add(new Point(60, 81), false);
                    _f.Add(new Point(22, 82), false);
                    _f.Add(new Point(20, 123), false);
                    _f.Add(new Point(51, 123), false);
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

                    _g.Add(new Point(66, 6), true);
                    _g.Add(new Point(49, 5), true);
                    _g.Add(new Point(14, 27), true);
                    _g.Add(new Point(4, 59), true);
                    _g.Add(new Point(8, 85), true);
                    _g.Add(new Point(29, 117), true);
                    _g.Add(new Point(48, 121), true);
                    _g.Add(new Point(80, 79), true);
                    _g.Add(new Point(80, 70), true);
                    _g.Add(new Point(65, 69), true);
                    _g.Add(new Point(65, 79), true);

                    _g.Add(new Point(8, 15), false);
                    _g.Add(new Point(76, 19), false);
                    _g.Add(new Point(47, 62), false);
                    _g.Add(new Point(97, 62), false);
                    _g.Add(new Point(89, 82), false);
                    _g.Add(new Point(89, 109), false);
                    _g.Add(new Point(60, 88), false);
                    _g.Add(new Point(61, 98), false);
                    _g.Add(new Point(15, 117), false);
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

                    _h.Add(new Point(2, 0), true);
                    _h.Add(new Point(16, 0), true);
                    _h.Add(new Point(80, 0), true);
                    _h.Add(new Point(16, 49), true);
                    _h.Add(new Point(16, 63), true);
                    _h.Add(new Point(2, 123), true);
                    _h.Add(new Point(16, 123), true);
                    _h.Add(new Point(80, 123), true);
                    _h.Add(new Point(29, 63), true);
                    _h.Add(new Point(43, 53), true);
                    _h.Add(new Point(55, 63), true);
                    _h.Add(new Point(61, 52), true);
                    _h.Add(new Point(79, 49), true);
                    _h.Add(new Point(79, 63), true);

                    _h.Add(new Point(43, 2), false);
                    _h.Add(new Point(20, 48), false);
                    _h.Add(new Point(62, 48), false);
                    _h.Add(new Point(20, 74), false);
                    _h.Add(new Point(62, 74), false);
                    _h.Add(new Point(42, 120), false);
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

                    _i.Add(new Point(2, 0), true);
                    _i.Add(new Point(48, 0), true);
                    _i.Add(new Point(2, 12), true);
                    _i.Add(new Point(48, 12), true);
                    _i.Add(new Point(18, 13), true);
                    _i.Add(new Point(32, 13), true);
                    _i.Add(new Point(18, 110), true);
                    _i.Add(new Point(32, 110), true);
                    _i.Add(new Point(2, 111), true);
                    _i.Add(new Point(2, 123), true);
                    _i.Add(new Point(48, 111), true);
                    _i.Add(new Point(48, 123), true);

                    _i.Add(new Point(16, 13), false);
                    _i.Add(new Point(35, 13), false);
                    _i.Add(new Point(16, 110), false);
                    _i.Add(new Point(35, 110), false);
                    _i.Add(new Point(8, 35), false);
                    _i.Add(new Point(9, 74), false);
                    _i.Add(new Point(43, 35), false);
                    _i.Add(new Point(43, 81), false);
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

                    _j.Add(new Point(44, 0), true);
                    _j.Add(new Point(58, 0), true);
                    _j.Add(new Point(44, 15), true);
                    _j.Add(new Point(58, 15), true);
                    _j.Add(new Point(44, 62), true);
                    _j.Add(new Point(58, 62), true);
                    _j.Add(new Point(44, 91), true);
                    _j.Add(new Point(58, 91), true);
                    _j.Add(new Point(45, 107), true);
                    _j.Add(new Point(34, 116), true);
                    _j.Add(new Point(18, 122), true);
                    _j.Add(new Point(4, 116), true);

                    _j.Add(new Point(48, 123), false);
                    _j.Add(new Point(58, 112), false);
                    _j.Add(new Point(9, 95), false);
                    _j.Add(new Point(25, 101), false);
                    _j.Add(new Point(38, 87), false);
                    _j.Add(new Point(40, 66), false);
                    _j.Add(new Point(41, 14), false);
                    _j.Add(new Point(29, 14), false);
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

                    _k.Add(new Point(3, 0), true);
                    _k.Add(new Point(15, 1), true);
                    _k.Add(new Point(10, 29), true);
                    _k.Add(new Point(11, 83), true);
                    _k.Add(new Point(4, 123), true);
                    _k.Add(new Point(15, 122), true);
                    _k.Add(new Point(28, 57), true);
                    _k.Add(new Point(46, 38), true);
                    _k.Add(new Point(59, 21), true);
                    _k.Add(new Point(46, 82), true);
                    _k.Add(new Point(60, 98), true);
                    _k.Add(new Point(76, 117), true);

                    _k.Add(new Point(26, 6), false);
                    _k.Add(new Point(27, 39), false);
                    _k.Add(new Point(23, 78), false);
                    _k.Add(new Point(37, 119), false);
                    _k.Add(new Point(48, 59), false);
                    _k.Add(new Point(94, 10), false);
                    _k.Add(new Point(85, 58), false);
                    _k.Add(new Point(97, 116), false);
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

                    _l.Add(new Point(3, 3), true);
                    _l.Add(new Point(13, 3), true);
                    _l.Add(new Point(4, 27), true);
                    _l.Add(new Point(12, 27), true);
                    _l.Add(new Point(5, 69), true);
                    _l.Add(new Point(12, 69), true);
                    _l.Add(new Point(11, 111), true);
                    _l.Add(new Point(6, 118), true);
                    _l.Add(new Point(33, 111), true);
                    _l.Add(new Point(35, 121), true);
                    _l.Add(new Point(61, 111), true);
                    _l.Add(new Point(61, 121), true);

                    _l.Add(new Point(26, 5), false);
                    _l.Add(new Point(55, 4), false);
                    _l.Add(new Point(31, 42), false);
                    _l.Add(new Point(64, 42), false);
                    _l.Add(new Point(32, 55), false);
                    _l.Add(new Point(34, 68), false);
                    _l.Add(new Point(62, 58), false);
                    _l.Add(new Point(64, 68), false);
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

                    _m.Add(new Point(5, 3), true);
                    _m.Add(new Point(4, 118), true);
                    _m.Add(new Point(14, 119), true);
                    _m.Add(new Point(17, 3), true);
                    _m.Add(new Point(36, 51), true);
                    _m.Add(new Point(47, 74), true);
                    _m.Add(new Point(61, 75), true);
                    _m.Add(new Point(74, 48), true);
                    _m.Add(new Point(89, 2), true);
                    _m.Add(new Point(99, 2), true);
                    _m.Add(new Point(99, 118), true);
                    _m.Add(new Point(92, 119), true);

                    _m.Add(new Point(32, 4), false);
                    _m.Add(new Point(72, 5), false);
                    _m.Add(new Point(54, 37), false);
                    _m.Add(new Point(25, 64), false);
                    _m.Add(new Point(81, 64), false);
                    _m.Add(new Point(53, 113), false);
                    _m.Add(new Point(27, 120), false);
                    _m.Add(new Point(80, 120), false);
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

                    _n.Add(new Point(3, 3), true);
                    _n.Add(new Point(17, 3), true);
                    _n.Add(new Point(80, 3), true);
                    _n.Add(new Point(80, 27), true);
                    _n.Add(new Point(80, 67), true);
                    _n.Add(new Point(80, 115), true);
                    _n.Add(new Point(68, 102), true);
                    _n.Add(new Point(57, 81), true);
                    _n.Add(new Point(42, 53), true);
                    _n.Add(new Point(26, 21), true);
                    _n.Add(new Point(13, 12), true);
                    _n.Add(new Point(6, 28), true);
                    _n.Add(new Point(5, 65), true);
                    _n.Add(new Point(5, 101), true);
                    _n.Add(new Point(5, 117), true);
                    _n.Add(new Point(11, 117), true);

                    _n.Add(new Point(31, 4), false);
                    _n.Add(new Point(60, 3), false);
                    _n.Add(new Point(62, 63), false);
                    _n.Add(new Point(22, 50), false);
                    _n.Add(new Point(22, 121), false);
                    _n.Add(new Point(56, 121), false);
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

                    _u.Add(new Point(9, 3), true);
                    _u.Add(new Point(10, 26), true);
                    _u.Add(new Point(7, 59), true);
                    _u.Add(new Point(7, 86), true);
                    _u.Add(new Point(13, 100), true);
                    _u.Add(new Point(40, 114), true);
                    _u.Add(new Point(56, 119), true);
                    _u.Add(new Point(74, 113), true);
                    _u.Add(new Point(92, 100), true);
                    _u.Add(new Point(96, 84), true);
                    _u.Add(new Point(98, 65), true);
                    _u.Add(new Point(98, 26), true);
                    _u.Add(new Point(99, 2), true);

                    _u.Add(new Point(33, 8), false);
                    _u.Add(new Point(76, 5), false);
                    _u.Add(new Point(33, 83), false);
                    _u.Add(new Point(76, 83), false);
                    _u.Add(new Point(54, 101), false);
                    _u.Add(new Point(8, 118), false);
                    _u.Add(new Point(98, 118), false);
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

                    _v.Add(new Point(11, 6), true);
                    _v.Add(new Point(99, 4), true);
                    _v.Add(new Point(18, 26), true);
                    _v.Add(new Point(89, 31), true);
                    _v.Add(new Point(26, 52), true);
                    _v.Add(new Point(81, 51), true);
                    _v.Add(new Point(38, 85), true);
                    _v.Add(new Point(70, 81), true);
                    _v.Add(new Point(43, 170), true);
                    _v.Add(new Point(63, 106), true);
                    _v.Add(new Point(54, 119), true);

                    _v.Add(new Point(71, 120), false);
                    _v.Add(new Point(102, 120), false);
                    _v.Add(new Point(103, 23), false);
                    _v.Add(new Point(36, 119), false);
                    _v.Add(new Point(2, 120), false);
                    _v.Add(new Point(3, 25), false);
                    _v.Add(new Point(54, 77), false);
                    _v.Add(new Point(76, 3), false);
                    _v.Add(new Point(34, 3), false);
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

                    _w.Add(new Point(7, 4), true);
                    _w.Add(new Point(21, 58), true);
                    _w.Add(new Point(32, 116), true);
                    _w.Add(new Point(42, 59), true);
                    _w.Add(new Point(54, 7), true);
                    _w.Add(new Point(64, 58), true);
                    _w.Add(new Point(71, 116), true);
                    _w.Add(new Point(91, 49), true);
                    _w.Add(new Point(97, 3), true);

                    _w.Add(new Point(33, 3), false);
                    _w.Add(new Point(34, 47), false);
                    _w.Add(new Point(73, 5), false);
                    _w.Add(new Point(71, 47), false);
                    _w.Add(new Point(103, 46), false);
                    _w.Add(new Point(89, 120), false);
                    _w.Add(new Point(58, 120), false);
                    _w.Add(new Point(51, 120), false);
                    _w.Add(new Point(53, 84), false);
                    _w.Add(new Point(17, 118), false);
                    _w.Add(new Point(3, 47), false);
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

                    _x.Add(new Point(16, 6), true);
                    _x.Add(new Point(93, 6), true);
                    _x.Add(new Point(44, 51), true);
                    _x.Add(new Point(62, 51), true);
                    _x.Add(new Point(45, 71), true);
                    _x.Add(new Point(62, 71), true);
                    _x.Add(new Point(14, 118), true);
                    _x.Add(new Point(95, 120), true);

                    _x.Add(new Point(34, 3), false);
                    _x.Add(new Point(74, 3), false);
                    _x.Add(new Point(54, 33), false);
                    _x.Add(new Point(3, 12), false);
                    _x.Add(new Point(33, 59), false);
                    _x.Add(new Point(4, 108), false);
                    _x.Add(new Point(103, 11), false);
                    _x.Add(new Point(72, 59), false);
                    _x.Add(new Point(105, 109), false);
                    _x.Add(new Point(55, 86), false);
                    _x.Add(new Point(31, 120), false);
                    _x.Add(new Point(74, 120), false);
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

                    _y.Add(new Point(13, 3), true);
                    _y.Add(new Point(94, 5), true);
                    _y.Add(new Point(26, 27), true);
                    _y.Add(new Point(77, 31), true);
                    _y.Add(new Point(43, 53), true);
                    _y.Add(new Point(60, 57), true);
                    _y.Add(new Point(48, 63), true);
                    _y.Add(new Point(56, 64), true);
                    _y.Add(new Point(52, 76), true);
                    _y.Add(new Point(53, 95), true);
                    _y.Add(new Point(51, 118), true);

                    _y.Add(new Point(71, 120), false);
                    _y.Add(new Point(73, 71), false);
                    _y.Add(new Point(103, 23), false);
                    _y.Add(new Point(36, 119), false);
                    _y.Add(new Point(36, 72), false);
                    _y.Add(new Point(3, 18), false);
                    _y.Add(new Point(54, 43), false);
                    _y.Add(new Point(76, 3), false);
                    _y.Add(new Point(34, 3), false);
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

                    _z.Add(new Point(11, 10), true);
                    _z.Add(new Point(29, 10), true);
                    _z.Add(new Point(53, 10), true);
                    _z.Add(new Point(76, 10), true);
                    _z.Add(new Point(102, 3), true);
                    _z.Add(new Point(80, 31), true);
                    _z.Add(new Point(61, 51), true);
                    _z.Add(new Point(41, 70), true);
                    _z.Add(new Point(14, 101), true);
                    _z.Add(new Point(5, 121), true);
                    _z.Add(new Point(29, 121), true);
                    _z.Add(new Point(55, 120), true);
                    _z.Add(new Point(80, 120), true);
                    _z.Add(new Point(97, 120), true);

                    _z.Add(new Point(8, 25), false);
                    _z.Add(new Point(66, 25), false);
                    _z.Add(new Point(102, 31), false);
                    _z.Add(new Point(4, 92), false);
                    _z.Add(new Point(39, 101), false);
                    _z.Add(new Point(101, 101), false);
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

                    _1.Add(new Point(2, 20), true);
                    _1.Add(new Point(36, 17), true);
                    _1.Add(new Point(52, 16), true);
                    _1.Add(new Point(61, 5), true);
                    _1.Add(new Point(56, 29), true);
                    _1.Add(new Point(55, 46), true);
                    _1.Add(new Point(55, 62), true);
                    _1.Add(new Point(54, 88), true);
                    _1.Add(new Point(53, 110), true);
                    _1.Add(new Point(63, 119), true);
                    _1.Add(new Point(85, 119), true);
                    _1.Add(new Point(98, 121), true);

                    _1.Add(new Point(5 ,2), false);
                    _1.Add(new Point(21, 2), false);
                    _1.Add(new Point(3, 32), false);
                    _1.Add(new Point(4, 62), false);
                    _1.Add(new Point(2, 107), false);
                    _1.Add(new Point(37, 32), false);
                    _1.Add(new Point(35, 62), false);
                    _1.Add(new Point(34, 105), false);
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

                    _2.Add(new Point(10, 14), true);
                    _2.Add(new Point(30, 7), true);
                    _2.Add(new Point(46, 7), true);
                    _2.Add(new Point(73, 11), true);
                    _2.Add(new Point(87, 26), true);
                    _2.Add(new Point(83, 53), true);
                    _2.Add(new Point(62, 70), true);
                    _2.Add(new Point(43, 48), true);
                    _2.Add(new Point(21, 102), true);
                    _2.Add(new Point(13, 118), true);
                    _2.Add(new Point(55, 118), true);
                    _2.Add(new Point(95, 118), true);

                    _2.Add(new Point(2, 3), false);
                    _2.Add(new Point(6, 39), false);
                    _2.Add(new Point(47, 35), false);
                    _2.Add(new Point(5, 94), false);
                    _2.Add(new Point(98, 5), false);
                    _2.Add(new Point(99, 58), false);
                    _2.Add(new Point(50, 100), false);
                    _2.Add(new Point(100, 100), false);
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

                    _3.Add(new Point(15, 13), true);
                    _3.Add(new Point(40, 6), true);
                    _3.Add(new Point(75, 10), true);
                    _3.Add(new Point(90, 29), true);
                    _3.Add(new Point(80, 48), true);
                    _3.Add(new Point(54, 56), true);
                    _3.Add(new Point(80, 65), true);
                    _3.Add(new Point(95, 82), true);
                    _3.Add(new Point(89, 104), true);
                    _3.Add(new Point(70, 115), true);
                    _3.Add(new Point(44, 118), true);
                    _3.Add(new Point(19, 114), true);

                    _3.Add(new Point(2, 6), false);
                    _3.Add(new Point(98, 4), false);
                    _3.Add(new Point(52, 33), false);
                    _3.Add(new Point(28, 57), false);
                    _3.Add(new Point(97, 57), false);
                    _3.Add(new Point(64, 84), false);
                    _3.Add(new Point(1, 122), false);
                    _3.Add(new Point(97, 117), false);
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

                    _4.Add(new Point(75, 4), true);
                    _4.Add(new Point(56, 22), true);
                    _4.Add(new Point(27, 53), true);
                    _4.Add(new Point(11, 83), true);
                    _4.Add(new Point(27, 82), true);
                    _4.Add(new Point(54, 84), true);
                    _4.Add(new Point(75, 31), true);
                    _4.Add(new Point(75, 54), true);
                    _4.Add(new Point(75, 80), true);
                    _4.Add(new Point(75, 101), true);
                    _4.Add(new Point(75, 118), true);
                    _4.Add(new Point(97, 83), true);

                    _4.Add(new Point(41, 3), false);
                    _4.Add(new Point(6, 47), false);
                    _4.Add(new Point(50, 59), false);
                    _4.Add(new Point(99, 16), false);
                    _4.Add(new Point(97, 50), false);
                    _4.Add(new Point(97, 110), false);
                    _4.Add(new Point(52, 108), false);
                    _4.Add(new Point(13, 109), false);
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

                    _5.Add(new Point(17, 8), true);
                    _5.Add(new Point(37, 8), true);
                    _5.Add(new Point(88, 8), true);
                    _5.Add(new Point(17, 54), true);
                    _5.Add(new Point(42, 54), true);
                    _5.Add(new Point(70, 58), true);
                    _5.Add(new Point(87, 67), true);
                    _5.Add(new Point(90, 83), true);
                    _5.Add(new Point(87, 99), true);
                    _5.Add(new Point(66, 114), true);
                    _5.Add(new Point(36, 116), true);
                    _5.Add(new Point(13, 110), true);

                    _5.Add(new Point(3, 20), false);
                    _5.Add(new Point(3, 80), false);
                    _5.Add(new Point(3, 120), false);
                    _5.Add(new Point(71, 81), false);
                    _5.Add(new Point(98, 21), false);
                    _5.Add(new Point(45, 33), false);
                    _5.Add(new Point(102, 59), false);
                    _5.Add(new Point(97, 118), false);
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

                    _6.Add(new Point(66, 8), true);
                    _6.Add(new Point(49, 15), true);
                    _6.Add(new Point(23, 31), true);
                    _6.Add(new Point(15, 56), true);
                    _6.Add(new Point(37, 57), true);
                    _6.Add(new Point(65, 56), true);
                    _6.Add(new Point(90, 68), true);
                    _6.Add(new Point(91, 91), true);
                    _6.Add(new Point(78, 110), true);
                    _6.Add(new Point(47, 115), true);
                    _6.Add(new Point(28, 107), true);
                    _6.Add(new Point(16, 84), true);

                    _6.Add(new Point(10, 10), false);
                    _6.Add(new Point(102, 10), false);
                    _6.Add(new Point(72, 19), false);
                    _6.Add(new Point(56, 37), false);
                    _6.Add(new Point(98, 50), false);
                    _6.Add(new Point(52, 81), false);
                    _6.Add(new Point(6, 118), false);
                    _6.Add(new Point(100, 118), false);
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

                    _7.Add(new Point(5, 2), true);
                    _7.Add(new Point(5, 11), true);
                    _7.Add(new Point(34, 2), true);
                    _7.Add(new Point(34, 11), true);
                    _7.Add(new Point(73, 2), true);
                    _7.Add(new Point(73, 11), true);
                    _7.Add(new Point(102, 2), true);
                    _7.Add(new Point(98, 15), true);
                    _7.Add(new Point(79, 42), true);
                    _7.Add(new Point(58, 72), true);
                    _7.Add(new Point(42, 95), true);
                    _7.Add(new Point(26, 116), true);

                    _7.Add(new Point(5, 24), false);
                    _7.Add(new Point(66, 23), false);
                    _7.Add(new Point(5, 68), false);
                    _7.Add(new Point(38, 68), false);
                    _7.Add(new Point(9, 116), false);
                    _7.Add(new Point(50, 115), false);
                    _7.Add(new Point(101, 115), false);
                    _7.Add(new Point(101, 32), false);
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

                    _8.Add(new Point(38, 7), true);
                    _8.Add(new Point(68, 6), true);
                    _8.Add(new Point(15, 30), true);
                    _8.Add(new Point(93, 31), true);
                    _8.Add(new Point(37, 53), true);
                    _8.Add(new Point(68, 64), true);
                    _8.Add(new Point(14, 88), true);
                    _8.Add(new Point(92, 87), true);
                    _8.Add(new Point(387, 115), true);
                    _8.Add(new Point(65, 116), true);

                    _8.Add(new Point(5, 6), false);
                    _8.Add(new Point(99, 5), false);
                    _8.Add(new Point(53, 32), false);
                    _8.Add(new Point(98, 58), false);
                    _8.Add(new Point(50, 87), false);
                    _8.Add(new Point(8, 118), false);
                    _8.Add(new Point(99, 116), false);
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

                    _9.Add(new Point(50, 10), true);
                    _9.Add(new Point(20, 22), true);
                    _9.Add(new Point(12, 41), true);
                    _9.Add(new Point(22, 59), true);
                    _9.Add(new Point(35, 68), true);
                    _9.Add(new Point(65, 70), true);
                    _9.Add(new Point(84, 65), true);
                    _9.Add(new Point(76, 15), true);
                    _9.Add(new Point(88, 35), true);
                    _9.Add(new Point(86, 78), true);
                    _9.Add(new Point(67, 106), true);
                    _9.Add(new Point(42, 115), true);

                    _9.Add(new Point(8, 6), false);
                    _9.Add(new Point(99, 6), false);
                    _9.Add(new Point(28, 37), false);
                    _9.Add(new Point(77, 39), false);
                    _9.Add(new Point(5, 72), false);
                    _9.Add(new Point(58, 85), false);
                    _9.Add(new Point(34, 107), false);
                    _9.Add(new Point(96, 116), false);
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

                    _0.Add(new Point(54, 6), true);
                    _0.Add(new Point(27, 15), true);
                    _0.Add(new Point(77, 12), true);
                    _0.Add(new Point(13, 37), true);
                    _0.Add(new Point(93, 37), true);
                    _0.Add(new Point(98, 62), true);
                    _0.Add(new Point(10, 60), true);
                    _0.Add(new Point(12, 92), true);
                    _0.Add(new Point(33, 113), true);
                    _0.Add(new Point(55, 118), true);
                    _0.Add(new Point(75, 112), true);
                    _0.Add(new Point(96, 91), true);

                    _0.Add(new Point(6, 7), false);
                    _0.Add(new Point(98, 5), false);
                    _0.Add(new Point(56, 28), false);
                    _0.Add(new Point(28, 59), false);
                    _0.Add(new Point(78, 59), false);
                    _0.Add(new Point(53, 91), false);
                    _0.Add(new Point(8, 116), false);
                    _0.Add(new Point(102, 114), false);
                }
                return _0;
            }
        }
    }
}
