namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string bolString = "true";
                bool bol = Convert.ToBoolean(bolString);
                Console.WriteLine(bol);
            }
            catch (Exception ex) { 
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}