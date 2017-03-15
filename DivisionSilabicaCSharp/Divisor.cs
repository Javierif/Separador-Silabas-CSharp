using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivisionSilabica_CSharp
{
    class Divisor
    {

        private String cadena;

        public Divisor(String x)
        {
            this.cadena = x;
        }

        public Divisor()
        {
            this.cadena = "";
        }

        public Divisor(int[] ascii)
        {
            char c;
            int i;
            this.cadena = "";
            for (i = 0; (i < ascii.Length); i++)
            {
                c = ((char)(ascii[i]));
                this.cadena = (this.cadena + c);
            }

        }

        public Divisor(char[] c)
        {
            int i;
            this.cadena = "";
            for (i = 0; (i < c.Length); i++)
            {
                this.cadena = (this.cadena + c);
            }

        }

        public String getString()
        {
            return this.cadena;
        }

        public void setString(String newCadena)
        {
            this.cadena = newCadena;
        }

        private static int letra(char c)
        {
            int i = -1;
            int ascii;
            ascii = ((int)(c));
            if ((ascii != -1))
            {
                switch (ascii)
                {
                    case 97:
                        // a
                        i = 1;
                        break;
                    case 101:
                        // e
                        i = 2;
                        break;
                    case 104:
                        // h
                        i = 6;
                        break;
                    case 105:
                        // i
                        i = 4;
                        break;
                    case 111:
                        // o
                        i = 3;
                        break;
                    case 117:
                        // u
                        i = 5;
                        break;
                    case 225:
                        // �
                        i = 1;
                        break;
                    case 233:
                        // �
                        i = 2;
                        break;
                    case 237:
                        // �
                        i = 4;
                        break;
                    case 243:
                        // �
                        i = 3;
                        break;
                    case 250:
                        // �
                        i = 5;
                        break;
                    case 252:
                        // �
                        i = 5;
                        break;
                    default:
                        i = 19;
                        break;
                }
            }

            return i;
        }

        private static String silaba(String str)
        {
            String temp = "";
            String s = "";
            char z;
            char x;
            char y;
            if ((str.Length < 3))
            {
                if ((str.Length == 2))
                {
                    x = str[0];
                    y = str[1];
                    if (((Divisor.letra(x) < 6)
                                && (Divisor.letra(y) < 6)))
                    {
                        if (Divisor.hiato(x, y))
                        {
                            s = str.Substring(0, 1);
                        }
                        else
                        {
                            s = str;
                        }

                    }
                    else
                    {
                        s = str;
                    }

                }
                else
                {
                    s = str;
                }

            }
            else
            {
                x = str[0];
                y = str[1];
                z = str[2];
                if ((Divisor.letra(x) < 6))
                {
                    // V ? ?
                    if ((Divisor.letra(y) < 6))
                    {
                        // V V ?
                        if ((Divisor.letra(z) < 6))
                        {
                            // V V V
                            if (Divisor.hiato(x, y))
                            {
                                s = str.Substring(0, 1);
                            }
                            else if (Divisor.hiato(y, z))
                            {
                                s = str.Substring(0, 2);
                            }
                            else
                            {
                                s = str.Substring(0, 3);
                            }

                        }
                        else
                        {
                            //  V V C
                            if (Divisor.hiato(x, y))
                            {
                                s = str.Substring(0, 1);
                            }
                            else
                            {
                                s = str.Substring(0, 2);
                            }

                        }

                    }
                    else
                    {
                        //  V C ?
                        if ((Divisor.letra(z) < 6))
                        {
                            // V C V
                            if ((Divisor.letra(y) == 6))
                            {
                                //  V H C
                                if (Divisor.hiato(x, z))
                                {
                                    s = str.Substring(0, 1);
                                }
                                else
                                {
                                    s = str.Substring(0, 3);
                                }

                            }
                            else
                            {
                                s = str.Substring(0, 1);
                            }

                        }
                        else
                        {
                            //  V C C
                            if (Divisor.consonantes1(y, z))
                            {
                                s = str.Substring(0, 1);
                            }
                            else
                            {
                                s = str.Substring(0, 2);
                            }

                        }

                    }

                }
                else
                {
                    //  C ??
                    if ((Divisor.letra(y) < 6))
                    {
                        // C V ?
                        if ((Divisor.letra(z) < 6))
                        {
                            //  C V V
                            temp = str.Substring(0, 3);
                            if ((temp.Equals("que")
                                        || (temp.Equals("qui")
                                        || (temp.Equals("gue") || temp.Equals("gui")))))
                            {
                                s = str.Substring(0, 3);
                            }
                            else if (Divisor.hiato(y, z))
                            {
                                s = str.Substring(0, 2);
                            }
                            else
                            {
                                s = str.Substring(0, 3);
                            }

                        }
                        else
                        {
                            //  C V C
                            s = str.Substring(0, 2);
                        }

                    }
                    else
                    {
                        //  C C ?
                        if ((Divisor.letra(z) < 6))
                        {
                            //  C C V
                            if (Divisor.consonantes1(x, y))
                            {
                                s = str.Substring(0, 3);
                            }
                            else
                            {
                                s = str.Substring(0, 1);
                            }

                        }
                        else
                        {
                            //  C C C
                            if (Divisor.consonantes1(y, z))
                            {
                                s = str.Substring(0, 1);
                            }
                            else
                            {
                                s = str.Substring(0, 1);
                            }

                        }

                    }

                }

            }

            return s;
        }

        private static String silabaRest(String str)
        {
            String s2;
            s2 = Divisor.silaba(str);
            return str.Substring(s2.Length);
        }

        private static bool hiato(char v, char v2)
        {
            bool cer = false;
            if ((Divisor.letra(v) < 4))
            {
                //  VA + ?
                if ((Divisor.letra(v2) < 4))
                {
                    cer = true;
                }
                else
                {
                    // VA+ VC
                    if (((v2 == '�')
                                || (v2 == '�')))
                    {
                        cer = true;
                    }
                    else
                    {
                        cer = false;
                    }

                }

            }
            else
            {
                //  VC + ?
                if ((Divisor.letra(v2) < 4))
                {
                    //  VC + VA
                    if (((v == '�')
                                || (v == '�')))
                    {
                        cer = true;
                    }
                    else
                    {
                        cer = false;
                    }

                }
                else
                {
                    // VC + VC
                    if ((v == v2))
                    {
                        cer = true;
                    }
                    else
                    {
                        cer = false;
                    }

                }

            }

            return cer;
        }

        private static bool consonantes1(char a, char b)
        {
            bool cer;
            cer = false;
            if (((a == 'b')
                        || ((a == 'c')
                        || ((a == 'd')
                        || ((a == 'f')
                        || ((a == 'g')
                        || ((a == 'p')
                        || ((a == 'r')
                        || (a == 't')))))))))
            {
                if ((b == 'r'))
                {
                    cer = true;
                }

            }

            if (((a == 'b')
                        || ((a == 'c')
                        || ((a == 'f')
                        || ((a == 'g')
                        || ((a == 'p')
                        || ((a == 't')
                        || (a == 'l'))))))))
            {
                if ((b == 'l'))
                {
                    cer = true;
                }

            }

            if ((b == 'h'))
            {
                if ((a == 'c'))
                {
                    cer = true;
                }

            }

            return cer;
        }

        private static bool strConsonantes(String str)
        {
            bool cer;
            int k;
            int i;
            char[] c;
            cer = false;
            k = 0;
            c = str.ToCharArray();
            for (i = 0; (i < str.Length); i++)
            {
                if ((Divisor.letra(c[i]) > 5))
                {
                    k = (k + 1);
                }

            }

            if ((k == str.Length))
            {
                cer = true;
            }

            return cer;
        }

        private static bool strVVstr(String s1, String s2)
        {
            bool cer;
            char c2;
            char c1;
            c1 = s1[(s1.Length - 1)];
            c2 = s2[0];
            cer = false;
            if (((Divisor.letra(c1) < 6)
                        && (Divisor.letra(c2) < 6)))
            {
                if (Divisor.hiato(c1, c2))
                {
                    cer = false;
                }
                else
                {
                    cer = true;
                }

            }

            return cer;
        }

        public String silabear()
        {
            String temp;
            String s = "";
            int k;
            int i;
            k = this.cadena.Length;
            temp = this.cadena;
            for (i = 0; (i < k); i++)
            {
                temp = Divisor.silaba(this.cadena);
                if ((i == 0))
                {
                    s = (s + temp);
                }
                else if (Divisor.strConsonantes(temp))
                {
                    s = (s + temp);
                }
                else if (Divisor.strVVstr(s, temp))
                {
                    s = (s + temp);
                }
                else if (Divisor.strConsonantes(s))
                {
                    s = (s + temp);
                }
                else
                {
                    s = (s + ("-" + temp));
                }

                i = (i
                            + (temp.Length - 1));
                this.cadena = Divisor.silabaRest(this.cadena);
            }

            return s;
        }
    }
}
