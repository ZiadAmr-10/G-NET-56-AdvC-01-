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
        }
    }

}
