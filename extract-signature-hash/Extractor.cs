using System;
using System.Security.Cryptography.X509Certificates;

namespace extract_signature_hash
{
    class Extractor
    {
        static void Main(string[] args)
        {
            Console.Write("Input path to signed binary: ");
            X509Certificate cert = X509Certificate.CreateFromSignedFile(Console.ReadLine());
            Console.WriteLine(cert.GetCertHashString());
        }
    }
}
