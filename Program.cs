namespace CAReflectionGoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enemy: ");

            do
            {
                var input = "CAReflectionGoon."+Console.ReadLine();
                object obg = null;
                try
                {
                    var assembliName = typeof(Program).Assembly.GetName().Name;
                    var enemy = Activator.CreateInstance("CAReflectionGoon", input);
                    obg = enemy.Unwrap();
                }
                catch (Exception)
                {
                }
                switch (obg)
                {
                    case Goon g:
                        Console.WriteLine(g);
                        break;
                    case Agar a:
                        Console.WriteLine(a);
                        break;
                    case Pixa p:
                        Console.WriteLine(p);
                        break;
                    default:
                        Console.WriteLine("unknown");
                        break;
                }

            } while (true);

            

            
        }
    }

    public class Goon
    {
        public override string ToString()
        {
            return $"{{ Speed: {20}, HitPower: {13}, Strength: {7}}}";
        }
    }
    public class Agar
    {
        public override string ToString()
        {
            return $"{{ Speed: {23}, HitPower: {11}, Strength: {12}}}";
        }
    }
    public class Pixa
    {
        public override string ToString()
        {
            return $"{{ Speed: {25}, HitPower: {10}, Strength: {9}}}";
        }
    }
}