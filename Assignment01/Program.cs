using System.Numerics;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            /*
            Generic class uses one or more type parameters that
            are replaced with actual types when an object is created 
            use it to provide type safty,no boxing and unboxing 
            Better performance ,reduce duplicate code
             */
            #endregion
            #region Question02
            /*
                 internal class Container<T>
                {
                   public T Value { get; set; }
                   public void Add(T V)
                   {
                       Value = V;
                   }
                   public T Get() => Value;
                }  
            */
            #endregion
            #region Question03
            /*      
                .A multiple types parameter when it needs to  use more than one data type.
                .internal class Pair<TKey,TValue>
                .{
                .    public TKey Key { get; set; }
                .    public TValue Value { get; set; }
                .    public Pair(TKey key, TValue value)
                .    {
                .        Key = key;
                .        Value = value;
                .    }
                .    public void Print()
                .    {
                .        Console.WriteLine($"Key is : {Key},Value is : {Value}");
                .    }
                .}
            */
            #endregion
            #region Question04
            /*
                A generic method allows the same method to work with different data types.
                  internal static class Utility
                 {
                      public static void Swap<T>(ref T x, ref T y)
                      {
                          T temp = x;
                          x = y;
                          y = temp;
                      }
                  }
             */
            #endregion
            #region Question05
            /*
                   internal static class Utility
              {
                   public static T FindMax<T>(T[] arr) where T : INumber<T>
                   {
                       T max = arr[0];
                       for (int i = 1;i<arr.Length;i++)
                       {
                           if (arr[i] > max)
                           {
                               max = arr[i];
                           }
                       }
                     return max;
                   }
               }  
            */
            #endregion
            #region Question06
            /*   A generic interface is a contract using one or more type parameters,
                  Generic interfaces commonly used to create reusable code , that provide type safe and work with 
                  different data types .
                  public interface IRepository<T,TKey>
                  {
                   T? GetById(TKey id);
                   IEnumerable<T> GetAll();
                   void Add(T entity);
                   void Update(T entity);
                   void Delete(TKey id);
                  }
            */
            #endregion
            #region Question07
            /*  The struct constraint is a primary constraint, it specifies that the type parameter must be a value type.
                 Example : 
                 public class ValueStorage<T> where T : struct
                 {
                   public T Value { get; set; }
                 }
             */
            #endregion
            #region Question08
            /*
               The Class constraint is a primary constraint, it specifies that the type parameter must be a Reference type.
                Example : 
                public class Cache<T> where T : class
                {
                 private T? cachedItem;
                 public T? Get() => cachedItem;
                 public void Set(T item)
                 {
                 cachedItem = item;
                 }
                }      
             */
            #endregion
            #region Question09
            /*
                     new() is constructor constraint ,requires T to have a public Parameterless Constructor ,
                     this allows creating objects using new T().
                     Example : 
                     public class Factory<T> where T :new()
                     {
                        public T Create() 
                        {
                        return new T();
                        } 
                     }
           */
            #endregion
            #region Question10
            /*
                The interface constraint is used when T is required to implement a specific interface,this allows calling interface members safely.
                  Example : 
               public class FindMax<T> where T : IComparable<T>
               {
                  public T FindMax(T[] array)
                    {
                        T max = array[0];
                       foreach (T item in array)
                   {
                           if (item.CompareTo(max) > 0)
                       {
                            max = item;
                       }
                   }
                      return max;
                    }
               }
          */
            #endregion
            #region Question11
            /*
                     Base Class Constraint is restricts T to a specific base class or any class derived from it.
                     Example : 
                     public class Employee
                     {
                     }
                     public class Manager : Employee
                     {
                     }
                     public class Repository<T> where T : Employee
                     {
                     }
                     Valid : 
                     Repository<Employee>
                     Repository<Manager>
                     invalid :
                     Repository<car>
            */
            #endregion
            #region Question12
            /*  
               Can applied to the same type parameter
               Example:
               public interface IEntity
               {
                Guid Id { get; set; }
               }
               public class EntityManager<T>  where T : class, IEntity, new()
               {
                   public T Create()
                {
                   T entity = new T();
                   entity.Id = Guid.NewGuid();
                   return entity;
                }
               }
             */
            #endregion
        }
    }

}
