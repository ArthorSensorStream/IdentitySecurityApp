namespace IdentitySecurity
{
    public class SecurePassword
    {
        public static string Encrypt(string input)
        {
            return $"extra security enc{input}";
        }
    }
}
