namespace IdentitySecurity
{
    public class SecurePassword
    {
        public static string Encrypt(string input)
        {
            return $"enc{input}";
        }
    }
}
