namespace Narazaka.SimpleHash
{
    public static class FNV1a32
    {
        // cvf. https://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        const uint FNV_OFFSET_BASIS = 2166136261;
        const uint FNV_PRIME = 16777619;
        public static uint ComputeHash(byte[] bytes)
        {
            uint hash = FNV_OFFSET_BASIS;
            var len = bytes.Length;
            for (var i = 0; i < len; i++)
            {
                hash = (hash ^ bytes[i]) * FNV_PRIME;
            }
            return hash;
        }

#if HAS_UDON_ENCODING
        public static uint ComputeHash(string str)
        {
            return ComputeHash(Koyashiro.UdonEncoding.UdonUTF8.GetBytes(str));
        }
#endif
    }
}
