namespace Narazaka.SimpleHash
{
    public static class FNV1a32String
    {
        public static uint ComputeHash(string str)
        {
            return FNV1a32.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));
        }
    }
}
