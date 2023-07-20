using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEx
{
    internal class Program
    {
        static void Main()
        {

            //B b = new B();
            //object obj = b.Number("Hello");
            //object o = b.Number(10);
            //object o1 = b.Number(10.876f);// Reusablity is happen but here we gave int as parameter input 
            //Console.WriteLine(o);           //  so if we can't give return type as int here.After unboxing
            //Console.WriteLine(o1);          // we can give int like int a = (int)b.Number(10);
            //Console.WriteLine(obj);
            //A<int> a = new A<int>();
            //int r = a.M1(10);
            //A<string> a1 = new A<string>();
            //string b = a1.M1("Hello");
            //Console.WriteLine(r);
            //Console.WriteLine(b);
            //A<int> a = new A<int>();
            //int add = a.Add(20, 30);
            //A<string> a2 = new A<string>();
            //string con = a2.Add("Hi", "Hello");
            //A<bool> a3 = new A<bool>();
            //bool a4 = a3.Add(true, false);
            //A<float> a5 = new A<float>();
            //float a6 = a5.Add(20.5f, 45.67f);
            //Console.WriteLine(a6);
            //Console.WriteLine(a4);
            //Console.WriteLine(con);
            //Console.WriteLine(add);
            //A a = new A();
            //a.M<int, string>(90, "Hello");
            //A<string, int> a = new A<string, int>();
            //a.M1<int, float>(90, 89.90f);
            //int x = 80;
            //int y = 100;
            //A a = new A();
            //a.Swap<int>(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //A.M1<string>("Hello");
            //A a = new A();
            //a.M1();
            //Console.WriteLine(A.x);
            //B b = new B();
            //string r = b.M1("10", 100);
            //int s = b.M2(99, "09 ");
            //Console.WriteLine(s);
            //Console.WriteLine(r);
            A<float> a = new A<float>();
            B<string> a1 = new B<string>();
            C<string, int> c = new C<string, int>();
            D<E> d = new D<E>();
            F<G> f = new F<G>();
            H<J, I> h = new H<J, I>();
            C<B> c1 = new C<B>();
            //V v = new V();

            //int r = v.M();
            //Console.WriteLine(r);
            Console.ReadLine();
        }
    }
    //public struct V
    //{
    //    public int x;
    //    public int y;
    //    public int M()
    //    {
    //        return x + y;
    //    }
    //public V(int x)
    //{
    //    this.x = x;
    //}
//}
public class A<T> where T : struct
{

}
public class B<T> where T : class
{

}
public class C<T, U> where T : class where U : struct
{

}
    public class D<T> where T : new()
    {
        public D()
        {

        }
    }
public class E
{
    public E()
    {

    }
}
public class F<Z> where Z : class,new()
{
    public F()
    {

    }
}
public class G: F<G>
{
    public G()
    {

    }
}
public class H<V,U> where V : U
{

}
public class I
{

}
public class J: I
{

}
public class K:L<K>
{

}
public class L<W> where W: class, new()
{

}
public interface I1
{

}
public class B : I1
{

}
public class C<X> where X: I1
{

}
    //public interface I<T, U>
    //{
    //    T M1(T t, U u);
    //    U M2(U u1,  T u2);
    //}
    //public class B : I<string, int>
    //{
    //    public string M1(string t, int u)
    //    {
    //        return t + u;
    //    }
    //    public int M2(int s1, string s2)
    //    {
    //        return s1 + Convert.ToInt32(s2);
    //    }
    //}
    //public class A
    //{
    //    public static int x= 10;
    //    static A()
    //    {
    //        x = x + 10;
    //        Console.WriteLine(x);
    //    }
    //    public void M1()
    //    {
    //        x++;
    //    }
        //public void Swap<T>(ref T t1,  ref T t2)
        //{
        //    T temp;
        //    temp = t1;
        //    t1 = t2;
        //    t2 = temp;
        //}
        //public static void M1<T>(T t)
        //{
        //    Console.WriteLine(t);
        //}
    //}
    //public class A<T, U>
    //{
    //    public void M1<X,Y>(X x, Y y)
    //    {
    //        Console.WriteLine(x);
    //        Console.WriteLine(y);
    //    }
    //}
    //public class A
    //{
    //    public void M<T,U>(T t, U u)
    //    {
           
    //        if(t is int && u is string)
    //        {
    //            int i = Convert.ToInt32(t);
    //            string s = Convert.ToString(u);
    //            Console.WriteLine(s);
    //            Console.WriteLine(i);
    //        }
    //    }
    //}
    //public class A<T>
    //{
    //    public T Add(T t1, T t2)
    //    {
    //        T t = default(T);
    //        if (t1 is int)
    //        {
    //            int i = Convert.ToInt32(t1);
    //            int i1 = Convert.ToInt32(t2);
    //            int i3 = i + i1;
    //            T t3 = (T)Convert.ChangeType(i3, typeof(T));
    //            return t3;
    //        }
    //        else if (t1 is string)
    //        {
    //            string s1 = Convert.ToString(t1);
    //            string s2 = Convert.ToString(t2);
    //            string s3 = s1 + s2;
    //            T t3 = (T)Convert.ChangeType(s3, typeof(T));
    //            return t3;
    //        }
    //        return t;
    //    }
    //}
    //public class A<T>
    //{
    //    public T M1(T t)
    //    {
    //        return t;
    //    }
    //}
    //public class B
    //{
    //    public object Number(object obj)
    //    {
    //        return obj;
    //    }
    //}
}
