namespace Narazaka.SimpleHash
{
    public static class FNV1a32String
    {
#if HAS_UDON_ENCODING
        public static uint ComputeHash(string str)
        {
            return FNV1a32.ComputeHash(Koyashiro.UdonEncoding.UdonUTF8.GetBytes(str));
        }
#endif
    }
}
