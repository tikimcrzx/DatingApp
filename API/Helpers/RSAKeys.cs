namespace API.Helpers
{
    public class RSAKeys
    {
        public RSAKeys()
        {
        }

        public RSAKeys(string rsaPrivateKey, string rsaPublicKey)
        {
            this.RsaPrivateKey = rsaPrivateKey;
            this.RsaPublicKey = rsaPublicKey;
        }
        public string RsaPrivateKey { get; set; }
        public string RsaPublicKey { get; set; }
    }
}